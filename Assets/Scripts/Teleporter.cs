using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    public GameObject nextLevel;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Player")
        {
            collision.transform.position = nextLevel.transform.position;
            collision.gameObject.GetComponent<Player>().startPos = nextLevel.transform.position;
        }
    }
}
