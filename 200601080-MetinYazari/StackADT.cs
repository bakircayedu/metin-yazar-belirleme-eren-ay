using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    public abstract class StackADT
    {
        public Node Top;

        public int Size = 0;
        protected abstract void Push(Node item);
        protected abstract Node Pop();
        protected abstract Node View();
        public abstract bool IsEmpty();
        
    }
}
