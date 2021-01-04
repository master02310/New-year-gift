namespace Presents.Models.Grocary.Sweet
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Presents.Enum;

    public abstract class Sweet : Food
    {
        protected Sweet(double price, double weight, string createdBy, Country createdCountry)
            : base(price, weight, createdBy, createdCountry)
        {
        }

        /// <summary>
        /// Gets Type Of Sweet.
        /// </summary>
        public abstract TypeOfSweet TypeOfSweet { get; }
    }
}
