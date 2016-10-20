using UnityEngine;
using System.Collections;

public class DestroyOnContact : MonoBehaviour {

    private GameManager gameManager;
    public int score;

    //Find game manager otherwise reference game manager
	void Start ()
    {
        GameObject gameControllerObject = GameObject.FindWithTag("GameManager");
        if (gameControllerObject != null)
        {
            gameManager = gameManager.GetComponent<GameManager>();
        }
        if (gameManager == null)
        {
            Debug.Log("Cannot find 'GameManager' script");
        }
    }

    //when other touchs this object and is of tag trigger
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Weapon")
        {
            gameManager.updateScore(score);
            Destroy(this.gameObject);
        }
        if (other.tag == "Player")
        {
            Destroy(other.gameObject);
        }
    }
}
