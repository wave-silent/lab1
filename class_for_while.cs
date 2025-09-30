using System;

namespace lab1
{
    public class for1
    {
        public String listNums(int x)
        {
            string result = "";
            for (int i = 0; i <= x; i++)
            {
                result += i + " ";
                
            }
            return result;                             
        }

        public String chet(int x)
        {
            string result = "";
            for (int i = 0; i <= x; i += 2)
            {
                result += i + " ";
            }
            return result;
        }

        public int numLen(long x)
        {
            int total = 0;
            while (x != 0)
            {
                total++;
                x /= 10;
            }
            return total;
        }

        public void square(int x)
        {
            string result = "";
            for (int i = 1; i <= x; i++)
            {
                for (int j = 1; j <= x; j++)
                {
                    result += "*";
                }
                result += "\n";
            }
            Console.WriteLine(result);
        }

        public void rightTriangle(int x)
        {
            // new string - конструктор System
            string result = "";
            for (int i = (x - 1); i >= 0; i--)
            {
                result = new string(' ', i) + new string('*', x - i);
                Console.WriteLine(result);
            }
        }
    }
}
