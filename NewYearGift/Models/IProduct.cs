namespace Presents.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using Presents.Enum;

    public interface IProduct
    {
        string Name { get; }

        double Price { get; }

        TimeSpan LifeTime { get; }

        string CreatedBy { get; }

        Country CreatedCountry { get; }

        double Weight { get; }
    }
}
