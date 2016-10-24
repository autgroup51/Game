using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour
{
    
    public GameObject PlayerBulletGo;
    public GameObject bulletPosition01;
    public GameObject bulletPosition02;

    Rigidbody2D rbody;
    Animator anim;
    //Get the Rigibody 2D to enable the play collision
    //Get the play movement animator 
    void Start()
    {
        rbody = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //When "space" is pressed the bullet will shoot
        if (Input.GetKeyDown("space"))
        {
            GameObject bullet01 = (GameObject)Instantiate(PlayerBulletGo);
            bullet01.transform.position = bulletPosition01.transform.position;
            GameObject bullet02= (GameObject)Instantiate(PlayerBulletGo);
            bullet02.transform.position = bulletPosition02.transform.position;
        }
        //detect the player is moving or not if is moving then use walk animation that created.
        Vector2 movement_vector = new Vector2(Input.GetAxisRaw("Horizontal"), Input.GetAxisRaw("Vertical"));
        if (movement_vector != Vector2.zero)
        {
            anim.SetBool("IsWalking", true);
            anim.SetFloat("Input_x", movement_vector.x);
            anim.SetFloat("Input_y", movement_vector.y);
        }
        else
        {
            anim.SetBool("IsWalking", false);
        }
        //Used for calculate the character move speed
        rbody.MovePosition(rbody.position + movement_vector * Time.deltaTime * 2);

    }
}

