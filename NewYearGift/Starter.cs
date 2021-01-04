namespace Presents
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Presents.Helpers.Comparer;
    using Presents.Abstrcactions;
    using Presents.Srevices;

    public class Starter
    {
        private readonly IPresentService presentService;

        /// <summary>
        /// Initializes a new instance of the <see cref="Starter"/> class.
        /// </summary>
        public Starter()
        {
            this.presentService = new PresentService();
        }

        /// <summary>
        /// Run buisness logic.
        /// </summary>
        public void Run()
        {
            var sweet = this.presentService.MakeNewYearSweetBox();
            Array.Sort(sweet.Sweets, new SweetComparer());

            for (int i = 0; i < sweet.Sweets.Length; i++)
            {
                Console.WriteLine($"Name: {sweet.Sweets[i].Name} Weight: {sweet.Sweets[i].Weight} Calorie: {sweet.Sweets[i].Calorie}");
            }

            Console.WriteLine($"Sweet box weight: {sweet.Weight}");
        }
    }
}
