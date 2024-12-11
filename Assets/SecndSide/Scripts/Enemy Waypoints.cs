using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWaypoints : MonoBehaviour
{
    public float speed = 5;
    public Transform[] patrolPoints;
    private int patrolIndex = 0;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = new Vector3(patrolPoints[0].position.x, patrolPoints[0].position.y, 0);
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, patrolPoints[patrolIndex].position, speed * Time.deltaTime);
        if (transform.position == patrolPoints[patrolIndex].position)
        {
            patrolIndex++;

            if (patrolIndex >= patrolPoints.Length)
            {
                patrolIndex = 0;
            }
        }
    }
}
