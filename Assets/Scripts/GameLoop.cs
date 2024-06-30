using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameLoop : MonoBehaviour
{
    public int whichState;
    public GameObject[] gameScreens;
    public GameObject[] gameplayStates;
    public BarTender bartender;
    public GameObject menuMusic;

    private void Start()
    {
        whichState = 0;
        bartender.whichTurnScreen[0].SetActive(true);
    }
    private void Update()
    {
        if(whichState == 0)
        {
            gameScreens[0].SetActive(true);
            gameScreens[1].SetActive(false);
            gameScreens[2].SetActive(false);
            gameScreens[3].SetActive(false);
            gameplayStates[0].SetActive(false);
            gameplayStates[1].SetActive(false);
            menuMusic.SetActive(true);
        }
        if (whichState == 1)
        {
            gameScreens[0].SetActive(false);
            gameScreens[1].SetActive(true);
            gameScreens[2].SetActive(false);
            gameScreens[3].SetActive(false);
            gameplayStates[0].SetActive(false);
            gameplayStates[1].SetActive(false);
            menuMusic.SetActive(true);
        }
        if (whichState == 2)
        {
            gameScreens[0].SetActive(false);
            gameScreens[1].SetActive(false);
            gameScreens[2].SetActive(true);
            gameScreens[3].SetActive(false);
            gameplayStates[0].SetActive(true);
            gameplayStates[1].SetActive(false);
            menuMusic.SetActive(false);
        }
        if (whichState == 3)
        {
            gameScreens[0].SetActive(false);
            gameScreens[1].SetActive(false);
            gameScreens[2].SetActive(true);
            gameScreens[3].SetActive(false);
            gameplayStates[0].SetActive(false);
            gameplayStates[1].SetActive(true);
            menuMusic.SetActive(false);
        }
        if (whichState == 4)
        {
            gameScreens[0].SetActive(false);
            gameScreens[1].SetActive(false);
            gameScreens[2].SetActive(false);
            gameScreens[3].SetActive(true);
            gameplayStates[0].SetActive(false);
            gameplayStates[1].SetActive(false);
            menuMusic.SetActive(false);
        }
    }
    public void PlayButton()
    {
        whichState++;
    }
    public void ExitButton()
    {
        Application.Quit();
    }
}
