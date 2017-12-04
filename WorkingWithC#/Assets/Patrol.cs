using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Patrol : MonoBehaviour {

    public List<Vector3> patrolPoints;
    public float speed;
    public float acceleration;

    private int i;
    private Vector3 currentTarget;
    private Vector3 heading;
    private float distance;

	// Use this for initialization
	void Start () {
        i = 1;
        transform.position = patrolPoints[0];
        currentTarget = patrolPoints[1];
        distance = Vector3.Distance(patrolPoints[0], patrolPoints[1]);
	}
	
	// Update is called once per frame
    void Update () {
        distance = Vector3.Distance(transform.position, currentTarget);
        Debug.Log(distance);

        // when we reach the next target
        if (distance < 0.1)
        {
            // if we are at the end of the list of points, reset to beginning, otherwise increment i
            if (i == patrolPoints.Count - 1)
                i = 0;
            else
                i++;

            // set the target point
            currentTarget = patrolPoints[i];
        }

        heading = Vector3.Normalize(currentTarget - transform.position);
        transform.Translate(heading * speed * Time.deltaTime);
	}
}
