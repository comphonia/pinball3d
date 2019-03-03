using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MushroomBumper : MonoBehaviour {

    [SerializeField] float bumperForce = 1000;

    [Space]

    [SerializeField] LightingFloor[] floorsToTurnOn; 

    private void OnCollisionEnter(Collision collision)
    {
        if (!collision.collider.CompareTag("Ball")) return;

        Debug.Log("Mushroom Bumper: Ball in bounce area!");
        collision.collider.GetComponent<Rigidbody>().AddExplosionForce(bumperForce, transform.position, 0.2f); 
        GetComponent<Animation>().Play();
        foreach (LightingFloor floorToTurnOn in floorsToTurnOn)
        {
            floorToTurnOn.LightUp();
            floorToTurnOn.Invoke("TurnOffTheLight", .15f);
        }
        Score.IncrementScore(); 
    }
}
