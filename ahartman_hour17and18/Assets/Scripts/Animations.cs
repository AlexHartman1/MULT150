using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animations : MonoBehaviour
{
    Animator anim;
    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        color();
        scale();
        rotation();
        position();
    }
    void color()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            anim.Play("ColorChange");
        }
    }
    void scale()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            anim.Play("ScaleChange");
        }
    }
    void rotation()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            anim.Play("RotationChange");
        }
    }
    void position()
    {
        if (Input.GetKeyDown(KeyCode.D))
        {
            anim.Play("PositionChange");
        }
    }
}
