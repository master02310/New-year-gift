namespace Presents.Abstrcactions
{
    using Presents.Entities;

    public interface IPresentService
    {
        /// <summary>
        /// Make new year sweet box.
        /// </summary>
        /// <returns>return list sweet box.</returns>
        PresentBox MakeNewYearSweetBox();
    }
}
