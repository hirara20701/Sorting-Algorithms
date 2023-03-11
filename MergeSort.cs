using System;
using System.Collections.Generic;
using System.Text;

namespace Yousource.Strategy.App
{
    public class MergeSort : ISortStrategy
    {
        public string Sort(string input)
        {
            if (input.Length <= 1)
            {
                return input;
            }

            int mid = input.Length / 2;
            string left = input.Substring(0, mid);
            string right = input.Substring(mid);

            left = Sort(left);
            right = Sort(right);

            return Merge(left, right);
        }

        private string Merge(string left, string right)
        {
            string result = "";

            int i = 0, j = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result += left[i];
                    i++;
                }
                else
                {
                    result += right[j];
                    j++;
                }
            }

            while (i < left.Length)
            {
                result += left[i];
                i++;
            }

            while (j < right.Length)
            {
                result += right[j];
                j++;
            }

            return result;
        }
    }
}
