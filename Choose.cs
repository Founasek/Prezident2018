using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Choose : MonoBehaviour {

  void Start()
    {
        Time.timeScale = 1;
       
    }


    public void ChooseZeman()
    {
        PlayerPrefs.SetInt("prezident", 0);
        SceneManager.LoadScene(1);
    }

    public void ChooseDrahos()
    {
        PlayerPrefs.SetInt("prezident", 1);
        SceneManager.LoadScene(1);
    }


}
