using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Vector3 direction = Vector3.zero;
    private float speed = 25.0f;
    private Quaternion aimLook;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        rbPlayer.drag = 3;



    }

    // Update is called once per frame
    void Update()
    {
        float horMove = Input.GetAxis("Horizontal");
        float verMove = Input.GetAxis("Vertical");

        direction = new Vector3(horMove, verMove, 0);
    }

    void FixedUpdate()
    {
        rbPlayer.AddForce(direction * speed, ForceMode.Force);

        CheckBoundaries();
        
    }

    private void CheckBoundaries()
    {
        //Player Z position = Camera Position + 10.
        if (transform.position.x > 10f)
        {
            transform.position = new Vector3(10f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -10f)
        {
            transform.position = new Vector3(-10f, transform.position.y, transform.position.z);
        }
        
        if (transform.position.y > 6.0f)
        {
            transform.position = new Vector3(transform.position.x, 6.0f, transform.position.z);
        }
        else if (transform.position.y < -4.0f)
        {
            transform.position = new Vector3(transform.position.x, -4.0f, transform.position.z);
        }
    }
}
