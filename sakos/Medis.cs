using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace sakos
{
    class Medis
    {
        public class Saka
        {
        
            public List<Saka> children;

            public Saka()
            {
            }

            public Saka(int _val, List<Saka> _children)
            {
          
                children = _children;
            }
        }

    }
}
