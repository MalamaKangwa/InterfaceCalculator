using System;
using System.Collections.Generic;
using System.Text;

namespace Z_Score
{
    public class getZ_Score: IZScore
    {
        public static dynamic result;

        public dynamic ZScore(dynamic a, dynamic arrayA)
        {
            result = FindZ_Score.ZScore(a, arrayA);
            return result;
        }
    }
}
