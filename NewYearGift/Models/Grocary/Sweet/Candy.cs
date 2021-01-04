namespace Presents.Models.Grocary.Sweet
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Presents.Enum;

    public abstract class Candy : Sweet
    {
        

        protected Candy(double price, double weight, string createdBy, Country createdCountry)
            : base(price, weight, createdBy, createdCountry)
        {
        }

        /// <summary>
        /// Gets Type Of Candy.
        /// </summary>
        public abstract TypeOfCandy TypeOfCandy { get; }
    }
}
