using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionBottom : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Tile") //On collision tests that the collision is the background
        {
            Vector3 position = other.transform.position; //Gets tile's current pos.

            position.y += 16.665f; //Moves tile up 5 times to its new pos.

            other.transform.position = position; //Assigns the pos.
        }
    }
}
