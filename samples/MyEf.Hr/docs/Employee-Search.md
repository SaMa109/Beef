﻿# Step 4 - Employee Search

This will walk through the process of creating and testing the employee search capability.

<br/>

## Functional requirement

The employee search will allow the following criteria to be searched:
- First and last name using wildcard; e.g. `Smi*`.
- Gender selection; zero, one or more.
- Start date range (from/to).
- Option to include terminated employees (default is to exclude).

The search should also support paging. The results should be returned in last name, first name and start date order.

Examples of the endpoint are as follows (or any combination thereof).

Endpoint | Description
-|-
`GET /employees?lastName=smi*` | all employees whose last name starts with `smi`.
`GET /employees?gender=f` | all female employees.
`GET /employees?startFrom=2000-01-01&startTo=2002-12-31` | all employess who started between 01-Jan-2000 and 31-Dec-2002 (inclusive).
`GET /employess?lastName=smi*&includeTerminated=true` | all employees whose last name starts with `smi`, both current and terminated.
`GET /employees?gender=f&$skip=10&$take25` | all female employees with paging (skipping the first 10 employees and getting the next 25 in sequence).

<br/>

## Data repository

During the initial database set up process the `Employee` table was enabled via code-generation leveraging an Entity Framework model class. This will be used to perform the query operations so that we can leverage .NET's LINQ-style query filtering and sorting.

<br/>

## Selection criteria

The API selection criteria will be enabled by defining a class with all of the requisite properties. _Beef_ will then expose each of the properties individually within the API Controller to enable their usage. _Beef_ can also automatically enable paging support when selected to do so; therefore, this does not need to be enabled via the selection criteria directly.

Add the following entity code-gen configuration after all the other existing entities within `entity.beef-5.yaml` (`MyEf.Hr.CodeGen` project).

``` yaml
  # Creating an EmployeeArgs entity
  # - Genders will support a list (none or more) reference data values.
  # - StartFrom, StartTo and IncludeTerminated are all Nullable so we can tell whether a value was provided or not.
  # - The IsIncludeTerminated overrides the JsonName to meet the stated requirement name of includeTerminated.
- { name: EmployeeArgs, text: '{{Employee}} search arguments',
    properties: [
      { name: FirstName },
      { name: LastName },
      { name: Genders, type: ^Gender, refDataList: true },
      { name: StartFrom, type: 'DateTime?', dateTimeTransform: DateOnly },
      { name: StartTo, type: 'DateTime?', dateTimeTransform: DateOnly },
      { name: IsIncludeTerminated, jsonName: includeTerminated, type: 'bool?' }
    ]
  }
```

The requisite `GetByArgs` operation needs to be added to the `Employee` entity configuration; add the following after the existing `Delete` operation.

``` yaml
      # Search operation
      # - OperationType is GetColl which indicates that a collection is the expected result.
      # - ReturnType is overriding the default Employee as we want to use EmployeeBase (reduced set of fields).
      # - PagingArgs indicates to Beef that paging support is required and to be automatically enabled for the operation.
      # - AutoImplement of EntityFramework informs code-gen to output EntityFramework code versus database stored procedures.
      # - EntityFrameworkModel needs to be specified as it can not be inferred from the entity itself. 
      # - Parameter defines the parameter being the EmployeeArgs (defined) and that the value should be validated.
      { name: GetByArgs, type: GetColl, paging: true, returnType: EmployeeBase, autoImplement: EntityFramework, entityFrameworkModel: EfModel.Employee,
        parameters: [
          { name: Args, type: EmployeeArgs, validator: EmployeeArgsValidator }
        ]
      }
```

Execute the code-generation using the command line.

```
dotnet run entity
```

</br>

## Data access logic

Within the entity code-gen configuration where auto-implmentation is not possible then the data access logic must be specified explicitly. _Beef_ will still generate the boilerplate/skeleton wrapping logic for the data access to ensure consistency, and will invoke a corresponding `*OnImplementation` method to perform (which the developer is then required to implement).

This logic must be implemented by the developer in a non-generated `partial` class. A new `EmployeeData.cs` must be created within `MyEf.Hr.Business/Data`; do **not** change any files under the `Generated` folder as these will be overridden during the next code-gen execution.

This new `EmployeeData.cs` (non-generated) logic will need to be extended to support the new `GetByArgs`. 

For query operations generally we do not implement using the custom `*OnImplementation` approach; as the primary code, with the exception of the actual search criteria can be generated successfully. As such, in this case _Beef_ will have generated an extension delegate named `_getByArgsOnQuery` to enable. This extension delegate will be passed in the `IQueryable<EfModel.Employee>` so that filtering and sorting, etc. can be applied, as well as the search arguments (`EmployeeArgs`). _Note:_ no paging is passed, or needs to be applied, as _Beef_ will apply this automatically.

Extensions within _Beef_ are leveraged by implementing the partial constructor method (`EmployeeDataCtor`) and providing an implementation for the requisite extension delegate (`_getByArgsOnQuery`).

Add the following code to the top of the non-generated `EmployeeData.cs` (`MyEf.Hr.Business/Data`) that was created. The `With` methods are enabled by _CoreEx_ to simplify the code logic to apply the filter only where the value is not `null`, plus specifically handle the likes of wildcards. Also note usage of [`IgnoreAutoIncludes`](https://learn.microsoft.com/en-us/dotnet/api/microsoft.entityframeworkcore.entityframeworkqueryableextensions.ignoreautoincludes) (a standard Entity Framework capability) to avoid the cost of loading related data that is not needed for this query. 

``` csharp
partial void EmployeeDataCtor()
{
    // Implement the GetByArgs OnQuery search/filtering logic.
    _getByArgsOnQuery = (q, args) =>
    {
        _ef.WithWildcard(args?.FirstName, (w) => q = q.Where(x => EF.Functions.Like(x.FirstName, w)));
        _ef.WithWildcard(args?.LastName, (w) => q = q.Where(x => EF.Functions.Like(x.LastName, w)));
        _ef.With(args?.Genders, () => q = q.Where(x => args!.Genders!.ToCodeList().Contains(x.GenderCode)));
        _ef.With(args?.StartFrom, () => q = q.Where(x => x.StartDate >= args!.StartFrom));
        _ef.With(args?.StartTo, () => q = q.Where(x => x.StartDate <= args!.StartTo));

        if (args?.IsIncludeTerminated == null || !args.IsIncludeTerminated.Value)
            q = q.Where(x => x.TerminationDate == null);

        return q.IgnoreAutoIncludes().OrderBy(x => x.LastName).ThenBy(x => x.FirstName).ThenBy(x => x.StartDate);
    };
}
```

<br/>

## Validation

Within the `MyEf.Hr.Business/Validation` folder, create `EmployeeArgsValidator.cs` and implement as follows.

``` csharp
namespace MyEf.Hr.Business.Validation;

/// <summary>
/// Represents a <see cref="EmployeeArgs"/> validator.
/// </summary>
public class EmployeeArgsValidator : Validator<EmployeeArgs>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmployeeValidator"/> class.
    /// </summary>
    public EmployeeArgsValidator()
    {
        Property(x => x.FirstName).Common(CommonValidators.PersonName).Wildcard();
        Property(x => x.LastName).Common(CommonValidators.PersonName).Wildcard();
        Property(x => x.Genders).AreValid();
        Property(x => x.StartFrom).CompareProperty(CompareOperator.LessThanEqual, x => x.StartTo);
    }
}
```

<br/>

## End-to-End testing

For the purposes of this sample un-comment the region `GetByArgs` within `EmployeeTest.cs`. Execute the tests and ensure they all pass as expected.

As extra homework, you should also consider implementing unit testing for the validator.

<br/>

## Conclusion

At this stage we now have added and tested the employee search, in addition to the employee CRUD APIs. 

Next we will implement the [employee termination](./Employee-Terminate.md) endpoint.
