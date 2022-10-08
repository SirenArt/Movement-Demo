using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    Vector3 velocity = Vector3.zero;
    bool up = false;
    bool down = false;
    bool left = false;
    bool right = false;
    void Update() //Takes input on game update and carries over to the fixed update
    {
        //WASD movement
        if(Input.GetKey("w"))
        {
            up = true;
        }    

        if(Input.GetKey("s"))
        {
            down = true;
        }

        if(Input.GetKey("a"))
        {
            left = true;
        }

        if(Input.GetKey("d"))
        {
            right = true;
        } 

        //esc to exit
        if(Input.GetKey("escape"))
        {
            Application.Quit();
        }      
    }

    private void FixedUpdate()
    {
        MovePlayer(); //Activates player movement on fixed update rate, allows movement to be called elsewhere  
    }

    private void MovePlayer()
    {
        if(!(up && down)) //tests for conflicting movements
        {
            if(up)
            {
                velocity.y = 5; //sets positive y movement for up
                up = false; //resets
            }
            else if(down)
            {
                velocity.y = -5; // see above
                down = false; 
            }
            else
            {
                velocity.y = 0; //if no vert movement, resets
            }
            
        }
        else
        {
            velocity.y = 0; //if conflict, resets
            up = false;
            down = false;
        }

        if(!(left && right)) // see above
        {
            if(right)
            {
                velocity.x = 5;
                right = false;
            }
            else if(left)
            {
                velocity.x = -5;
                left = false;
            }    
            else
            {
                velocity.x = 0;
            }
            
        }
        else
        {
            velocity.x = 0;
            left = false;
            right = false;
        }
        transform.position += velocity * Time.fixedDeltaTime; //assigns "velocity" with respect to time to the pos. of the player
    }
}
