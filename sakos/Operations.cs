using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static sakos.Medis;

namespace sakos
{
    class Operations
    {
        public class MaximumDepth
        {
            public static int MaxDepth(Saka root, int maxDepthThreshold, int depth)
            {
                if (root.children == null || !root.children.Any())
                {
                    return depth;
                }

                if (depth == maxDepthThreshold)
                {
                    return depth;
                }

                return root.children.Max(x => MaxDepth(x, maxDepthThreshold, depth++));
            }
        }
        public void GetDepth()
        {
            var saka8 = new Saka();
            var saka7 = new Saka();
            var saka5 = new Saka();
            var saka6 = new Saka();
            var saka3 = new Saka(0, new List<Saka> { saka5, saka6, saka7,saka8 });
            var saka2 = new Saka();
            var saka4 = new Saka();
            var saka1 = new Saka(0, new List<Saka> { saka3, saka2 });
            Console.WriteLine("Max Depth = " + MaximumDepth.MaxDepth(saka1, 1000, 1));

            Console.ReadKey();
        }
    }
}
