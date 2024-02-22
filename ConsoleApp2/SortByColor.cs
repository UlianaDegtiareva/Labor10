using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibraryLaba10
{
    public class SortByColor : IComparer
    {
        public int Compare(object x, object y)
        {
            Plants p1 = x as Plants;
            Plants p2 = y as Plants;
            if (p1.Color.Length < p2.Color.Length) return -1;
            else if (p1.Color.Length == p2.Color.Length) return 0;
            else return 1;
        }
    }
}
