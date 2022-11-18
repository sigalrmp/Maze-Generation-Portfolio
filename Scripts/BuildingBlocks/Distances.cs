using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

public class Distances : MonoBehaviour
{
    private Cell root;
    private Dictionary<Cell, int> distances;

    public Distances(Cell root)
    {
        this.root = root;
        this.distances = new Dictionary<Cell, int>();
        this.distances.Add(root, 0);
    }

    public int GetDist(Cell cell) => this.distances[cell];

    public void SetDist(Cell cell, int dist)
    {
        try
        {
            this.distances.Add(cell, dist);
        }
        catch (ArgumentException) { }
    }

    public List<Cell> GetCells() //should probably test this.... (sorry Aba)
    {
        List<Cell> keys = new List<Cell>();
        foreach (Cell key in this.distances.Keys)
        {
            keys.Add(key);
        }
        return keys;
    }
}
