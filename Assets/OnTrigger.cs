using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{

    public bool CoroutineStarted = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Enter");
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        Debug.Log("Stay");
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Debug.Log("Exit");   
    }

    private void Update()
    {
        if (Input.GetButton("Fire1"))
        {
            if (!CoroutineStarted)
            {
                Coroutine c = TriggerActivation();
                StartCoroutine("TriggerActivation");
            }
        }
    }

    IEnumerator TriggerActivation()
    {

    }
}
