using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour
{

    public bool CoroutineStarted = false;
    public GameObject G;

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
            Debug.Log("click");
            if (!CoroutineStarted)
            {
                CoroutineStarted = true;
                StartCoroutine("TriggerActivation");
            }
        }
    }

    IEnumerator TriggerActivation()
    {
        Debug.Log("trigger on");
        //Collider2D c = GetComponent<BoxCollider2D>();
        //c.isTrigger = true;
        G.SetActive(true);
        yield return new WaitForSeconds(1f);
        G.SetActive(false);
        Debug.Log("trigger off");
        //c.isTrigger = false;
    }
}
