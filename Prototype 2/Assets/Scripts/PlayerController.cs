using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 20.0f;
    public float hInput;

    public float xRange = 24;
    
    public GameObject projectillePrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        hInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector3.right * hInput * Time.deltaTime * speed);

        if(transform.position.x < -xRange)
        {
        transform.position = new Vector3(-xRange, transform.position.y, transform.position.z);
        }

        if(transform.position.x > xRange)
        {
        transform.position = new Vector3(xRange, transform.position.y, transform.position.z);    
        }

        if(Input.GetKeyDown(KeyCode.Space))
        {
            //Launch the projectille
            Instantiate(projectillePrefab, transform.position, projectillePrefab.transform.rotation);
        }
    }
}
