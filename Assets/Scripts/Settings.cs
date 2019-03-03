using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Settings : MonoBehaviour {

    public static Settings instance;

    public Material lightingFloorMaterialWhenOn;

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
    }
}
