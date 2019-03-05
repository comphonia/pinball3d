using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    HingeJoint hinge;

    [SerializeField] float restPosition = 0f;
    [SerializeField] float pressedPosition = 45f;
    [SerializeField] float hitStrenght = 10000f;
    [SerializeField] float flipperDamper = 150f;

    [Space]

    [SerializeField] string inputName;

    private void Start()
    {
        hinge = GetComponent<HingeJoint>();
        hinge.useSpring = true; 
    }

    private void Update()
    {
        JointSpring spring = new JointSpring();
        spring.spring = hitStrenght;
        spring.damper = flipperDamper;

        if (Input.GetButton(inputName)) spring.targetPosition = pressedPosition;
        else spring.targetPosition = restPosition;
        hinge.spring = spring;
        hinge.useLimits = true; 
    }
}
