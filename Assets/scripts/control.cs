using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class control : MonoBehaviour {
    static public int score = 0;
    public Text score_text;
    public GameObject startPage;
	// Use this for initialization
	void Start () {
		
	}

   public void restart()
    {
        Time.timeScale = 1;
        score = 0;
        Application.LoadLevel(Application.loadedLevel);
    }

   public void strt()
   {
       Time.timeScale = 1;
       startPage.SetActive(false);
   }


   public void ext()
    {
        Application.Quit();
    }
	
	// Update is called once per frame
	void Update () {


        score_text.text = "Score : " + score;
	}
}
