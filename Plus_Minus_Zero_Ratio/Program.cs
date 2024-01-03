class Result
{
    public static void PlusMinus(List<int> arr)
    {
        int length = arr.Count;
        var positiveCount = 0;
        var negativeCount = 0;
        var zeroCount = 0;
        for (int i = 0; i < length; i++)
        {
            if (arr[i] > 0)
                positiveCount++;
            else if (arr[i] < 0)
                negativeCount++;
            else
                zeroCount++;
        }

        Console.WriteLine(Math.Round((double)positiveCount / length, 6));
        Console.WriteLine(Math.Round((double)negativeCount / length, 6));
        Console.WriteLine(Math.Round((double)zeroCount / length, 6));
    }

}

class Solution
{
    public static void Main(string[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine().Trim());

        List<int> arr = Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList();

        Result.PlusMinus(arr);
    }
}
