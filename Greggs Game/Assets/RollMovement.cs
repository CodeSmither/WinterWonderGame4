using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RollMovement : MonoBehaviour
{
    public Rigidbody2D body;
    public float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        Movementright();   
    }
    public void Movementright()
    {

        body.velocity = speed * Vector2.right * 4;


        Invoke("Movementup", 1f);
    }
    public void Movementup()
    {
        body.velocity = speed * Vector2.up * 4;


        Invoke("Movementleft", 1f);
    }
    public void Movementleft()
    {
        body.velocity = speed * Vector2.left * 4;


        Invoke("Movementdown", 1f);
    }
    public void Movementdown()
    {
        body.velocity = speed * Vector2.down * 4;

        Invoke("Movementright", 1f);
    }

}
