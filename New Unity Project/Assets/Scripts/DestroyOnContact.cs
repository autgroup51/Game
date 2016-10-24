using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    public GameManager gameManager;
    public int Score = 10;
    //Find game manager and reference game manager
	void  Awake()
    {
        GameObject gameManagerObject = GameObject.FindWithTag("GameManager");
        if (gameManagerObject != null)
        {
            gameManager = gameManagerObject.GetComponent<GameManager>();
        }
        if (gameManager == null)
        {
            Debug.Log("Cannot find 'GameManager' script");
        }
    }

    //when other touchs this object and is of tag trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        string tag = other.gameObject.name;
        if(tag == "Player")
        {
            other.gameObject.SetActive(false);
            gameManager.updateScore(Score - 10);
        }

        if(tag == "PlayerBulletGo(Clone)")
        {
            
            gameObject.SetActive(false);
            gameManager.updateScore(Score);

        }

    }
}
