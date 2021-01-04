namespace Presents.Srevices
{
    using Presents.Abstrcactions;
    using Presents.Entities;
    using Presents.Models.Grocary.Sweet;
    using Presents.Enum;

    public class PresentService : IPresentService
    {
        public PresentService()
        {
        }

        public PresentBox MakeNewYearSweetBox()
        {
            var sweet = new Sweet[]
            {
                new Raffaello(66, 689, "SomeCompany", Enum.Country.Ukraine),
                new СhocolateCoockie(345, 390, "SomeCompany", Enum.Country.Ukraine),
                new Raffaello(875, 342, "SomeCompany", Enum.Country.Ukraine),
                new СhocolateCoockie(35, 804, "SomeCompany", Enum.Country.Ukraine),
            };

            var weight = 0d;
            for (var i = 0; i < sweet.Length; i++)
            {
                weight += sweet[i].Weight;
            }

            return new PresentBox { Sweets = sweet, Weight = weight };
        }
    }
}
