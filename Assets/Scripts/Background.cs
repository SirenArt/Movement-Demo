using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Background : MonoBehaviour
{

public void Place(int _a, int _b) //Script for placing tiles of set size in a predecided grid
{
    //Define values
    int a = _a;
    int b = _b;
    Vector3 pos = Vector3.zero;

    //Translate values into game positions
    pos.x = a * 3.74f;
    pos.y = b * 3.333f;

    //Assign position
    transform.position = pos;        
}
}
