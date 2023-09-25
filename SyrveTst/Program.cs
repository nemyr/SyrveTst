int[][] tstArray = new int[][] {
    Array.Empty<int>(), //0
    new int[]{0},       //1
    new int[]{0, 4},    //2
    new int[]{},        //3
    new int[]{3},       //4
    new int[]{3},       //5
    new int[]{3},       //6
  //  new int[]{5},       //7
   // new int[]{1, 3}     //8
};


bool CheckList(int[][] source, out int[] nodes ) {

    List<int> visitedNodes = new();

    bool isChanged;
    do {
        isChanged = false;
        for (int i = 0; i < source.Length; i++)
        {
            if ((source[i].Length == 0 || source[i].All(visitedNodes.Contains)) && !visitedNodes.Contains(i))
            {
                visitedNodes.Add(i);
                isChanged = true;
            }
        };
    } while (isChanged && visitedNodes.Count <= source.Length);

    nodes = visitedNodes.ToArray();
    return nodes.Length == source.Length;
}


if (CheckList(tstArray, out int[] nodes)) {
    Console.WriteLine("Success");
    Console.WriteLine(string.Join(", ", nodes));
} else
    Console.WriteLine("Fail");