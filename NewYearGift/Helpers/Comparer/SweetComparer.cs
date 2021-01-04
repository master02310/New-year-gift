namespace Presents.Helpers.Comparer
{
    using System.Collections;
    using Presents.Models.Grocary.Sweet;

    public class SweetComparer : IComparer
    {

        public int Compare(object first, object second)
        {
            var x = first as Sweet;
            var y = second as Sweet;

            if (x.Name.Length > y.Name.Length)
            {
                return 1;
            }
            else if (x.Name.Length < y.Name.Length)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
