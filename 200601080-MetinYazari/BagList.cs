using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    public class BagList:StackADT
    {
        protected override void Push(Node item) //listenin sonuna eleman ekler
        {
            if (IsEmpty())
            {
                Top = item;
            }
            else
            {
                item.Next=Top;
                Top=item;
            }
            Size++;
        }
        protected override Node Pop() // listenin en ust elemanini dondurur ve siler
        {
            Node tmp;
            if (IsEmpty())
            {
                return null;
            }
            else
            {
                tmp = View();
                Top=Top.Next;
                Size--;
                return tmp;
            }
        }

        protected override Node View() //listenin en ust elemanini dondurur
        {
            if (IsEmpty())
            {
                return null;
            }
            else
            {   
                return Top;
            }
        }

        public override bool IsEmpty() //Listenin bos olup olmadigina bakar
        {
            if (Top == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        
    }

}
