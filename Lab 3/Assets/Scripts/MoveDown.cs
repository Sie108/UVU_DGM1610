using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveDown : MonoBehaviour
{
    //This is what makes the enemies move at a certain speed
    public float speed = 5.0f;

    private float zDestroy = -32.0f;
    private Rigidbody objectRb;

    // Causes the enemies to collide with player
    void Start()
    {
        objectRb = GetComponent<Rigidbody>();
    }

    // Makes the enemies go down automatically and destroys them offscreen
    void Update()
    {
        objectRb.AddForce(Vector3.forward * -speed);

        if(transform.position.z < zDestroy)
        {
            Destroy(gameObject);
        }
    }
}
