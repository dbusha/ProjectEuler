using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace ProjectEuler.Maths
{
    public class PascalsTriangle
    {
        private readonly List<long[]> triangle_;


        public PascalsTriangle(int depth)
        {
            Depth = depth;
            triangle_ = new List<long[]>(Depth+1);
        }


        public int Depth { get; }


        public void Build()
        {
           
            for (int row = 0; row <= Depth; row++)
            {
                if (row == 0)
                {
                    triangle_.Add(new long[1]);
                    triangle_[row][0] = 1;
                    continue;
                }
                
                var previousLevel = triangle_[row-1];
                triangle_.Add(new long[row+1]);

                for (int index = 0; index < triangle_[row].Length; index++)
                {
                    long value = 1;
                    if (index > 0 && index < previousLevel.Length)
                        value = previousLevel[index] + previousLevel[index - 1];

                    triangle_[row][index] = value;
                }

            }
        }
        
        
        public long MaxPaths(int depth = 0)
        {
            if (depth == 0) 
                depth = Depth;

            var result = triangle_[depth].Max(i => i);
            return result;
        }

        
        public void PrintTriangle()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var row in triangle_) {
                foreach (var value in row)
                    sb. Append(value < 10 ? $"  {value} " : $" {value} ");

                sb.AppendLine();
            }
            
            Trace.Write(sb.ToString());
        }
        
    }
}