using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float dirX = Input.GetAxis("Mouse X");
        float dirY = Input.GetAxis("Mouse Y");
        transform.Rotate(dirY, -dirX, 0);
        CheckForRayCastHit();
    }
    void CheckForRayCastHit()
    {
        RaycastHit hit;
        if(Physics.Raycast (transform.position, transform.forward, out hit))
        {
            Debug.Log(hit.collider.gameObject.name + " demolished!");
            Destroy(hit.collider.gameObject);
        }
    }
}
