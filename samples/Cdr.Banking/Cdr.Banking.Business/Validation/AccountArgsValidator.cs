﻿using Cdr.Banking.Business.Entities;
using CoreEx.Validation;

namespace Cdr.Banking.Business.Validation
{
    /// <summary>
    /// Represents a <see cref="AccountArgs"/> validator.
    /// </summary>
    public class AccountArgsValidator : Validator<AccountArgs>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AccountArgsValidator"/>.
        /// </summary>
        public AccountArgsValidator()
        {
            Property(x => x.OpenStatus).IsValid();
            Property(x => x.ProductCategory).IsValid();
        }
    }
}