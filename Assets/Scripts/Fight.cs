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
    public Animator pigeonOneAnimator;
    public Animator pigeonTwoAnimator;
    private void Start()
    {
        playersScores[0] = 80;
        playersScores[1] = 80;
        endingTimer = 5.0f;
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
            }
            if (Input.GetKeyDown(KeyCode.UpArrow) && playersScores[1] > 0)
            {
                playersScores[1] -= 1;
            }
        }
        if (playersScores[0] == 0)
        {
            endingTimer -= Time.deltaTime;
            ending.Play("FirstZoom");
            pigeonTwoAnimator.Play("Picie");
            pigeonOneAnimator.Play("szerokipicie");
            if (endingTimer <= 0)
            {
                PlayerOneWon();
            }
        }
        if (playersScores[1] == 0)
        {
            ending.Play("SecondZoom");
            pigeonOneAnimator.Play("szerokipicie");
            pigeonTwoAnimator.Play("Picie");
            endingTimer -= Time.deltaTime;
            if (endingTimer <= 0)
            {
                PlayerTwoWon();
            }
        }
    }
    public void PlayerOneWon()
    {
        if (combinations.isRandomOne == false)
        {
            gameLoop.whichState++;
            wichOneWin = 0;
        }
        else
        {
            randomWaitTimer -= Time.deltaTime;
            if (combinations.isGoodOrBadOne == 0)
            {
                pigeonOneAnimator.Play("Rzyg");
                if (randomWaitTimer <= 0)
                {
                    Application.LoadLevel(0);
                }
            }
            if (combinations.isGoodOrBadOne == 1)
            {
                pigeonOneAnimator.Play("Idle");
                if (randomWaitTimer <= 0)
                {
                    Application.LoadLevel(0);
                }
            }
        }
    }
    public void PlayerTwoWon()
    {
        if (combinations.isRandomTwo == false)
        {
            gameLoop.whichState++;
            wichOneWin = 1;
        }else
        {
            randomWaitTimer -= Time.deltaTime;
            if (combinations.isGoodOrBadOne == 0)
            {
                pigeonTwoAnimator.Play("SzerokiRzyg");
                if (randomWaitTimer <= 0)
                {
                    Application.LoadLevel(0);
                }
            }
            if (combinations.isGoodOrBadOne == 1)
            {
                pigeonTwoAnimator.Play("Idle");
                if (randomWaitTimer <= 0)
                {
                    Application.LoadLevel(0);
                }
            }
        }
    }
}
