using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ResultGame : MonoBehaviour {

    public Text ResultScore;
    public HitScore thehitscore;

    public GameObject ResultPanel;
    public Image Zeman;
    public Image Drahos;
    public GameObject Draw;
    public Button restart;

    public Slider slider;
    public Text progressionText;
    private float maxValueSlider = 1f;
    public float percentilD;
    public float percentilZ;


    // Use this for initialization
    void Start()
    {
        //restart.enabled = false;
    }

    public void Result()
    {
        ResultPanel.SetActive(true);


       

        if (thehitscore._ScoreZ > thehitscore._ScoreD)
        {
            thehitscore.ScoreR.text = "Prezidentem republiky se stal Miloš Zeman s poměrem hlasů " + thehitscore._ScoreZ.ToString() + " : " + thehitscore._ScoreD;
            Zeman.enabled = true;
            Drahos.enabled = false;
            Draw.SetActive(false);
            restart.enabled = true;

            float allvotesZ = thehitscore._ScoreZ + thehitscore._ScoreD;
             percentilZ = (thehitscore._ScoreZ / allvotesZ);

            slider.value = percentilZ;
            progressionText.text = (percentilZ * 100).ToString("F") + " %" + " hlasů";
            
        }
        else
        {
            thehitscore.ScoreR.text = "Prezidentem republiky se stal Jiří Drahoš s poměrem hlasů " + thehitscore._ScoreD.ToString() + " : " + thehitscore._ScoreZ;
            Drahos.enabled = true;
            Zeman.enabled = false;
            Draw.SetActive(false);
            restart.enabled = true;

            float allvotesD = thehitscore._ScoreZ + thehitscore._ScoreD;
            percentilD = (thehitscore._ScoreD / allvotesD);

           float ChangedirSlider = maxValueSlider - percentilD;

            slider.value =  ChangedirSlider;

            

           progressionText.text = (percentilD * 100).ToString("F") + " %" + " hlasů";
           

        }

        if (thehitscore._ScoreZ == thehitscore._ScoreD)
        {
            thehitscore.ScoreR.text = "Vzhledem ke shodnému počtu hlasů bylo vypsáno další kolo prezidentých voleb";
            Draw.SetActive(true);
            Zeman.enabled = true;
            Drahos.enabled = true;
            restart.enabled = false;

            progressionText.text = (percentilZ + 50).ToString() + " %" + " : " + (percentilD * 100).ToString() + " %";
           
        }

           
    }
    public void RestartGame()
    {
        SceneManager.LoadScene("presidential");
    }
    public void MainMenu()
    {

        SceneManager.LoadScene(0);

    }

}
