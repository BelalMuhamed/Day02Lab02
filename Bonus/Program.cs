namespace Bonus
{
    public class Program
    {
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
        static void Main(string[] args)
        {
            int[] ArrayOfNumbers = CreateArray();
            int MaxOfTheArray = GetMaxNumberOfTheArray(ArrayOfNumbers);
            Console.WriteLine($"MAx Number in this array is : {MaxOfTheArray}");


        }
    }
}
