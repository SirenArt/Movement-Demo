using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionLeft : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.tag == "Tile") //On collision tests that the collision is the background
        {
            Vector3 position = other.transform.position; //Gets tile's current pos.

            position.x += 18.7f; //Moves tile right 5 times to its new pos.

            other.transform.position = position; //Assigns the pos.
        }
    }
}
