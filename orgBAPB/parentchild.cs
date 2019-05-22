using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace orgBAPB
{
    class Parentchild
    {
        public readonly List<Parentchild> Childs;

        public Parentchild()
        {
            Childs = new List<Parentchild> ();

        }
    }
}
