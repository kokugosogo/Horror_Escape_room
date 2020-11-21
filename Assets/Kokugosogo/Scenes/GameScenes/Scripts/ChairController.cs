using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChairController : MonoBehaviour
{
    //SearchAreaに入っているか
    private bool isNear;
    private Animator animator;

    void Start()
    {
        isNear = false;
        animator = transform.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isNear)
        {
            animator.SetBool("Out", !animator.GetBool("Out"));
            //Debug.Log("F");
            //Debug.Log(animator.GetBool("Out"));
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            isNear = true;
            //Debug.Log("TRUE!");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            isNear = false;
            //Debug.Log("FALSE!");
        }
    }
}