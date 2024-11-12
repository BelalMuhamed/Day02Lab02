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
            for (int i = 0; i < MaxOfTheArray; i++) 
            {
                Console.WriteLine($"Element {i+1} : {ArrayOfNumbers[i]}");
            }

        }
    }
}
