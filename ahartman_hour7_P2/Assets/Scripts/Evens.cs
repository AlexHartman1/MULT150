using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Evens : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int number = 0;
        for (int number = 22;number <= 100; number +=2)
        {
            Debug.Log(number);
        }
        // int divider = 2;
        // while (number >= 22)
        // {    
        //     while (number < 100)
        //     {
        //         number++;
        //         if (number % divider == 0)
        //         {
        //             Debug.Log(number);
        //         }   
        //     }         
        // }

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
