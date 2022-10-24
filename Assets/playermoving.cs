using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playermoving : MonoBehaviour
{

    public float speed;
    // Start is called before the first frame update

    void Start()
    {

    }

    // Update is called once per frame
    void FixedUpdate()
    {
    
       Vector3 currentPos = transform.position;


        if (Input.GetKey("a") && currentPos.x > -14.10) 
        {
            currentPos.x -= speed;
        }

        if (Input.GetKey("d") && currentPos.x < 14.4)
        {
            currentPos.x += speed;
        }

        if (Input.GetKey("s") && currentPos.y > -3.59)
        {
            currentPos.y -= speed;
        }

        if (Input.GetKey("w") && currentPos.y < 2.4)
        {
            currentPos.y += speed;
        }


        transform.position = currentPos;

    }
}
