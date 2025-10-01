using System;

namespace lab1
{
    public class if1
    {
        public int abs(int x)
        {
            if (x >= 0) return x;

            else return x * (-1);           
        }

        public bool is35(int x)
        {
            if (((x % 3) == 0) & ((x % 5) == 0)) return false;

            else if (((x % 3) == 0) | ((x % 5) == 0)) return true;

            else return false;
        }

        public int max3(int x, int y, int z)
        {
            if ((x >= y) & (x >= z)) return x;

            else if ((y >= x) & (y >= z)) return y;

            else return z;
        }

        public int sum2(int x, int y)
        {
            int sum;
            sum = x + y;

            if ((sum >= 10) & (sum < 19)) return 20;

            else return sum;
        }

        public String day(int x)
        {
            switch (x)
            {
                case 1:
                    {
                        return "Понедельник";
                        break;
                    }
                case 2:
                    {
                        return "Вторник";
                        break;
                    }
                case 3:
                    {
                        return "Среда";
                        break;
                    }
                case 4:
                    {
                        return "Четверг";
                        break;
                    }
                case 5:
                    {
                        return "Пятница";
                        break;
                    }
                case 6:
                    {
                        return "Суббота";
                        break;
                    }
                case 7:
                    {
                        return "Воскресенье";
                        break;
                    }
                default:
                    return "Это не день недели";
                    break;
            }
        }

    }
}
