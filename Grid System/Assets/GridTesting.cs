/****************************************************
    File Name:GridTesting.cs
    Function:Nothing
*****************************************************/

using UnityEngine;

public class GridTesting : MonoBehaviour
{
    void Start()
    {
        Grid<Terrian> gird=new Grid<Terrian>(5,5,10);
    }
}



public class Terrian
{
    private bool canMove;
    private float moveDiff;

    public Terrian(bool canMove, float moveDiff)
    {
        this.canMove = canMove;
        this.moveDiff = moveDiff;
    }


    public override string ToString()
    {
        return canMove.ToString();
    }
}
  
   
   



