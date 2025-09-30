using System;


namespace lab1
{
    public class massive
    {
        public int findFirst(int[] arr, int x)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x) return i;               
            }

            return -1;
        }

        public int maxAbs(int[] arr)
        {
            int max_el = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (Math.Abs(arr[i]) > Math.Abs(max_el)) max_el = arr[i];
            }
            return max_el;
        }

        public int[] add(int[] arr, int[] ins, int pos)
        {
            int[] res = new int[arr.Length + ins.Length];
            for (int i = 0; i < pos; i++)
            {
                res[i] = arr[i];
            }

            for (int i = pos; i < (pos + ins.Length); i++)
            {
                res[i] = ins[i - pos];
            }

            for (int i = (pos + ins.Length); i < (arr.Length + ins.Length); i++)
            {
                res[i] = arr[i - ins.Length];
            }

            return res;
        }

        public int[] reverseBack(int[] arr)
        {
            int[] rev_arr = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                rev_arr[i] = arr[arr.Length - 1 - i];
            }
            return rev_arr;
        }

        public int[] findAll(int[] arr, int x)
        {
            int[] arr_x = new int[arr.Length];
            int l = 0;
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    arr_x[i] = i;
                    count++;
                }
            }

            int[] res = new int[count];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr_x[i] > 0)
                {
                    res[l] = i;
                    l++;
                }
            }
            return res;
        }

        public int count_res(int[] arr, int x)
        {
            int[] arr_x = new int[arr.Length];
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == x)
                {
                    arr_x[i] = i;
                    count++;
                }
            }
            return count;
        }
    }
}
