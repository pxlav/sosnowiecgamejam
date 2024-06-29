using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class BarElement : MonoBehaviour
{
    public int ID;
    public string elementName;
    public string elementDescription;
    public float strenght;
    public float lose;
    public float funnies;
    public float drunk;
    public BarTender barTender;
    public TextMeshPro itemFrame;
    public bool isClicked;
    public GameObject[] clickedUnlicked;
    public MenuBook menubook;

    private void Start()
    {
        isClicked = false;
    }
    private void Update()
    {
        if (isClicked == false)
        {
            clickedUnlicked[0].SetActive(true);
            clickedUnlicked[1].SetActive(false);
        }
        else
        {
            clickedUnlicked[0].SetActive(false);
            clickedUnlicked[1].SetActive(true);
        }
        if (barTender.clickCounter == 3 && barTender.waitTimer <= 0)
        {
            isClicked = false;
        }
    }

    private void OnMouseDown()
    {
        if (barTender.whichPlayer != 3 && isClicked == false && menubook.isOn == false)
        {
            barTender.rPlayers[barTender.whichPlayer] += strenght;
            barTender.gPlayers[barTender.whichPlayer] += lose;
            barTender.bPlayers[barTender.whichPlayer] += drunk;
            Debug.Log(elementName);
            barTender.clickCounter += 1;
            if (elementName != "Piwo" && elementName != "Kawa")
            {
                isClicked = true;
            }
            if (barTender.whichPlayer == 0)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (barTender.elementNamesOne[i] == 0)
                    {
                        barTender.elementNamesOne[i] = ID;
                        break;
                    }
                }
            }
            if (barTender.whichPlayer == 1)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (barTender.elementNamesTwo[i] == 0)
                    {
                        barTender.elementNamesTwo[i] = ID;
                        break;
                    }
                }
            }
        }
    }


    private void OnMouseEnter()
    {
        if (barTender.whichPlayer != 3 && menubook.isOn == false)
        {
            barTender.isMouseIn = true;
            itemFrame.text = elementName + " - " + elementDescription;
        }
    }
    private void OnMouseExit()
    {
        barTender.isMouseIn = false;
    }
}
