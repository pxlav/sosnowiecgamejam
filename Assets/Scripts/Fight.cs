using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fight : MonoBehaviour
{
    public int[] playersScores;
    public GameLoop loop;
    public GameObject[] drinks;
    public GameLoop gameLoop;
    public float endingTimer;
    public Animator ending;
    public int wichOneWin;
    public DrinkCombinations combinations;
    public float randomWaitTimer;
    public bool isPlayerOneWon;
    public bool isPlayerTwoWon;
    public AudioSource gulpSound;
    public AudioSource vomit;
    public AudioSource vomit2;
    public AudioSource swierszcz;
    public AudioSource swierszcz2;
    public AudioSource tudum;
    private void Start()
    {
        endingTimer = 2.0f;
        playersScores[0] = 80;
        playersScores[1] = 80;
        randomWaitTimer = 2f;
    }

    private void Update()
    {
        drinks[0].transform.localScale = new Vector3(2.35f, 0.1f * playersScores[0], 18);
        drinks[1].transform.localScale = new Vector3(2.35f, 0.1f * playersScores[1], 18);
        if (loop.whichState == 3)
        {
            if (Input.GetKeyDown(KeyCode.W) && playersScores[0] > 0)
            {
                playersScores[0] -= 1;
                gulpSound.Play();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && playersScores[1] > 0)
            {
                playersScores[1] -= 1;
                gulpSound.Play();
            }
        }
        if (playersScores[0] == 0)
        {
            endingTimer -= Time.deltaTime;
            ending.Play("FirstZoom");
            if (endingTimer <= 0)
            {
                isPlayerOneWon = true;
            }
        }
        if (playersScores[1] == 0)
        {
            ending.Play("SecondZoom");
            endingTimer -= Time.deltaTime;
            if (endingTimer <= 0)
            {
                isPlayerTwoWon = true;
            }
        }
        if (isPlayerOneWon == true)
        {
            if (combinations.isRandomOne == false)
            {
                gameLoop.whichState++;
                wichOneWin = 0;
                tudum.Play();
            }
            else
            {
                randomWaitTimer -= Time.deltaTime;
                if (combinations.isGoodOrBadOne == 0)
                {
                    vomit.mute = false;
                    if (randomWaitTimer <= 0)
                    {
                        Application.LoadLevel(0);
                    }
                }
                if (combinations.isGoodOrBadOne == 1)
                {
                    swierszcz.mute = false; ;
                    if (randomWaitTimer <= 0)
                    {
                        Application.LoadLevel(0);
                    }
                }
            }
        }
        if (isPlayerTwoWon == true)
        {
            if (combinations.isRandomTwo == false)
            {
                gameLoop.whichState++;
                wichOneWin = 1;
                tudum.Play();
            }
            else
            {
                randomWaitTimer -= Time.deltaTime;
                if (combinations.isGoodOrBadOne == 1)
                {
                    vomit2.mute = false;
                    Debug.Log("VOMIT");
                    if (randomWaitTimer <= 0)
                    {
                        Application.LoadLevel(0);
                    }
                }
                if (combinations.isGoodOrBadOne == 0)
                {
                    swierszcz2.mute = false;
                    Debug.Log("SWIERSZCZ");
                    if (randomWaitTimer <= 0)
                    {
                        Application.LoadLevel(0);
                    }
                }
            }
        }
    }
}
