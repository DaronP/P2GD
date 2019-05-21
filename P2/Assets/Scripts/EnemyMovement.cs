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
        transform.LookAt(player);

        if(Vector3.Distance(nav, player.position) >= 0)
        {
            nav += Vector3.forward * 5 * Time.deltaTime;
        }
    }
}
