﻿using My.Hr.Common.Entities;

namespace My.Hr.Test.Apis;

[TestFixture, NonParallelizable]
public class PerformanceReviewTest : UsingApiTester<Startup>
{
    [OneTimeSetUp]
    public void OneTimeSetUp() => TestSetUp.Default.SetUp();

    #region Get

    [Test]
    public void A110_Get_NotFound()
    {
        Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.NotFound)
            .Run(a => a.GetAsync(404.ToGuid()));
    }

    [Test]
    public void A110_Get()
    {
        Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .IgnoreChangeLog()
            .IgnoreETag()
            .ExpectValue(_ => new PerformanceReview
            {
                Id = 2.ToGuid(),
                EmployeeId = 1.ToGuid(),
                Date = new DateTime(2016, 11, 12, 0, 0, 0, DateTimeKind.Utc),
                Outcome = "EE",
                Reviewer = "r.Browne@org.com",
                Notes = "They are awesome!"
            })
            .Run(a => a.GetAsync(2.ToGuid()));
    }

    #endregion

    #region GetByEmployeeId

    [Test]
    public void A210_GetByEmployeeId_NotFound()
    {
        var v = Agent<PerformanceReviewAgent, PerformanceReviewCollectionResult>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .Run(a => a.GetByEmployeeIdAsync(4.ToGuid())).Value!;

        Assert.IsNotNull(v);
        Assert.IsNotNull(v.Items);
        Assert.AreEqual(0, v.Items.Count);
    }

    [Test]
    public void A220_GetByEmployeeId()
    {
        var v = Agent<PerformanceReviewAgent, PerformanceReviewCollectionResult>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .Run(a => a.GetByEmployeeIdAsync(2.ToGuid())).Value!;

        Assert.IsNotNull(v);
        Assert.IsNotNull(v.Items);
        Assert.AreEqual(2, v.Items.Count);
        Assert.AreEqual(new string[] { "Work quality low.", "Work quality below standard." }, v.Items.Select(x => x.Notes).ToArray());
    }

    [Test]
    public void A220_GetByEmployeeId_Last()
    {
        var v = Agent<PerformanceReviewAgent, PerformanceReviewCollectionResult>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .Run(a => a.GetByEmployeeIdAsync(2.ToGuid(), PagingArgs.CreateSkipAndTake(0, 1))).Value!;

        Assert.IsNotNull(v);
        Assert.IsNotNull(v.Items);
        Assert.AreEqual(1, v.Items.Count);
        Assert.AreEqual(new string[] { "Work quality low." }, v.Items.Select(x => x.Notes).ToArray());
    }

    #endregion

    #region Create

    [Test]
    public void B110_Create()
    {
        var v = new PerformanceReview
        {
            Date = new DateTime(2020, 06, 15, 0, 0, 0, DateTimeKind.Utc),
            Outcome = "ME",
            Notes = "Solid performance :-)",
            Reviewer = "the.boss@org.com",
        };

        // Create value.
        v = Agent<PerformanceReviewAgent, PerformanceReview>()
            .ExpectStatusCode(HttpStatusCode.Created)
            .ExpectChangeLogCreated()
            .ExpectETag()
            .ExpectIdentifier()
            .ExpectValue(_ => v, "EmployeeId")
            .ExpectEvent("my.hr.performancereview", "created")
            .Run(a => a.CreateAsync(v, 3.ToGuid())).Value!;

        Assert.AreEqual(3.ToGuid(), v.EmployeeId);

        // Check the value was created properly.
        Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .ExpectValue(_ => v)
            .Run(a => a.GetAsync(v.Id));
    }

    #endregion

    #region Update

    [Test]
    public void C110_Update_NotFound()
    {
        // Get an existing value.
        var v = Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .Run(a => a.GetAsync(3.ToGuid())).Value!;

        // Try updating with an invalid identifier.
        Agent<PerformanceReviewAgent, PerformanceReview>()
            .ExpectStatusCode(HttpStatusCode.NotFound)
            .Run(a => a.UpdateAsync(v, 404.ToGuid()));
    }

    [Test]
    public void C120_Update_Concurrency()
    {
        // Get an existing value.
        var id = 3.ToGuid();
        var v = Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .Run(a => a.GetAsync(id)).Value!;

        // Try updating the value with an invalid eTag (if-match).
        Agent<PerformanceReviewAgent, PerformanceReview>()
            .ExpectStatusCode(HttpStatusCode.PreconditionFailed)
            .Run(a => a.UpdateAsync(v, id, new HttpRequestOptions { ETag = TestSetUp.Default.ConcurrencyErrorETag }));

        // Try updating the value with an invalid eTag.
        v.ETag = TestSetUp.Default.ConcurrencyErrorETag;
        Agent<PerformanceReviewAgent, PerformanceReview>()
            .ExpectStatusCode(HttpStatusCode.PreconditionFailed)
            .Run(a => a.UpdateAsync(v, id));
    }

    [Test]
    public void C130_Update()
    {
        // Get an existing value.
        var id = 3.ToGuid();
        var v = Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .Run(a => a.GetAsync(id)).Value!;

        // Make some changes to the data.
        v.Notes += "X";

        // Update the value.
        v = Agent<PerformanceReviewAgent, PerformanceReview>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .ExpectChangeLogUpdated()
            .ExpectETag(v.ETag)
            .ExpectIdentifier()
            .ExpectValue(_ => v)
            .ExpectEvent($"my.hr.performancereview", "updated")
            .Run(a => a.UpdateAsync(v, id)).Value!;

        // Check the value was updated properly.
        Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .ExpectValue(_ => v)
            .Run(a => a.GetAsync(id));
    }

    #endregion

    #region Delete

    [Test]
    public void E110_Delete()
    {
        var id = 3.ToGuid();

        // Get an existing value.
        Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.OK)
            .Run(a => a.GetAsync(id));

        // Delete value.
        Agent<PerformanceReviewAgent>()
            .ExpectStatusCode(HttpStatusCode.NoContent)
            .ExpectEvent($"my.hr.performancereview", "deleted")
            .Run(a => a.DeleteAsync(id));

        // Check value no longer exists.
        Agent<PerformanceReviewAgent, PerformanceReview?>()
            .ExpectStatusCode(HttpStatusCode.NotFound)
            .Run(a => a.GetAsync(id));

        // Delete again (should still be successful as a Delete is idempotent); note there should be no corresponding event as nothing actually happened.
        Agent<PerformanceReviewAgent>()
            .ExpectStatusCode(HttpStatusCode.NoContent)
            .Run(a => a.DeleteAsync(id));
    }

    #endregion
}