using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
    float speed;
    bool start = true;
    GameManager gameManager;
	// set the bullet speed
	void Start () {
        speed = 8f;
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
	
	void Update () {
        // Get the position of the bullet
        Vector2 position = transform.position;
        // update the bullet position when play enter fire key.
        position = new Vector2(position.x, position.y + speed * Time.deltaTime);
        transform.position = position;
        //The bullet can not move over the map.
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        //Destroy the bullet object once it reach the max map boundary
        if (transform.position.y > max.y)
            Destroy(gameObject);
	}

}
