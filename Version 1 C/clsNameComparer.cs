using System;
using System.Collections;

namespace Version_1_C
{
    class clsNameComparer : IComparer
    {
        public int Compare(Object x, Object y)
        {
            clsWork lcWorkClassX = (clsWork)x;
            clsWork lcWorkClassY = (clsWork)y;
            string lcNameX = lcWorkClassX.Name;
            string lcNameY = lcWorkClassY.Name;

            return lcNameX.CompareTo(lcNameY);
        }
    }
}
