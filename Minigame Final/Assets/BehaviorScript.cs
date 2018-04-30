using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class BehaviorScript : MonoBehaviour
{

    private CharacterController controller;

    public float speed = 6.0F;
    public float jumpSpeed = 8.0F;
    public float gravity = 20.0F;
    public Text countText;

    private float lookUpDown;
    private float turnSpeed;

    public int count;

    private Vector3 moveDirection = Vector3.zero;


    // Use this for initialization
    void Start()
    {
        controller = transform.GetComponent<CharacterController>();

        count = 0;
        countText.text = "Player One: " + count.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        if (controller.isGrounded)
        {
            moveDirection = new Vector3(Input.GetAxis("Horizontal"), 0, Input.GetAxis("Vertical"));
            moveDirection = transform.TransformDirection(moveDirection);

            moveDirection *= speed;

            if (Input.GetButton("Jump"))
            {
                moveDirection.y = jumpSpeed;
            }
        }

        moveDirection.y -= gravity * Time.deltaTime;
        controller.Move(moveDirection * Time.deltaTime);

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