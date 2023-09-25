int[][] tstArray = new int[][] {
    Array.Empty<int>() , //0
    new int[]{6},       //1
    new int[]{1,7,8},   //2
    new int[]{2, 1},    //3
    new int[]{2, 1},    //4
    new int[]{3, 1},    //5
    new int[]{0},       //6
    new int[]{5},       //7
    new int[]{1, 3}     //8
};


bool CheckList(int[][] source, out int[] nodes ) {

    HashSet<int> visitedNodes = new();

    bool isChanged;
    do {
        isChanged = false;
        for (int i = 0; i < source.Length; i++)
        {
            if ((source[i].Length == 0 || visitedNodes.Any(e => source[i].Contains(e))) && !visitedNodes.Contains(i))
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