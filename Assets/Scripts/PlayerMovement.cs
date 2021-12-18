using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rbPlayer;
    private Vector3 direction = Vector3.zero;
    private float speed = 25.0f;
    private Quaternion aimLook;
    private Animator anim;

    // Start is called before the first frame update
    void Start()
    {
        rbPlayer = GetComponent<Rigidbody>();
        rbPlayer.drag = 3;
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float horMove = Input.GetAxis("Horizontal");
        float verMove = Input.GetAxis("Vertical");

        direction = new Vector3(-horMove, 0, verMove); //- horMove or else inverted controls w/ game perspective

        if(Input.GetMouseButton(0))
        {
            Debug.Log("Pressed left click");
            //GameObject SHOT MADE HERE
            anim.SetBool("isShooting", true);
            
        }
        else
        {
            anim.SetBool("isShooting", false);
        }
    }

    void FixedUpdate()
    {
        rbPlayer.AddForce(direction * speed, ForceMode.Force);

        CheckBoundaries();
        
    }

    private void CheckBoundaries()
    {
        //Player Y position = Camera Position + 10.
        if (transform.position.x > 10.2f)
        {
            transform.position = new Vector3(10.2f, transform.position.y, transform.position.z);
        }
        else if (transform.position.x < -10.2f)
        {
            transform.position = new Vector3(-10.2f, transform.position.y, transform.position.z);
        }
        
        if (transform.position.z > 20.0f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 20.0f);
        }
        else if (transform.position.z < 9.5f)
        {
            transform.position = new Vector3(transform.position.x, transform.position.y, 9.5f);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.collider.CompareTag("Hazard"))
        {
            anim.SetBool("Dead", true);
        }
    }
}