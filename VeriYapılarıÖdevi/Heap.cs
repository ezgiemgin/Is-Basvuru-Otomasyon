using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeriYapılarıÖdevi
{
    public class Heap
    {
        private HeapDugumu[] heapArray;
        private int maxSize;
        private int currentSize;
        public Heap(int maxHeapSize)
        {
            maxSize = maxHeapSize;
            currentSize = 0;
            heapArray = new HeapDugumu[maxSize];
        }
        public bool IsEmpty()
        { 
            return currentSize == 0; 
        }
        public bool Insert(object value)
        {
            if (currentSize == maxSize)
                return false;
            HeapDugumu newHeapDugumu = new HeapDugumu(value);
            heapArray[currentSize] = newHeapDugumu;
            MoveToUp(currentSize++);
            return true;
        }
        public void MoveToUp(int index)
        {
            int parent = (index - 1) / 2;
            HeapDugumu bottom = heapArray[index];
            while (index > 0 && ((Kisi)heapArray[parent].Deger).Uygunluk < ((Kisi)bottom.Deger).Uygunluk)
            {
                heapArray[index] = heapArray[parent];
                index = parent;
                parent = (parent - 1) / 2;
            }
            heapArray[index] = bottom;
        }
        public HeapDugumu RemoveMax() // Remove maximum value HeapDugumu
        {
            HeapDugumu root = heapArray[0];
            heapArray[0] = heapArray[--currentSize];
            MoveToDown(0);
            return root;
        }
        public void MoveToDown(int index)
        {
            int largerChild;
            HeapDugumu top = heapArray[index];
            while (index < currentSize / 2)
            {
                int leftChild = 2 * index + 1;
                int rightChild = leftChild + 1;
                //Find larger child
                if (rightChild < currentSize && ((Kisi)heapArray[leftChild].Deger).Uygunluk < ((Kisi)heapArray[rightChild].Deger).Uygunluk)
                    largerChild = rightChild;
                else
                    largerChild = leftChild;
                if (((Kisi)top.Deger).Uygunluk >= ((Kisi)heapArray[largerChild].Deger).Uygunluk)
                    break;
                heapArray[index] = heapArray[largerChild];
                index = largerChild;
            }
            heapArray[index] = top;
        }
        public List<object> DisplayHeap()
        {
            List<object> kisi = new List<object>();
            for (int i = 0; i < currentSize; i++)
                kisi.Add(heapArray[i].Deger);
            return kisi;
        }
        
    }
}
