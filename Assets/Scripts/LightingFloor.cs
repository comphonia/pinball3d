using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightingFloor : MonoBehaviour {

    MeshRenderer meshRenderer;

    Material materialWhenOff; 

    private void Awake()
    {
        meshRenderer = GetComponent<MeshRenderer>(); 
    }

    public void LightUp()
    {
        Material materialWhenOn = Settings.instance.lightingFloorMaterialWhenOn;
        materialWhenOff = meshRenderer.material; 
        meshRenderer.material = materialWhenOn; 
    }

    public void TurnOffTheLight()
    {
        meshRenderer.material = materialWhenOff; 
    }

}
