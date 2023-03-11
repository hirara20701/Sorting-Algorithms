namespace Yousource.Strategy.App
{
    public class BubbleSort : ISortStrategy
    {
        public string Sort(string input)
        {
            var result = "";
            var arr = input.ToCharArray();
            char temp;

            for (int write = 0; write < arr.Length; write++)
            {
                for (int sort = 0; sort < arr.Length - 1; sort++)
                {
                    if (arr[sort] > arr[sort + 1])
                    {
                        temp = arr[sort + 1];
                        arr[sort + 1] = arr[sort];
                        arr[sort] = temp;
                    }
                }
            }

            for (int i = 0; i < arr.Length; i++)
                result += arr[i];

            return result;
        }
    }
}
