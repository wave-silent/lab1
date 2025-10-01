using System;


namespace lab1
{
    public class methods
    {
        public double fraction(double x)
        {
            int int_x;
            int_x = (int) x;
            return x - int_x;
        }

        public int chatToNum(char x)
        {
            int ascii_x = (int)x;
            return ascii_x - 48;
        }

        public bool is2Digits(int x)
        {
            string str_x;
            int len_x;
            // x = Math.Abs(x);     -  если мы берем еще отрицательные числа 
            str_x = Convert.ToString(x);
            len_x = str_x.Length;
            if (len_x == 2) return true;
            else return false;

        }

        public bool isInRange(int a, int b, int num)
        {
            if (a > b)
            {
                if ((num <= a) & (num >= b)) return true;
                else return false;
            }
            else
            {
                if ((num <= b) & (num >= a)) return true;
                else return false;
            }

        }

        public bool isEqual(int a, int b, int c)
        {
            if ((a == b) & (b == c)) return true;
            return false;
        }
    }
}
