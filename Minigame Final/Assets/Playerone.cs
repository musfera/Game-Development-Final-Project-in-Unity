using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Playerone : MonoBehaviour {

    public float speed;
    public float jumpForce;
    public float vertSpeed;
    public float horizSpeed;
    public int count;
    public Text countText;

    public KeyCode left;
    public KeyCode right;
    public KeyCode down;
    public KeyCode up;
    public KeyCode jump;
    public KeyCode shift;
    public KeyCode space;
    public bool isGrounded;
    //public KeyCode Horizontal;

    private Rigidbody RB;
    
	// Use this for initialization
	void Start ()
    {
        horizSpeed = 6f;
        vertSpeed = 6f;
        jumpForce = 1f;
        RB = GetComponent<Rigidbody>();

        count = 0;
        countText.text = "Player One: " + count.ToString();
    }

    void OnCollisionStay(Collision collisionInfo)
    {
        isGrounded = true;
    }

    void OnCollisionExit(Collision collisionInfo)
    {
        isGrounded = false;
    }

    // Update is called once per frame
    void Update ()
    {
        /*
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 hmovement = new Vector3(moveHorizontal, 0.0f);
        RB.velocity = hmovement * horizSpeed;

        Vector3 vmovement = new Vector3(moveVertical, 0.0f);
        RB.velocity = vmovement * vertSpeed;
    */

        //transform.Translate(moveSpeed*Input.GetAxis("Horizontal") * Time.deltaTime, 0f, moveSpeed*Input.GetAxis("Vertical")*Time.deltaTime);
        //getkey(key a for player controls 
        if (isGrounded)
        {
            if (Input.GetKey("a"))
            {

                RB.velocity = new Vector2(-horizSpeed, 0);
            }
            else if (Input.GetKey("d"))
            {
                RB.velocity = new Vector2(horizSpeed, 0);
            }


            if (Input.GetKey("s"))
            {

                RB.velocity = new Vector3(0, 0, -vertSpeed);
            }

            if (Input.GetKey("w"))
            {

                RB.velocity = new Vector3(0, 0, vertSpeed);
            }

            if (Input.GetKey("space"))
            {

                RB.velocity = new Vector3(0, jumpForce, 0);

                if (Input.GetKey("a"))
                {
                    RB.velocity = new Vector2(-horizSpeed, RB.velocity.y);
                }
                else if (Input.GetKey("d"))
                {
                    RB.velocity = new Vector2(horizSpeed, RB.velocity.y);
                }

                if (Input.GetKey("s"))
                {
                    RB.velocity = new Vector3(-vertSpeed, RB.velocity.z);
                }

                if (Input.GetKey("w"))
                {
                    RB.velocity = new Vector3(vertSpeed, RB.velocity.z);

                }
            }
        }
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("TealOrb"))
        {
            count = count + 10;
            countText.text = "Player One: " + count.ToString();
        }

        if (other.gameObject.CompareTag("YellowOrb"))
        {
            count = count + 100;
            countText.text = "Player One: " + count.ToString();
        }

        if (other.gameObject.CompareTag("PurpleOrb"))
        {
            count = count + 50;
            countText.text = "Player One: " + count.ToString();
        }

        if (other.gameObject.CompareTag("DeathOrb"))
        {
            count = count - 200;
            if (count < 0)
            {
                count = 0;
            }
            countText.text = "Player One: " + count.ToString();
        }

    }

}
