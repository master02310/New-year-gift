namespace Presents.Entities
{
    using System;
    using Presents.Models.Grocary.Sweet;

    public class PresentBox
    {
        /// <summary>
        /// Gets or sets sweets.
        /// </summary>
        public Sweet[] Sweets { get; set; }

        /// <summary>
        /// Gets or sets sweets.
        /// </summary>
        public double Weight { get; set; }
    }
}
