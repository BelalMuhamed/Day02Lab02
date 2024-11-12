using System.ComponentModel.Design;
using System.Xml.Linq;

namespace Bonus
{
    public class Program
    {
        //create array 
        #region Create Array 
        public static int[] CreateArray() 
        {
            int size;
            
            bool flag = true;
            do
            {
                Console.WriteLine("Enter the size of the array more than zero ");
                flag = int.TryParse(Console.ReadLine(),out size);
            }
            while (!flag || size==0);
            int[] NumbersArray = new int[size];
            for(int i = 0;i<size;i++)
            {
                bool flag01 = true;
                do
                {
                    Console.WriteLine($"Enter the element {i+1} : ");
                   flag01= int.TryParse(Console.ReadLine(),out NumbersArray[i]);
                }
                while (!flag01);
            }
            return NumbersArray;
        }
        #endregion
        ////max length
        #region Get Max Int
        public static int GetMaxNumberOfTheArray(int[] Array)
        {
            int MaxNumber =Array[0];
            for(int i = 0;i<Array.Length;i++)
            {
                if (MaxNumber < Array[i])
                {
                    MaxNumber = Array[i];
                }
            }
            return MaxNumber;
        }
        #endregion
        //swap two numbers 
        #region Swap
        public static void Swap(ref int num01,ref int num02)
        {
            int temp = num02;
            num02 = num01;
            num01 = temp;
        }
        #endregion
        //reverse array
        #region Reverse Elements of the array
        public static void ReverseArray(int[] array)
        {
            if (array.Length > 1)
            {
                for (int i = 0; i < array.Length / 2; i++)
                {
                    int k = array.Length - i - 1;
                    Swap(ref array[i],ref array[k]);
                }
            }
        }
        #endregion
        //count the number of occurrences
        #region count the number of occurrences
        public static int CountTheNumberOfOccurrences(int[] array,int NummberWantToKnowCount)
        {
            int counter = 0; 
            for(int i = 0;i<array.Length;i++)
            {
                if (NummberWantToKnowCount == array[i])
               
                    counter++;
                else 
                    continue;

                
            }
            return counter;
        }
        #endregion

        //remove duplicate elements from an array
        #region remove duplicate elements from an array
        public static List<int> RemoveDuplicates(int[] array)
        {
            List<int> listWithOutDuplicate = new List<int>();
            for(int i = 0; i< array.Length;i++)
            {
                if(!listWithOutDuplicate.Contains(array[i]))
                {
                    listWithOutDuplicate.Add(array[i]);
                }
            }
            return listWithOutDuplicate;
        }
        #endregion

        // find the second largest element in an array

        #region FindTheSecondLargest
        public static int FindTheSecondMaxArray(int[] array)
        {
            int FMax = array[0];
            int SMax=array[1];
            if(FMax < SMax)
                Swap(ref FMax,ref SMax);
            for(int i = 2;i< array.Length;i++)
            {
                if (FMax < array[i])
                {
                    SMax = FMax;
                    FMax = array[i];
                }
                else if(SMax< array[i])
                {
                    SMax=array[i];
                }
                
            }
            return SMax;
        }
        #endregion

        //find the index of the minimum element in an array
        #region find the index of the minimum element in an array
        public static int MinElementIndex(int[]array)
        {
            int minElement = array[0];
           int  MinElementIndex =0;
            for(int i = 0;i< array.Length;i++)
            {
                if(minElement > array[i])
                {
                    minElement = array[i];
                    MinElementIndex= i;
                }
                    
            }
            return MinElementIndex;
        }
        #endregion
        static void Main(string[] args)
        {
            //create array 
            int[] ArrayOfNumbers = CreateArray();
            //max length
            int MaxOfTheArray = GetMaxNumberOfTheArray(ArrayOfNumbers);
            Console.WriteLine($"MAx Number in this array is : {MaxOfTheArray}");
            //reversed array 
            ReverseArray(ArrayOfNumbers);
            Console.WriteLine("Reversed Array  : ");
            for (int i = 0; i < ArrayOfNumbers.Length; i++)
            {
                Console.WriteLine($"Element {i + 1} : {ArrayOfNumbers[i]}");
            }
            //count the number of occurrences
            int NumberWantToSearch;
            bool flag = true;
            do
            {
                Console.WriteLine("Enter the number want to know how time it occurrences ");
                flag = int.TryParse(Console.ReadLine(), out NumberWantToSearch);
            } while (!flag);
            int Count = CountTheNumberOfOccurrences(ArrayOfNumbers, NumberWantToSearch);
            Console.WriteLine($"{NumberWantToSearch} Occurrences : {Count} Times  ");
            //list with out duplicate
            List<int> ArrayWithOutDuplicate = RemoveDuplicates(ArrayOfNumbers);
            foreach (int i in ArrayWithOutDuplicate)
            {
                Console.WriteLine($"Element {i + 1} : {ArrayOfNumbers[i]}");
            }
            //find the second largest element in an array
            int SecondMax = FindTheSecondMaxArray(ArrayOfNumbers);
            Console.WriteLine(SecondMax);
            //find the index of the minimum element in an array
            int MinIndex = MinElementIndex(ArrayOfNumbers);
            Console.WriteLine(MinIndex);
        }
    }
}
