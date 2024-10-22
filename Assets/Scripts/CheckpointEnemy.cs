using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointEnemy : MonoBehaviour
{
    public float speed;
    public List<GameObject> targets;
    int currentTargetId = 0;

    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(transform.position, targets[currentTargetId].transform.position)>0.1f)
        {
            transform.position = Vector3.MoveTowards(transform.position, targets[currentTargetId].transform.position, speed);
        }
        else
        {
            currentTargetId = (currentTargetId+1) % targets.Count;
        }
    }
}
