using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    //SearchAreaに入っているか
    private bool isNear;
    private Animator animator;

    void Start()
    {
        isNear = false;
        animator = transform.parent.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && isNear)
        {
            animator.SetBool("Open", !animator.GetBool("Open"));
            Debug.Log("F");
            Debug.Log(animator.GetBool("Open"));
        }
    }

    void OnTriggerEnter(Collider collider)
    {
        if (collider.tag == "Player")
        {
            isNear = true;
            Debug.Log("TRUE!");
        }
    }

    void OnTriggerExit(Collider collider)
    {
        if (collider.tag == "Player")
        {
            isNear = false;
            Debug.Log("FALSE!");
        }
    }
}
