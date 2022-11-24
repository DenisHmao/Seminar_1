int[] dataArray = new int[] { 0, 1, 2, 3, 4, 5 };

int summResult = 0;
var selectedData = dataArray.Select(
    x =>
    {
        summResult += x;
        return x;
    });

Console.WriteLine(summResult);
