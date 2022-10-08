using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundGen : MonoBehaviour
{
public GameObject TileIn;

private void Awake() //At start generates a 5x5 of tiles for the background
{
    for(int a = -2; a < 3; a++)
    {
        for(int b = -2; b < 3; b++)
        {
            GameObject Tile = GameObject.Instantiate(TileIn); //Generates new tile
            Tile.GetComponent<Background>().Place(a,b); //Places in desired grid pos.
        }
    }    
}
}
