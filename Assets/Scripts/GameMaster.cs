using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMaster : MonoBehaviour {

    

	public static void Play()
    {
        SpawnPoint.instance.SpawnBall(); 
    }
}
