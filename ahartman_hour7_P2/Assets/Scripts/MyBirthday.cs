using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyBirthday : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        for(int date = 0; date <= 31; date++)
        {
            
            if(date == 15)
            {
                Debug.Log("Happy Birthday Alex!");
            }
            else
            {
                Debug.Log(date);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
