using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class myAnimation : MonoBehaviour
{
    private Animator myAnim;
    bool isRunning=false;
    bool isWalking=false;

    void Start()
    {
        myAnim=GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        isRunning=Input.GetKey(KeyCode.R);
        myAnim.SetBool("Run", isRunning);
        isWalking=Input.GetKey(KeyCode.W);
        myAnim.SetBool("Walk", isWalking);
    }
}
