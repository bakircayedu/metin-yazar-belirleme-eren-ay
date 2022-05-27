using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MetinYazari
{
    public class HeapTree
    {
        public HeapNode[] HeapDizi  { get; set; }
        public int diziMax { get;protected set; }
        public int currentNode { get; set; }
        protected HeapTree()
        {
            currentNode = 0;
            HeapDizi = new HeapNode[1];
        }
        public HeapTree(int DiziBoyut)
        {
            currentNode=0;
            diziMax = DiziBoyut;
            HeapDizi=new HeapNode[diziMax];
        }

        public bool IsEmpty()
        {
            if (currentNode==0)
            {
                return true;
            }
            return false;
        }
        public bool IsFull()
        {
            if (currentNode==diziMax)
            {
                return true;
            }
            return false ;
            
        }

        public virtual bool insertHeapData(HeapNode node)
        {

            if (!IsFull())
            {
                HeapDizi[currentNode] = node;
                heapPlaceFinder(currentNode);
                currentNode++;

                return true;
            }
            else
            {
                return false;
            }
        }

        public virtual void heapPlaceFinder(int arrayNo)
        {

            int Parent = (arrayNo - 1) / 2;
            HeapNode tmp = HeapDizi[arrayNo];
            while (arrayNo > 0 && HeapDizi[Parent].SiralamaOlcutu < tmp.SiralamaOlcutu) //maxheap
            {
                HeapDizi[arrayNo] = HeapDizi[Parent];
                arrayNo = Parent;
                Parent = (Parent - 1) / 2;
            }
            HeapDizi[arrayNo] = tmp;
        }

        public void heapSort()
        {
            this.HeapDizi=heapSort(HeapDizi);
        }
        
        private HeapNode[] heapSort(HeapNode[] heapTree)
        {
            int i = 0;
            int tmpCurrentNode = currentNode;
            HeapNode[] sortedTree = new HeapNode[heapTree.Length];
            while (tmpCurrentNode != 0)
                sortedTree[i++] = RemoveMax(--tmpCurrentNode);
            return sortedTree;
        }

        protected void MoveToDown(int index)
        {
            int largerChild;
            

            HeapNode top = HeapDizi[index];
            while (index < currentNode / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                if (HeapDizi[leftChild].SiralamaOlcutu < HeapDizi[rightChild].SiralamaOlcutu)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (top.SiralamaOlcutu >= HeapDizi[largerChild].SiralamaOlcutu)
                    break;
                HeapDizi[index] = HeapDizi[largerChild];
                index = largerChild;
            }
            HeapDizi[index] = top; //top = max
        }

        public HeapNode RemoveMax(int tmpCurrentNode) // Remove maximum value HeapDugumu
        {
            
            HeapNode tmp = HeapDizi[0];
            HeapDizi[0] = HeapDizi[tmpCurrentNode];
            MoveToDown(0);
            return tmp;
        }



    }
}
