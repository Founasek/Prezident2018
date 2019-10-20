using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Loadlevel : MonoBehaviour {

	public void LoadScene(string index)
    {
        SceneManager.LoadScene(index);
    }
}
