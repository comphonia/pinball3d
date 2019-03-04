using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverWall : MonoBehaviour {

    private void OnTriggerEnter(Collider other)
    {
        if (!other.CompareTag("Ball")) return;
        GameMaster.GameOver();
        Destroy(other.gameObject); 
    }
}
