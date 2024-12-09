using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarsCollected
{
    public static List<List<bool>> starCollection = new List<List<bool>>();
    public static int levelAmount = 3;

    public static void createStarCollection()
    {
        starCollection.Add(new List<bool>() { false });

        for (int i = 0; i < levelAmount; i++)
        {
            starCollection.Add(new List<bool> { false, false, false });
        }
    }

    public static void newStar(int level, int starNumber)
    {
        starCollection[level][starNumber] = true;
    }
}
