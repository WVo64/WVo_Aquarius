using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float mouseX = Input.mousePosition.x;
        float mouseY = Input.mousePosition.y;

        transform.Translate(mouseX, mouseY, transform.position.z);
        Debug.Log("Mouse X Position: " + mouseX + "\nMouse Y  Position: " + mouseY);
    }
}
