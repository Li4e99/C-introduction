using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2
{
    public class Node
    {
        public int Value { get; set; }
        public Node NextNode { get; set; }
        public Node PrevNode { get; set; }
       
    }
    public interface ILinkedList
    {
        int GetCount(); // возвращает количество элементов в списке
        void AddNode(int value); // добавляет новый элемент списка
        void AddNodeAfter(Node node, int value); // добавляет новый элемент списка после определённого элемента
        void RemoveNode(int index); // удаляет элемент по порядковому номеру
        void RemoveNode(Node node); // удаляет указанный элемент
        Node FindNode(int searchValue); // ищет элемент по его значению
    }

    public class LinkedList : ILinkedList
    {
        readonly Node head = new Node();
        readonly Node tail = new Node();

        public void DoublyLinkedList()
        {
            head.NextNode = tail;
            tail.PrevNode = head;
        }

        public void AddNode(int value)
        {
            tail.PrevNode = new Node()
            {
                Value = value,
                PrevNode = tail.PrevNode
            };
        }

        public void AddNodeAfter(Node node, int value)
        {
            Node current = head.NextNode;
            while (current != tail && current != node)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                current.NextNode = new Node()
                {
                    Value = value,
                    PrevNode = current,
                    NextNode = current.NextNode
                };
            }
            else
            {
                throw new ArgumentException("Такого Узла нет в списке.", nameof(node));
            }
        }

        public Node FindNode(int searchValue)
        {
            Node current = head.NextNode;
            while (current != tail && current.Value != searchValue)
            {
                current = current.NextNode;
            }
            if (current != tail)
            {
                return current;
            }
            else
            {
                return null;
            }
        }

        public int GetCount()
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail)
            {
                current = current.NextNode;
                count++;
            }
            return count;
        }
        public void RemoveNode(int index)
        {
            int count = 0;
            Node current = head.NextNode;
            while (current != tail && count < index)
            {
                current = current.NextNode;
                count++;
            }
            if (count == index)
            {
                RemoveNode(current);
            }
            else
            {
                throw new ArgumentException("Узла с таким индексом нет в списке.", nameof(index));
            }
        }
        public void RemoveNode(Node node)
        {
            Node next = node.NextNode;
            Node prev = node.PrevNode;
            next.PrevNode = prev;
            prev.NextNode = next;
        }
    }
    /// <summary>
    /// Задание № 2. Бинарный поиск. Асимптомическая сложность данного алгоритма - O(log n)
    /// </summary>
    /// <param name = "inputArray" > массив для поиска</param>
    /// <param name = "searchValue" > искомое значение</param>
    /// <returns></returns>
    class Program
    {
        public static int BinarySearch(int[] inputArray, int searchValue)
        {
            Array.Sort(inputArray);
            int min = 0;
            int max = inputArray.Length - 1;
            while (min <= max)
            {
                int mid = (min + max) / 2;
                if (searchValue == inputArray[mid])
                {
                    return mid;
                }
                else if (searchValue < inputArray[mid])
                {
                    max = mid - 1;
                }
                else
                {
                    min = mid + 1;
                }
            }
            return -1;
        }

        /// <summary>
        /// Вспопогательный класс для тестирования.
        /// </summary>
        public class TestCase
        {
            public int X { get; set; }
            public int Expected { get; set; }
            public Exception ExpectedException { get; set; }
        }
        /// <summary>
        /// Вспомогательный метод для тестирования
        /// </summary>
        /// <param name="testCase"> </param>
        static void Test(TestCase testCase)
        {
            try
            {
                int[] array = new int[] { 1, 3, 2,5,4,6,8,7,10,9};
                Array.Sort(array);
                foreach (var item in array)
                {
                    Console.WriteLine(item);
                }
                    int actual = BinarySearch(array, testCase.X );
                if (actual == testCase.Expected)
                {
                    Console.WriteLine("Число найдено.");
                }
                else
                {
                    Console.WriteLine("Число не найдено.");
                }
            }
            catch (Exception ex)
            {
                if (testCase.ExpectedException != null)
                {
                    Console.WriteLine("Ошибка.");
                }
                else
                {
                    Console.WriteLine("Нет ошибки.");
                }
            }
        }
        static void Main(string[] args)
        {
            var testCase1 = new TestCase()
            {
                X = 10,
                Expected = 9,
                ExpectedException = null
            };
            var testCase2 = new TestCase()
            {
                X = 3,
                Expected = 4,
                ExpectedException = null
            };
            Test(testCase1);
            Test(testCase2);
            Console.ReadKey(true);
        }
    }
}
