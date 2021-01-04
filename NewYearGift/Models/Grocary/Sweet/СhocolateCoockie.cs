namespace Presents.Models.Grocary.Sweet
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Presents.Enum;
    public class СhocolateCoockie : Cookie
    {
        public СhocolateCoockie(double price, double weight, string createdBy, Country createdCountry)
            : base(price, weight, createdBy, createdCountry)
        {
        }

        public override TypeOfSweet TypeOfSweet => TypeOfSweet.Flour;

        public override bool IsExistAlcohol => false;

        public override Ingredient[] Сomposition => new Ingredient[] { Ingredient.Buttle, Ingredient.Suger };

        public override string Name => "Сhocolate Coockie";

        public override TimeSpan LifeTime => TimeSpan.FromDays(14);

        public override TypeOfCookie TypeOfCookie => TypeOfCookie.Suger;

        public override double Calorie => 900;
    }
}
