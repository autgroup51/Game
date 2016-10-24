using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Pause : MonoBehaviour {
    GameObject PauseMeun;
    bool paused;
    //bool muted;

    [SerializeField]
    //Text mutetext;
	// Use this for initialization
	void Start () {
        paused = false;
       // PauseMeun = GameObject.Find("PauseMenu");
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape))
            paused = !paused;
        if (paused)
        {
           Time.timeScale = 0;
        }
        if (!paused)
        {
            Time.timeScale = 1;
        }

	}
    public void PauseBt()
    {
       
        paused = !paused;
        if (paused)
        {
            //PauseMeun.SetActive(true);
            Time.timeScale = 0;
        }
        if (!paused)
        {
           // PauseMeun.SetActive(false);
            Time.timeScale = 1;
        }
    }
    public void Resume()
    {
        paused = false;

    }
    public void Quit()
    {
        Application.Quit();
    }
            
 
}

