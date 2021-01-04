namespace Presents.Models.Grocary.Sweet
{
    using System;
    using Presents.Enum;

    public class Raffaello : Candy
    {
        public Raffaello(double price, double weight, string createdBy, Country createdCountry)
                : base(price, weight, createdBy, createdCountry)
        {
        }

        public override TypeOfCandy TypeOfCandy => TypeOfCandy.Chewing;

        public override TypeOfSweet TypeOfSweet => TypeOfSweet.Candy;

        public override bool IsExistAlcohol => false;

        public override Ingredient[] Сomposition => new Ingredient[] { Ingredient.Buttle, Ingredient.Suger };

        public override string Name => "Raffaello";

        public override TimeSpan LifeTime => TimeSpan.FromDays(1);

        public override double Calorie => 700;
    }
}