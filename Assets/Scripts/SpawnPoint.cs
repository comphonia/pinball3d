using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPoint : MonoBehaviour {

    public static SpawnPoint instance;

    [SerializeField] GameObject ballPrefab;

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false; 
    }

    public void SpawnBall ()
    {
        Instantiate(ballPrefab, transform.position, Quaternion.identity); 
    }
}
