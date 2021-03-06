using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;
using System.Runtime.Serialization;
using HTLib3;

namespace HTLib3
{
    public partial class Collections
	{
        public static int HIndexMin<T>(this T[] values)
            where T : IComparable<T>
        {
            int idxmax = 0;
            for(int i=1; i<values.Length; i++)
                if(values[idxmax].CompareTo(values[i]) > 0)
                    idxmax = i;
            return idxmax;
        }
        public static int[] HIndexMin<T>(this T[,] values)
            where T : IComparable<T>
        {
            int idxmax0 = 0, idxmax1 = 0;
            for(int i0=0; i0<values.GetLength(0); i0++)
                for(int i1=0; i1<values.GetLength(1); i1++)
                    if(values[idxmax0, idxmax1].CompareTo(values[i0, i1]) > 0)
                    {
                        idxmax0 = i0;
                        idxmax1 = i1;
                    }
            return new int[] { idxmax0, idxmax1 };
        }
        public static int[] HIndexMin<T>(this T[, ,] values)
            where T : IComparable<T>
        {
            int idxmax0 = 0, idxmax1 = 0, idxmax2 = 0;
            for(int i0=0; i0<values.GetLength(0); i0++)
                for(int i1=0; i1<values.GetLength(1); i1++)
                    for(int i2=0; i2<values.GetLength(2); i2++)
                        if(values[idxmax0, idxmax1, idxmax2].CompareTo(values[i0, i1, i2]) > 0)
                        {
                            idxmax0 = i0;
                            idxmax1 = i1;
                            idxmax2 = i2;
                        }
            return new int[] { idxmax0, idxmax1, idxmax2 };
        }
        
        public static T HMin<T>(this T[,] values)
            where T : IComparable<T>
		{
            int[] idxmin = HIndexMin(values);
            Debug.Assert(idxmin.Length == 2);
            return values[idxmin[0], idxmin[1]];
        }
        public static T HMin<T>(this T[,,] values)
            where T : IComparable<T>
        {
            int[] idxmin = HIndexMin(values);
            Debug.Assert(idxmin.Length == 3);
            return values[idxmin[0], idxmin[1], idxmin[2]];
        }

        public static T HMinNth<T>(this IList<T> values, int nth)
            where T : IComparable<T>
        {
            int[] idxsortd = values.HIdxListSorted();
            return values[idxsortd[nth]];
        }
    }
}
