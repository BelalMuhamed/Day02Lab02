namespace BonusPart02
{
    public class Program
    {
        public static long GetCountOfOnes()
        {
            long counter =0;
            for (long i = 1; i <= 99999999;i++)
            {
                long n = i;
                while(n>0)
                {
                    int digit =(int)( n % 10);
                    
                    if(digit ==1)
                    {
                        counter++;
                    }
                    n /= 10;
                }
            }
            return counter;
        }
        static void Main(string[] args)
        {
            long numberof1s = GetCountOfOnes();
            Console.WriteLine(numberof1s);
            String s = "99999999";
            Console.WriteLine(s.Length * Math.Pow(10, s.Length - 1));

        }
    }
}
