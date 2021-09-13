using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Vector3 direction = Vector3.zero;
    public float speed = 10.0f;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
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
        if(transform.position.x > 4.9)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5);
        }
        else if(transform.position.x < -4.9)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5);
        }
        else if(transform.position.y > 3.2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5);
        }
        else if(transform.position.y < -1.2)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, -5);
        }
    }
}