using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using TMPro;
using JetBrains.Annotations;

public class BarTender : MonoBehaviour
{
    public int clickCounter;
    public int whichPlayer;
    public SpriteRenderer[] spriteRenderers;
    public SpriteRenderer[] spriteRenderersBetween;
    public float[] rPlayers;
    public float[] gPlayers;
    public float[] bPlayers;
    public GameObject itemDesObj;
    public bool isMouseIn;
    public GameObject[] whichTurnScreen;
    public Animator glassesAnimator;
    public float showTimer;
    public GameLoop gameloop;
    public float waitTimer;
    public GameObject midObj;
    public int[] elementNamesOne;
    public int[] elementNamesTwo;
    private void Start()
    {
        whichPlayer = 0;
        showTimer = 3.0f;
        waitTimer = 3.0f;
        whichPlayer = 3;
        itemDesObj.SetActive(false);
        midObj.SetActive(false);
    }

    private void Update()
    {
        spriteRenderersBetween[0].color = new Color(rPlayers[0], gPlayers[0], bPlayers[0], 1);
        spriteRenderersBetween[1].color = new Color(rPlayers[1], gPlayers[1], bPlayers[1], 1);
        if (clickCounter < 6)
        {
            if (whichPlayer == 3)
            {
                waitTimer -= Time.deltaTime;
                if (waitTimer <= 0)
                {
                    if (clickCounter < 3)
                    {
                        whichPlayer = 0;
                        waitTimer = 3.0f;
                    }
                    if (clickCounter >= 3)
                    {
                        whichPlayer = 1;
                    }
                }
            }
            if (whichPlayer == 0 || whichPlayer == 1)
            {
                Camera camera = Camera.main;
                Vector3 mouseWorldPosition = camera.ScreenToWorldPoint(Input.mousePosition);
                mouseWorldPosition.z = 0f;
                itemDesObj.transform.position = mouseWorldPosition;
                spriteRenderers[0].color = new Color(rPlayers[0], gPlayers[0], bPlayers[0], 1);
                spriteRenderers[1].color = new Color(rPlayers[1], gPlayers[1], bPlayers[1], 1);
            }
            if (clickCounter >= 3 && clickCounter < 6 && waitTimer == 3.0f)
            {
                whichTurnScreen[1].SetActive(true);
                whichPlayer = 3;
            }
            if (isMouseIn == true)
            {
                itemDesObj.SetActive(true);
            }
            else
            {
                itemDesObj.SetActive(false);
            }
            if (whichPlayer == 3)
            {
                itemDesObj.SetActive(false);
            }
        }
        if (clickCounter >= 6)
        {
            gameloop.whichState = 3;
            midObj.SetActive(true);
            glassesAnimator.Play("MainDrinks");
            itemDesObj.SetActive(false);
            showTimer -= Time.deltaTime;
            if (showTimer <= 0)
            {
                clickCounter++;
                gameloop.whichState = 3;
                midObj.SetActive(false);
            }
        }
    }
}


