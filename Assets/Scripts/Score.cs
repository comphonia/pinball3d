using TMPro;
using UnityEngine;

public class Score : MonoBehaviour {

    static Score instance; 

    static int scoreAmount;
    public static int ScoreAmount
    {
        get
        {
            return scoreAmount; 
        }
        set
        {
            scoreAmount = value;
            UpdateUI(); 
        }
    }

    [SerializeField] TextMeshProUGUI scoreUIText;

    private void Awake()
    {
        if (instance == null) instance = this;
        else this.enabled = false;

        ScoreAmount = 0; 
    }

    public static void IncrementScore()
    {
        ScoreAmount++; 
    }

    static void UpdateUI()
    {
        instance.scoreUIText.text = scoreAmount.ToString(); 
    }


}
