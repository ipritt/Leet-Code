
foreach(bool result in GetResults([[1, 1], [1, 5], [1, 13], [1, 14], [2, 12, 8]])) 

{
    Console.WriteLine(result);
}

IList<bool> GetResults(int[][] queries)
{
    List<int> blocks = [];
    List<bool> results = [];

    for (int i = 0; i < queries.Length; i++)
    {
        // Process query type 1 for placing a block
        if (queries[i][0] == 1)
        {
            blocks.Add(queries[i][1]);
        }

        //  Process query type 2 for checking if a block can be placed
        if (queries[i][0] == 2)
        {
            bool doesBlockFit = false;

            //  Block is too big to fit provided position, even wthout other blocks in the way
            if (queries[i][2] > queries[i][1])
            {
                results.Add(doesBlockFit);
                continue;
            }

            //  There are no blocks in the way, so the block can fit
            if (blocks.Count == 0)
            {
                doesBlockFit = true;
                results.Add(doesBlockFit);
                continue;
            }

            blocks.Sort();
            for (int j = 0; j < blocks.Count; j++)
            {
                if (j == 0)
                {
                    if (blocks[j] >= queries[i][2] || queries[i][1] - blocks.Max() >= queries[i][2])
                    {
                        doesBlockFit = true;
                        break;
                    }
                }
                else if (blocks[j] > queries[i][1] && Math.Abs(queries[i][1] - blocks[j]) >= queries[i][2])
                {
                    doesBlockFit = true;
                    break;
                }
                else if (blocks[j] <= queries[i][1] && blocks[j] - blocks[j - 1] >= queries[i][2])
                {
                    doesBlockFit = true;
                    break;
                }
                else if (blocks[j] - blocks[j - 1] >= queries[i][2])
                {
                    doesBlockFit = true;
                    break;
                }
            }

            results.Add(doesBlockFit);
        }
    }
    return results;
}
