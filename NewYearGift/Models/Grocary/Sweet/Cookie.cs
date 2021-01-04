namespace Presents.Models.Grocary.Sweet
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Presents.Enum;

    public abstract class Cookie : Sweet
    {
        protected Cookie(double price, double weight, string createdBy, Country createdCountry)
            : base(price, weight, createdBy, createdCountry)
        {
        }

        /// <summary>
        /// Gets Type Of Cookie.
        /// </summary>
        public abstract TypeOfCookie TypeOfCookie { get; }
    }
}
