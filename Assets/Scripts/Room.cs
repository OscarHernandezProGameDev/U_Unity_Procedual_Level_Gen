using System.Collections.Generic;
using UnityEngine;

public class Room
{
    RectInt area;
    public RectInt Area { get { return area; } }

    public Room(RectInt area)
    {
        this.area = area;
    }

    public List<Hallway> CalculateAllPossibleDoorways(int width, int length, int minDistanceFromEdge)
    {
        List<Hallway> hallwayCandidates = new List<Hallway>();

        //hallwayCandidates.Add(new Hallway(new Vector2Int(0, 0)));
        //hallwayCandidates.Add(new Hallway(new Vector2Int(width, length)));

        int top = length - 1;
        int minX = minDistanceFromEdge;
        int maxX = width - minDistanceFromEdge;
        for (int x = minX; x < maxX; x++)
        {
            hallwayCandidates.Add(new Hallway(new Vector2Int(x, 0)));
            hallwayCandidates.Add(new Hallway(new Vector2Int(x, top)));
        }

        int right = width - 1;
        int minY = minDistanceFromEdge;
        int maxY = length - minDistanceFromEdge;
        for (int y = minY; y < maxY; y++)
        {
            hallwayCandidates.Add(new Hallway(new Vector2Int(0, y)));
            hallwayCandidates.Add(new Hallway(new Vector2Int(right, y)));
        }

        return hallwayCandidates;
    }
}