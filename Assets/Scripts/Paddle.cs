using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    Animator animator;
    [SerializeField] string buttonToPressName; 

    private void Awake()
    {
        Animator animator = GetComponent<Animator>();
        Debug.Log(animator); 
    }

    private void Update()
    {
        Debug.Log(animator); 
        if(Input.GetButtonDown(buttonToPressName))

        animator.SetBool("Up", true);
    }

}
