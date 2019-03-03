using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StraightBumper : MonoBehaviour {

    [SerializeField] LightingFloor[] floorsToTurnOn;

    public void TurnOnFloors()
    {
        foreach (LightingFloor floorToTurnOn in floorsToTurnOn)
        {
            floorToTurnOn.LightUp();
            floorToTurnOn.Invoke("TurnOffTheLight", .15f);
        }
    }
}
