using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BounceArea : MonoBehaviour
{
    [SerializeField] float bumperForce = 1000; 

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ball")) return;

        //Debug.Log("Straight Bumper: Ball in bounce area!");
        //other.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, transform.position, 1);
        Debug.Log(transform.up * bumperForce); 
        other.GetComponent<Rigidbody>().AddForce(transform.up * bumperForce);
        GetComponentInParent<Animation>().Play();
        GetComponentInParent<StraightBumper>().TurnOnFloors(); 
        Score.IncrementScore(); 
    }

}
