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
    private void Start()
    {
        playersScores[0] = 5;
        playersScores[1] = 5;
        endingTimer = 5.0f;
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
            if (endingTimer <= 0)
            {
                PlayerOneWon();
            }
        }
        if (playersScores[1] == 0)
        {
            ending.Play("SecondZoom");
            endingTimer -= Time.deltaTime;
            if (endingTimer <= 0)
            {
                PlayerTwoWon();
            }
        }
    }
    public void PlayerOneWon()
    {
        gameLoop.whichState++;
    }
    public void PlayerTwoWon()
    {
        gameLoop.whichState++;
    }
}
