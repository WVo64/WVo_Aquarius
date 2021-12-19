using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AimShoot : MonoBehaviour
{
    public GameObject playerShot;
    public float fireForce;
    // Start is called before the first frame update
    void Start()
    {
        if(Input.GetMouseButton(0))
        {
            Debug.Log("Pressed Left Click to Shoot");
            GameObject shotInstance = Instantiate(playerShot, transform.position, Quaternion.identity);
            shotInstance.GetComponent<Rigidbody>().AddForce(transform.forward * fireForce);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
