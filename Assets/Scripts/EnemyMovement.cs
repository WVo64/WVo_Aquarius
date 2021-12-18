using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public List<GameObject> waypoints;
    private NavMeshAgent agent;

    private const float WP_THRESHOLD = 10.0f;

    private GameObject currentWP;
    private int currentWPIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        currentWP = GetNextWayPoint();
        agent.SetDestination(currentWP.transform.position);
    }

    // GetNextWayPoint now picks a random Index between 0 and the waypoint count.
    GameObject GetNextWayPoint()
    {
        currentWPIndex = Random.Range(0, waypoints.Count);
        //Debug.Log("Waypoint index: " + currentWPIndex);
        return waypoints[currentWPIndex];
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, currentWP.transform.position) < WP_THRESHOLD)
        {
            //Debug.Log("Changing Waypoint");
            currentWP = GetNextWayPoint();
            agent.SetDestination(currentWP.transform.position);
        }
    }
}


/* Old Code
 
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

        // Boundary Check
        if (transform.position.x > 90f || transform.position.x < -90f || transform.position.y > 40f || transform.position.y < -15f)
        {
            Destroy(gameObject);
        }*/

/*public enum DriftDirection //Taken from RiverHop
{
    Left = -1,
    Right = 1,
    Up = 2,
    Down = -2
}
public DriftDirection driftDirection = DriftDirection.Left;*/