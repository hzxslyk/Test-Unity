/****************************************************
    File Name:Grid.cs
    Function:Nothing
*****************************************************/

using System;
using UnityEngine;
using LYKFrameWork;

public class Grid<TObejct>
{
    private TObejct[,] gridArray;

    private int width;//行
    private int height;//列
    private float cellSize;//格子宽度

    public Grid(int width, int height, float cellSize)
    {
        this.width = width;
        this.height = height;
        this.cellSize = cellSize;
        gridArray=new TObejct[width,height];

        for (int x = 0; x < gridArray.GetLength(0); x++)
        {
            for (int y = 0; y < gridArray.GetLength(1); y++)
            {
                Tools.Set3DTextInWorld(GetWorldPosition(x,y)+new Vector3(cellSize,cellSize)*0.5f,20,TextAnchor.MiddleCenter,GetGridValue(x,y).ToString());

                Debug.DrawLine(GetWorldPosition(x,y),GetWorldPosition(x,y+1),Color.white,100);
                Debug.DrawLine(GetWorldPosition(x, y), GetWorldPosition(x+1, y), Color.white, 100);
            }
        }

        Debug.DrawLine(GetWorldPosition(width,0),GetWorldPosition(width,height),Color.white,100);
        Debug.DrawLine(GetWorldPosition(0, height), GetWorldPosition(width, height), Color.white, 100);
    }

    public Vector3 GetWorldPosition(int x, int y)
    {
        return new Vector3(x,y)*cellSize;
    }

    public TObejct GetGridValue(int x, int y)
    {
        return gridArray[x, y];
    }
}
