using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotionScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float kX = Input.GetAxis("Horizontal") / 10;
        transform.Translate(kX, 0f, 0f);
    }
    void OnTriggerEnter (Collider other)
    {
        Debug.Log("Entering " + other.gameObject.name);
    }
    void OnTriggerStay (Collider other)
    {
        Debug.Log("Staying in " + other.gameObject.name);
    }
    void OnTriggerExit (Collider other)
    {
        Debug.Log("Leaving " + other.gameObject.name);
    }
}
