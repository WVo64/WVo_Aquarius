using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float minSpeed = 3.0f;
    public float maxSpeed = 12.0f;

    private float speed;

    public enum DriftDirection //Taken from RiverHop
    {
        Left = -1,
        Right = 1,
        Up = 2,
        Down = -2
    }
    public DriftDirection driftDirection = DriftDirection.Left;

    // Update is called once per frame
    void Update()
    {
        speed = Random.Range(minSpeed, maxSpeed);
        switch (driftDirection)
        {
            case DriftDirection.Left:
                transform.Translate(Vector3.left * Time.deltaTime * speed);
                break;
            case DriftDirection.Right:
                transform.Translate(Vector3.right * Time.deltaTime * speed);
                break;
            case DriftDirection.Up:
                transform.Translate(Vector3.up * Time.deltaTime * speed);
                break;
            case DriftDirection.Down:
                transform.Translate(Vector3.down * Time.deltaTime * speed);
                break;
        }

        if (transform.position.x > 90f || transform.position.x < -90f || transform.position.y > 40f || transform.position.y < -15f)
        {
            Destroy(gameObject);
        }
    }

    /* Start is called before the first frame update
    void Start()
    {

    }*/
}
