using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HitScore : MonoBehaviour {

    public Text ScoreZ;
    public int _ScoreZ;

    public Text ScoreD;
    public int _ScoreD;

    public Text ScoreR;
    
    // Use this for initialization
    void Start () {

        
        if (PlayerPrefs.GetInt("prezident", 0) == 0)
        {
            _ScoreD = 0 + 50;
            SetscoreZ();
            SetscoreD();

        }
        if (PlayerPrefs.GetInt("prezident", 0) == 1)
        {
            _ScoreZ = 0 + 50;
            SetscoreZ();
            SetscoreD();
        }


        
    }
	

    // Zeman

	public void ScoreZtoAdd()
    {
        _ScoreZ = _ScoreZ + 1;
        SetscoreZ();
    }
    

    public void SetscoreZ()
    {
        ScoreZ.text = "Počet hlasů: " + _ScoreZ.ToString();
    }


    // Drahoš

    public void ScoreDtoAdd()
    {
        _ScoreD = _ScoreD + 1;
        SetscoreD();
    }


    public void SetscoreD()
    {
        ScoreD.text = "Počet hlasů: " + _ScoreD.ToString();
    }

   
    
}
