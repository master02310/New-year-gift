namespace Presents.Models.Grocary
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Presents.Enum;

    public abstract class Grocary : IProduct
    {
        private readonly double price;
        private readonly double weight;
        private readonly string createdBy;
        private readonly Country createdCountry;
        private readonly DateTime createdTime = DateTime.UtcNow;

        /// <summary>
        /// Initializes a new instance of the <see cref="Grocary"/> class.
        /// </summary>
        /// <param name="price">Price of product in grocary.</param>
        /// <param name="weight">Weight of product in grocary.</param>
        /// <param name="lifeTime">LifeTime of product in grocary.</param>
        /// <param name="createdBy">CreatedBy of product in grocary.</param>
        /// <param name="createdCountry">CreatedCountry of product in grocary.</param>
        protected Grocary(double price, double weight, string createdBy, Country createdCountry)
        {
            this.price = price;
            this.createdBy = createdBy;
            this.createdCountry = createdCountry;
            this.weight = weight;
        }

        /// <summary>
        /// Gets name of product in grocary.
        /// </summary>
        public abstract string Name { get; }

        /// <summary>
        /// Gets price of product in grocary.
        /// </summary>
        public double Price => this.price;

        /// <summary>
        /// Gets life time of product in grocary.
        /// </summary>
        public abstract TimeSpan LifeTime { get; }

        /// <summary>
        /// Gets experation date of product in grocary.
        /// </summary>
        public DateTime ExperationDate => this.createdTime + this.LifeTime;

        /// <summary>
        /// Gets created date of product in grocary.
        /// </summary>
        public DateTime CreatedDate => this.createdTime;

        /// <summary>
        /// Gets name of creator of product in grocary.
        /// </summary>
        public string CreatedBy => this.createdBy;

        /// <summary>
        /// Gets name of creator's country of product in grocary.
        /// </summary>
        public Country CreatedCountry => this.createdCountry;

        /// <summary>
        /// Gets weight of product.
        /// </summary>
        public double Weight => this.weight;

        /// <summary>
        /// Gets calorie of item from grocary.
        /// </summary>
        public abstract double Calorie { get; }
    }
}
