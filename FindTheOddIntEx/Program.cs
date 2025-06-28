
internal class Program
{
    private static void Main(string[] args)
    {
        var seq = FindNumWithOddAmount(new[] { 20, 1, -1, 2, -2, 3, 3, 5, 5, 1, 2, 4, 20, 4, -1, -2, 5 });
        Console.WriteLine(seq);
    }
    public static int FindNumWithOddAmount(int[] seq)
    {
        var data = new Dictionary<int, int>();
        foreach (int i in seq) 
        {
            if (data.ContainsKey(i))
            {
                data[i]++;
            }
            else
            {
                data.Add(i, 1);
            }
        }

        foreach((int key, int value) in data)
        {
            if(value % 2 != 0)
            {
                return key;
            }
        }
        return -1; 
    }

    public static int FindNumWithOddAmountLinq(int[] seq) => seq
        .GroupBy(x => x)
        .FirstOrDefault(x => x
        .Count() % 2 != 0)
        .Key;
}