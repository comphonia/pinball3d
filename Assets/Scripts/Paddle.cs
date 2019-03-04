using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour {

    Animator animator;
    [SerializeField] string buttonToPressName; 

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }

    private void Update()
    {
        animator.SetBool("Up", Input.GetButton(buttonToPressName));
    }

}
