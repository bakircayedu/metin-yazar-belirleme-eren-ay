using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    public class HashEntry
    {
        public HashNode Top;
        public int HashEntryKey;
        public int HashEntrySize;
        public HashEntry()
        {
            HashEntrySize = 0;
        }

        public bool IsEmpty()
        {
            return (HashEntrySize == 0);
        }

        public void HashNodeInsert(HashNode hashNode)
        {
            if (IsEmpty())
            {
                Top = hashNode;
            }
            else
            {
                hashNode.Next = Top;
                Top = hashNode;
            }
            HashEntrySize++;


            
        }

        public void HashNodeSearch(HashNode hashNode)
        {   //to do
            HashNode temp = Top;
            while (temp != null)
            {
                temp = temp.Next;
            }
            temp = hashNode;
        }

        public string HashNodeDondur()
        {
            HashNode temp = Top;
            string str="";
            Kelime kelime;
            while (temp != null)
            {
                kelime = (Kelime)temp.Data;
                str = str + " " + kelime.KelimeAdiOrjinal;
                temp = temp.Next;
            }
            return str;  
        } 

    }
}
