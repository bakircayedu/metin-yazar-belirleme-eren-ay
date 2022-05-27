using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MetinYazari
{
    public class HeapKelimeTree:HeapTree
    {
        public int say = 0;
        public override bool insertHeapData(HeapNode node)
        {
            say++;
            if (!IsFull())
            {
                say++;
                HeapDizi[currentNode] = node;
                heapPlaceFinder(currentNode++);
                return true;
            }
            else
            {
                return false;
            }


        }

        private bool heapKelimeKontrol(Kelime kelime)
        {
            string adi = kelime.KelimeAd; ;
            HeapNode heapNode = new HeapNode();
            HeapNode top = new HeapNode();

            for (int i = 0; i < currentNode; i++)
            {
                top = HeapDizi[i];
                Kelime kelime2 = new Kelime();
                kelime2 = (Kelime)HeapDizi[i].Data;
                if (kelime2.KelimeAd == adi)
                {
                    while (top!=null)
                    {
                        top=top.Next;
                    }
                    heapNode.Data = kelime;
                    top = heapNode;
                    return true;
                }
            }

            return false;

        }       


        public void heapKelimeTreeCreateWithLink(Node node)
        {
            Node tmp = node;

            while (tmp != null)
            {
                Kelime kelime = new Kelime();
                HeapNode heapNode = new HeapNode();
                kelime = (Kelime)tmp.Data;
                heapNode.Data = kelime;
                heapNode.SiralamaOlcutu = kelime.KelimeSiklik;
                if (heapKelimeKontrol(kelime))
                { }
                else
                {
                    insertHeapData(heapNode);
                }

                tmp = tmp.Next;
            }



        }
        public HeapKelimeTree(int DiziBoyut)
        {
            currentNode = 0;
            diziMax = DiziBoyut;
            HeapDizi = new HeapNode[diziMax];
        }

    }
}
