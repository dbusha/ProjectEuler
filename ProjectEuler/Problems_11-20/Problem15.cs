using System;
using ProjectEuler.Maths;

namespace ProjectEuler
{
    public class Problem15
    {
        /*
         * Starting in the top left corner of a 2×2 grid, and only being able to move to the right and down,
         * there are exactly 6 routes to the bottom right corner.
         *  _____  __         _              _
         *  |_|_|    |   |     |   |_   |__   |_ 
         *  |_|_|    |   |__   |_    |_    |    |
         *
         * How many such routes are there through a 20×20 grid?
         *
         *    1           1
         *    2        1  2  1
         *    3      1  3  3  1
         *    4    1  4  6  4  1
         *    5   1  5  10 10 5  1
         *    6  1  6  15 20 15 6 1
         * 
         */

        public long Solution1(int depth)
        {
            int value = depth * 2;
            var pt = new PascalsTriangle(value);
            pt.Build();
            return pt.MaxPaths();
        }


        public long Solution2(int depth)
        {
            // this will overflow an int64
            int value = depth * 2;
            long numerator = 1;
            long denominator = 1;
            for (int i = value; i > 1; i--)
            {
                if (i > depth) {
                    if ((numerator * i) < 0 )
                        throw new Exception("numerator int64 overflow");
                    numerator *= i;
                }
                else
                    if ((denominator * i) < 0 )
                        throw new Exception("denominator int64 overflow");
                    denominator *= i;
            }

            return numerator / denominator;
        }
}
}