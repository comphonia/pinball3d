using UnityEngine;
using UnityEngine.UI; 

public class PlayButton : MonoBehaviour {

    private void Awake()
    {
        GetComponent<Button>().onClick.AddListener(delegate { OnClick(); });
    }

    void OnClick()
    {
        GameMaster.Play();
        gameObject.SetActive(false); 
    }
}
