using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
    Transform player;               // Reference to the player's position.
    Vector3 nav;               // Reference to the nav mesh agent.


    void Awake()
    {
        // Set up the references.
        player = GameObject.FindGameObjectWithTag("Player").transform;
        nav = gameObject.transform.position;
    }


    void Update()
    {
        if (Vector3.Distance(nav, player.position) <= 10f)
        {
            transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(player.position - transform.position), 3.0f * Time.deltaTime);
            //nav += Vector3.forward * 5 * Time.deltaTime;
            //transform.LookAt(player);
            transform.position += transform.forward * 2.5f * Time.deltaTime;
        }
    }
}
