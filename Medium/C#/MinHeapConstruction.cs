using System;
using System.Collections.Generic;

public class MinHeapConstruction {
    public class MinHeap {
        public List<int> heap = new List<int>();

        public MinHeap(List<int> array) {
            heap = buildHeap(array);
        }

        public List<int> buildHeap(List<int> array) {
            int firstParentIdx = (array.Count - 2) / 2;
            for (int currentIdx = firstParentIdx; currentIdx >= 0; currentIdx--) {
                siftDown(currentIdx, array.Count - 1, array);
            }
            return array;
        }

        public void siftDown(int currentIdx, int endIdx, List<int> heap) {
            int childOneIdx = currentIdx * 2 + 1;
            while (childOneIdx <= endIdx) {
                int childTwoIdx = currentIdx * 2 + 2 <= endIdx ? currentIdx * 2 + 2 : -1;
                int idxToSwap;
                if (childTwoIdx != -1 && heap[childTwoIdx] < heap[childOneIdx]) {
                    idxToSwap = childTwoIdx;
                } else {
                    idxToSwap = childOneIdx;
                }

                if (heap[idxToSwap] < heap[currentIdx]) {
                    swap(currentIdx, idxToSwap, heap);
                    currentIdx = idxToSwap;
                    childOneIdx = currentIdx * 2 + 1;
                } else {
                    return;
                }
            }
        }

        public void siftUp(int currentIdx, List<int> heap) {
            int parentIdx = (currentIdx - 1) / 2;
            while (currentIdx > 0 && heap[currentIdx] < heap[parentIdx]) {
                swap(currentIdx, parentIdx, heap);
                currentIdx = parentIdx;
                parentIdx = (currentIdx - 1) / 2;
            }
        }

        public int Peek() {
            if (heap.Count == 0) {
                throw new IndexOutOfRangeException("Heap is empty");
            }
            return heap[0];
        }

        public int Remove() {
            if (heap.Count == 0) {
                throw new IndexOutOfRangeException("Heap is empty");
            }
            int lastIndex = heap.Count - 1;
            swap(0, lastIndex, heap);
            int valueToRemove = heap[lastIndex];
            heap.RemoveAt(lastIndex);
            siftDown(0, heap.Count - 1, heap);
            return valueToRemove;
        }

        public void Insert(int value) {
            heap.Add(value);
            siftUp(heap.Count - 1, heap);
        }

        private void swap(int i, int j, List<int> heap) {
            int temp = heap[i];
            heap[i] = heap[j];
            heap[j] = temp;
        }
    }

    public static void Main(string[] args) {
        List<int> array = new List<int> { 9, 4, 7, 1, -2, 6, 5 };
        MinHeap minHeap = new MinHeap(array);

        Console.WriteLine("Min Heap: " + string.Join(", ", minHeap.heap));

        minHeap.Insert(3);
        Console.WriteLine("Min Heap after inserting 3: " + string.Join(", ", minHeap.heap));

        int min = minHeap.Remove();
        Console.WriteLine("Min Heap after removing minimum (" + min + "): " + string.Join(", ", minHeap.heap));

        int peek = minHeap.Peek();
        Console.WriteLine("Peek at minimum value: " + peek);
    }
}
