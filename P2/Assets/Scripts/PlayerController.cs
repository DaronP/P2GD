using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Animator animator;
    private bool isAttacking = false;
    private bool isRuning = false;
    public float movementSpeed = 5;

    // Use this for initialization
    void Start()
    {
        animator = GetComponent<Animator>();
    }


    //Update is called once per frame
    void FixedUpdate()
    {
        /*
        if (Input.GetKey(KeyCode.LeftShift) && Input.GetKey("w"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed * 2.5f;
        }*/
        if (Input.GetKey("w") && !Input.GetKey(KeyCode.LeftShift) && !Input.GetKey("s"))
        {
            transform.position += transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
            animator.SetBool("isRunning", true);
        }
        
        else if (Input.GetKey("s") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.forward) * Time.deltaTime * movementSpeed;
            animator.SetBool("isRunning", true);
        }

        if (Input.GetKey("a") && !Input.GetKey("d"))
        {
            transform.position += transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
            animator.SetBool("isRunning", true);
        }
        else if (Input.GetKey("d") && !Input.GetKey("a"))
        {
            transform.position -= transform.TransformDirection(Vector3.left) * Time.deltaTime * movementSpeed;
            animator.SetBool("isRunning", true);
        }
        else if (Input.GetKeyDown("e"))
        {
            animator.SetBool("isAttacking", true);
        }
        else
        {
            animator.SetBool("isRunning", false);
            animator.SetBool("isAttacking", false);
        }
    }
}
