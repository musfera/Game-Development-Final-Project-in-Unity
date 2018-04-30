using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Playertwo : MonoBehaviour
{

    public float speed;
    public float jumpForce;
    public float vertSpeed;
    public float horizSpeed;
    public int count;
    public Text countText;

    public KeyCode left;
    public KeyCode right;
    public KeyCode jump;
    public bool isGrounded;

    private Rigidbody RB;

    // Use this for initialization
    void Start()
    {
        horizSpeed = 6f;
        vertSpeed = 6f;
        jumpForce = 1f;
        RB = GetComponent<Rigidbody>();

        count = 0;
        countText.text = "Player Two: " + count.ToString();
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
    void Update()
    { //a d s w x
        if (isGrounded) {
        if (Input.GetKey("j"))
        {

            RB.velocity = new Vector2(-horizSpeed, 0);
        }
        else if (Input.GetKey("l"))
        {
            RB.velocity = new Vector2(horizSpeed, 0);
        }


        if (Input.GetKey("k"))
        {

            RB.velocity = new Vector3(0, 0, -vertSpeed);
        }

        if (Input.GetKey("i"))
        {

            RB.velocity = new Vector3(0, 0, vertSpeed);
        }

            if (Input.GetKey("x"))
            {

                RB.velocity = new Vector3(0, jumpForce, 0);

                if (Input.GetKey("j"))
                {
                    RB.velocity = new Vector2(-horizSpeed, RB.velocity.y);
                }
                else if (Input.GetKey("l"))
                {
                    RB.velocity = new Vector2(horizSpeed, RB.velocity.y);
                }

                if (Input.GetKey("k"))
                {
                    RB.velocity = new Vector3(-vertSpeed, RB.velocity.z);
                }

                if (Input.GetKey("i"))
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
            countText.text = "Player Two: " + count.ToString();
        }

        if (other.gameObject.CompareTag("YellowOrb"))
        {
            count = count + 100;
            countText.text = "Player Two: " + count.ToString();
        }

        if (other.gameObject.CompareTag("PurpleOrb"))
        {
            count = count + 50;
            countText.text = "Player Two: " + count.ToString();
        }

        if (other.gameObject.CompareTag("DeathOrb"))
        {
            count = count - 200;
            if (count < 0)
            {
                count = 0;
            }
            countText.text = "Player Two: " + count.ToString();
        }

    }
}
    
