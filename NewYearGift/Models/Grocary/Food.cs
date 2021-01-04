namespace Presents.Models.Grocary
{
    using Presents.Enum;

    public abstract class Food : Grocary
    {
        protected Food(double price, double weight, string createdBy, Country createdCountry)
            : base(price, weight, createdBy, createdCountry)
        {
        }

        public abstract bool IsExistAlcohol { get; }

        public abstract Ingredient[] Сomposition { get; }
    }
}
