using System.Collections;
using UnityEngine;

public class Node
{
    public bool walkable;
    public Vector3 worldPos;
    public int gCost, hCost;
    public int gridX, gridY;
    public Node parent;

    public Node(bool _walkable, Vector3 _worldPos, int _gridX, int _gridY)
    {
        walkable = _walkable;
        worldPos = _worldPos;
        gridX = _gridX;
        gridY = _gridY;
    }

    public int fCost
    {
        get
        {
            return gCost + hCost;
        }
    }
}