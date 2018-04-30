using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {

    public Text timerText;

    private float timeLeft = 61.0f;
    private int time;

    // Use this for initialization
    void Start () {
        time = 61;
        timerText.text = time.ToString();
    }
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        time = (int)timeLeft;
        if (time < 0)
        {
            time = 0;
        }
        if (time == 0)
        {
            GameObject playerOne = GameObject.Find("PlayerOne");
            int playerOneScore = playerOne.GetComponent<Playerone>().count;

            GameObject playerTwo = GameObject.Find("PlayerTwo");
            int playerTwoScore = playerTwo.GetComponent<Playertwo>().count;

            GameObject playerThree = GameObject.Find("PlayerThree");
            int playerThreeScore = playerThree.GetComponent<Playerthree>().count;

            GameObject playerFour = GameObject.Find("PlayerFour");
            int playerFourScore = playerFour.GetComponent<Playerfour>().count;

            if (playerOneScore > playerTwoScore && playerOneScore > playerThreeScore && playerOneScore > playerFourScore)
            {
                SceneManager.LoadScene("Player One Win Screen");
            }

            if (playerTwoScore > playerOneScore && playerTwoScore > playerThreeScore && playerTwoScore > playerFourScore)
            {
                SceneManager.LoadScene("Player Two Win Screen");
            }

            if (playerThreeScore > playerOneScore && playerThreeScore > playerTwoScore && playerThreeScore > playerFourScore)
            {
                SceneManager.LoadScene("Player Three Win Screen");
            }

            if (playerFourScore > playerOneScore && playerFourScore > playerTwoScore && playerFourScore > playerThreeScore)
            {
                SceneManager.LoadScene("Player Four Win Screen");
            }
        }
        timerText.text = time.ToString();
	}
}
