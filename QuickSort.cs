using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Transactions;

namespace Yousource.Strategy.App
{
    public class QuickSort : ISortStrategy
    {
        public string Sort(string input)
        {
            if (input.Length <= 1)
                return input;

            char pivot = input[input.Length / 2];

            string left = "";
            string right = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] < pivot)
                    left += input[i];
                else if (input[i] > pivot)
                    right += input[i];
            }

            return Sort(left) + pivot + Sort(right);
        }
    }
}
