
static void BubbleSort(List<int> input)
{
    int end = input.Count - 1;
    while (end != 0)
    {
        bool swapped = false;
        for (int i = 0; i < input.Count-1; i++)
        {
            if (input[i] > input[i+1])
            {
                swapped = true;
                (input[i], input[i+1]) = (input[i+1], input[i]);
            }
        }
        if (!swapped)
        {
            return ;
        }
    }
    return ;
}


List<int> list = new List<int> { 3,4,50,29,492,-43, 85,394,10,0,403,-493,-34};
BubbleSort(list);

Console.WriteLine();
list.ForEach(x => Console.Write(x + ", "));
Console.ReadKey();