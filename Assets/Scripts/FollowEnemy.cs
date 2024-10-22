using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class FollowEnemy : MonoBehaviour
{
    public float speed;
    public GameObject target;

    void Start()
    {
        
    }

    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position,target.transform.position,speed);  
    }
}
