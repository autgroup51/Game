using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    private GameManager gameManager;
    public int score;
    bool dead = false;

    //Find game manager and reference game manager
	void Start ()
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
        if(tag == "Player 1")
        {
            Destroy(other.gameObject);
        }

        if(tag == "PlayerBulletGo(Clone)")
        {
            //gameManager.updateScore(score);
            Destroy(gameObject);
        }

    }
}
