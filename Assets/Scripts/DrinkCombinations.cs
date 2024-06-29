using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DrinkCombinations : MonoBehaviour
{
    public string wichDrinkOne;
    public string wichDrinkTwo;
    public BarTender barTender;
    public int drinkValue;
    public int[] ValuesToID;
    public Sprite[] ultImagesOne;
    public Sprite[] ultImagesTwo;
    public Image ultObject;
    public Fight fight;
    public bool isRandomOne;
    public bool isRandomTwo;
    public int isGoodOrBadOne; // 0 bad 1 good
    public int isGoodOrBadTwo; // 0 bad 1 good
    private void Start()
    {
        isRandomTwo = true;
        isRandomOne = true;
        isGoodOrBadOne = Random.Range(0, 2);
        isGoodOrBadTwo = Random.Range(0, 2);
    }

    private void Update()
    {
        if(isRandomOne == true)
        {
            if(isGoodOrBadOne == 1)
            {
                wichDrinkOne = "Neutral";
            }
            if (isGoodOrBadOne == 0)
            {
                wichDrinkOne = "Bad";
            }
        }
        if (isRandomTwo == true)
        {
            if (isGoodOrBadTwo == 1)
            {
                wichDrinkTwo = "Neutral";
            }
            if (isGoodOrBadTwo == 0)
            {
                wichDrinkTwo = "Bad";
            }
        }
        //Ragnarok
        if (barTender.elementNamesOne[0] == 1 || barTender.elementNamesOne[0] == 5 || barTender.elementNamesOne[0] == 8)
        {
            if (barTender.elementNamesOne[1] == 1 || barTender.elementNamesOne[1] == 5 || barTender.elementNamesOne[1] == 8)
            {
                if (barTender.elementNamesOne[2] == 1 || barTender.elementNamesOne[2] == 5 || barTender.elementNamesOne[2] == 8)
                {
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[1];
                    wichDrinkOne = "Ragnarok";
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 1 || barTender.elementNamesTwo[0] == 5 || barTender.elementNamesTwo[0] == 8)
        {
            if (barTender.elementNamesTwo[1] == 1 || barTender.elementNamesTwo[1] == 5 || barTender.elementNamesTwo[1] == 8)
            {
                if (barTender.elementNamesTwo[2] == 1 || barTender.elementNamesTwo[2] == 5 || barTender.elementNamesTwo[2] == 8)
                {
                    wichDrinkTwo = "Ragnarok";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[1];
                    isRandomTwo = false;
                }
            }
        }
        //Pocalunek posejdona
        if (barTender.elementNamesOne[0] == 6 || barTender.elementNamesOne[0] == 13 || barTender.elementNamesOne[0] == 14)
        {
            if (barTender.elementNamesOne[1] == 6 || barTender.elementNamesOne[1] == 13 || barTender.elementNamesOne[1] == 14)
            {
                if (barTender.elementNamesOne[2] == 6 || barTender.elementNamesOne[2] == 13 || barTender.elementNamesOne[2] == 14)
                {
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[2];
                    wichDrinkOne = "Pocalunek Posejdona";
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 6 || barTender.elementNamesTwo[0] == 13 || barTender.elementNamesTwo[0] == 14)
        {
            if (barTender.elementNamesTwo[1] == 6 || barTender.elementNamesTwo[1] == 13 || barTender.elementNamesTwo[1] == 14)
            {
                if (barTender.elementNamesTwo[2] == 6 || barTender.elementNamesTwo[2] == 13 || barTender.elementNamesTwo[2] == 14)
                {
                    wichDrinkTwo = "Pocalunek Posejdona";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[2];
                    isRandomTwo = false;
                }
            }
        }
        //Cud w kanie
        if (barTender.elementNamesOne[0] == 1 || barTender.elementNamesOne[0] == 10 || barTender.elementNamesOne[0] == 12)
        {
            if (barTender.elementNamesOne[1] == 1 || barTender.elementNamesOne[1] == 10 || barTender.elementNamesOne[1] == 12)
            {
                if (barTender.elementNamesOne[2] == 1 || barTender.elementNamesOne[2] == 10 || barTender.elementNamesOne[2] == 12)
                {
                    wichDrinkOne = "Cud w kanie";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[3];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 1 || barTender.elementNamesTwo[0] == 10 || barTender.elementNamesTwo[0] == 12)
        {
            if (barTender.elementNamesTwo[1] == 1 || barTender.elementNamesTwo[1] == 10 || barTender.elementNamesTwo[1] == 12)
            {
                if (barTender.elementNamesTwo[2] == 1 || barTender.elementNamesTwo[2] == 10 || barTender.elementNamesTwo[2] == 12)
                {
                    wichDrinkTwo = "Cud w kanie";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[3];
                    isRandomTwo = false;
                }
            }
        }
        //Dar Kloacyny
        if (barTender.elementNamesOne[0] == 16 || barTender.elementNamesOne[0] == 7 || barTender.elementNamesOne[0] == 3)
        {
            if (barTender.elementNamesOne[1] == 16 || barTender.elementNamesOne[1] == 7 || barTender.elementNamesOne[1] == 3)
            {
                if (barTender.elementNamesOne[2] == 16 || barTender.elementNamesOne[2] == 7 || barTender.elementNamesOne[2] == 3)
                {
                    wichDrinkOne = "Dar Kolacyny";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[4];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 16 || barTender.elementNamesTwo[0] == 7 || barTender.elementNamesTwo[0] == 3)
        {
            if (barTender.elementNamesTwo[1] == 16 || barTender.elementNamesTwo[1] == 7 || barTender.elementNamesTwo[1] == 3)
            {
                if (barTender.elementNamesTwo[2] == 16 || barTender.elementNamesTwo[2] == 7 || barTender.elementNamesTwo[2] == 3)
                {
                    wichDrinkTwo = "Dar Kolacyny";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[4];
                    isRandomTwo = false;
                }
            }
        }
        //Baba Jaga
        if (barTender.elementNamesOne[0] == 9 || barTender.elementNamesOne[0] == 11 || barTender.elementNamesOne[0] == 13)
        {
            if (barTender.elementNamesOne[1] == 9 || barTender.elementNamesOne[1] == 11 || barTender.elementNamesOne[1] == 13)
            {
                if (barTender.elementNamesOne[2] == 9 || barTender.elementNamesOne[2] == 11 || barTender.elementNamesOne[2] == 13)
                {
                    wichDrinkOne = "Baba Jaga";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[5];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 9 || barTender.elementNamesTwo[0] == 11 || barTender.elementNamesTwo[0] == 13)
        {
            if (barTender.elementNamesTwo[1] == 9 || barTender.elementNamesTwo[1] == 11 || barTender.elementNamesTwo[1] == 13)
            {
                if (barTender.elementNamesTwo[2] == 9 || barTender.elementNamesTwo[2] == 11 || barTender.elementNamesTwo[2] == 13)
                {
                    wichDrinkTwo = "Baba Jaga";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[5];
                    isRandomTwo = false;
                }
            }
        }
        //Szczek anubisa
        if (barTender.elementNamesOne[0] == 2 || barTender.elementNamesOne[0] == 8 || barTender.elementNamesOne[0] == 16)
        {
            if (barTender.elementNamesOne[1] == 2 || barTender.elementNamesOne[1] == 8 || barTender.elementNamesOne[1] == 16)
            {
                if (barTender.elementNamesOne[2] == 2 || barTender.elementNamesOne[2] == 8 || barTender.elementNamesOne[2] == 16)
                {
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[6];
                    wichDrinkOne = "Szczek Anubisa";
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 2 || barTender.elementNamesTwo[0] == 8 || barTender.elementNamesTwo[0] == 16)
        {
            if (barTender.elementNamesTwo[1] == 2 || barTender.elementNamesTwo[1] == 8 || barTender.elementNamesTwo[1] == 16)
            {
                if (barTender.elementNamesTwo[2] == 2 || barTender.elementNamesTwo[2] == 8 || barTender.elementNamesTwo[2] == 16)
                {
                    wichDrinkTwo = "Szczek Anubisa";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[6];
                    isRandomTwo = false;
                }
            }
        }
        //Nabuzowanie
        if (barTender.elementNamesOne[0] == 5 || barTender.elementNamesOne[0] == 7 || barTender.elementNamesOne[0] == 12)
        {
            if (barTender.elementNamesOne[1] == 5 || barTender.elementNamesOne[1] == 7 || barTender.elementNamesOne[1] == 12)
            {
                if (barTender.elementNamesOne[2] == 5 || barTender.elementNamesOne[2] == 7 || barTender.elementNamesOne[2] == 12)
                {
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[7];
                    wichDrinkOne = "Nabuzowanie";
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 5 || barTender.elementNamesTwo[0] == 7 || barTender.elementNamesTwo[0] == 12)
        {
            if (barTender.elementNamesTwo[1] == 5 || barTender.elementNamesTwo[1] == 7 || barTender.elementNamesTwo[1] == 12)
            {
                if (barTender.elementNamesTwo[2] == 5 || barTender.elementNamesTwo[2] == 7 || barTender.elementNamesTwo[2] == 12)
                {
                    wichDrinkTwo = "Nabuzowanie";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[7];
                    isRandomTwo = false;
                }
            }
        }
        if (barTender.elementNamesOne[0] == 9 || barTender.elementNamesOne[0] == 5 || barTender.elementNamesOne[0] == 15)
        {
            if (barTender.elementNamesOne[1] == 9 || barTender.elementNamesOne[1] == 5 || barTender.elementNamesOne[1] == 15)
            {
                if (barTender.elementNamesOne[2] == 9 || barTender.elementNamesOne[2] == 5 || barTender.elementNamesOne[2] == 15)
                {
                    wichDrinkOne = "Menel";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[14];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 9 || barTender.elementNamesTwo[0] == 5 || barTender.elementNamesTwo[0] == 15)
        {
            if (barTender.elementNamesTwo[1] == 9 || barTender.elementNamesTwo[1] == 5 || barTender.elementNamesTwo[1] == 15)
            {
                if (barTender.elementNamesTwo[2] == 9 || barTender.elementNamesTwo[2] == 5 || barTender.elementNamesTwo[2] == 15)
                {
                    wichDrinkTwo = "Menel";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[14];
                    isRandomTwo = false;
                }
            }
        }

        //Wampir
        if (barTender.elementNamesOne[0] == 2 || barTender.elementNamesOne[0] == 4 || barTender.elementNamesOne[0] == 10)
        {
            if (barTender.elementNamesOne[1] == 2 || barTender.elementNamesOne[1] == 4 || barTender.elementNamesOne[1] == 10)
            {
                if (barTender.elementNamesOne[2] == 2 || barTender.elementNamesOne[2] == 4 || barTender.elementNamesOne[2] == 10)
                {
                    wichDrinkOne = "Wampir";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[9];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 2 || barTender.elementNamesTwo[0] == 4 || barTender.elementNamesTwo[0] == 10)
        {
            if (barTender.elementNamesTwo[1] == 2 || barTender.elementNamesTwo[1] == 4 || barTender.elementNamesTwo[1] == 10)
            {
                if (barTender.elementNamesTwo[2] == 2 || barTender.elementNamesTwo[2] == 4 || barTender.elementNamesTwo[2] == 10)
                {
                    wichDrinkTwo = "Wampir";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[9];
                    isRandomTwo = false;
                }
            }
        }
        //Dionizos
        if (barTender.elementNamesOne[0] == 6 || barTender.elementNamesOne[0] == 9 || barTender.elementNamesOne[0] == 10)
        {
            if (barTender.elementNamesOne[1] == 6 || barTender.elementNamesOne[1] == 9 || barTender.elementNamesOne[1] == 10)
            {
                if (barTender.elementNamesOne[2] == 6 || barTender.elementNamesOne[2] == 9 || barTender.elementNamesOne[2] == 10)
                {
                    wichDrinkOne = "Dionizos";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[10];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 6 || barTender.elementNamesTwo[0] == 9 || barTender.elementNamesTwo[0] == 10)
        {
            if (barTender.elementNamesTwo[1] == 6 || barTender.elementNamesTwo[1] == 9 || barTender.elementNamesTwo[1] == 10)
            {
                if (barTender.elementNamesTwo[2] == 6 || barTender.elementNamesTwo[2] == 9 || barTender.elementNamesTwo[2] == 10)
                {
                    wichDrinkTwo = "Dionizos";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[10];
                    isRandomTwo = false;
                }
            }
        }
        //Bek (Bazyliszek)
        if (barTender.elementNamesOne[0] == 3 || barTender.elementNamesOne[0] == 14 || barTender.elementNamesOne[0] == 16)
        {
            if (barTender.elementNamesOne[1] == 3 || barTender.elementNamesOne[1] == 14 || barTender.elementNamesOne[1] == 16)
            {
                if (barTender.elementNamesOne[2] == 3 || barTender.elementNamesOne[2] == 14 || barTender.elementNamesOne[2] == 16)
                {
                    wichDrinkOne = "Bek";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[11];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 3 || barTender.elementNamesTwo[0] == 14 || barTender.elementNamesTwo[0] == 16)
        {
            if (barTender.elementNamesTwo[1] == 3 || barTender.elementNamesTwo[1] == 14 || barTender.elementNamesTwo[1] == 16)
            {
                if (barTender.elementNamesTwo[2] == 3 || barTender.elementNamesTwo[2] == 14 || barTender.elementNamesTwo[2] == 16)
                {
                    wichDrinkTwo = "Bek";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[11];
                    isRandomTwo = false;
                }
            }
        }
        //Ikar
        if (barTender.elementNamesOne[0] == 7 || barTender.elementNamesOne[0] == 12 || barTender.elementNamesOne[0] == 15)
        {
            if (barTender.elementNamesOne[1] == 7 || barTender.elementNamesOne[1] == 12 || barTender.elementNamesOne[1] == 15)
            {
                if (barTender.elementNamesOne[2] == 7 || barTender.elementNamesOne[2] == 12 || barTender.elementNamesOne[2] == 15)
                {
                    wichDrinkOne = "Ikar";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[12];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 7 || barTender.elementNamesTwo[0] == 12 || barTender.elementNamesTwo[0] == 15)
        {
            if (barTender.elementNamesTwo[1] == 7 || barTender.elementNamesTwo[1] == 12 || barTender.elementNamesTwo[1] == 15)
            {
                if (barTender.elementNamesTwo[2] == 7 || barTender.elementNamesTwo[2] == 12 || barTender.elementNamesTwo[2] == 15)
                {
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[12];
                    wichDrinkTwo = "Ikar";
                    isRandomTwo = false;
                }
            }
        }
        // Afrodyta
        if (barTender.elementNamesOne[0] == 4 || barTender.elementNamesOne[0] == 13 || barTender.elementNamesOne[0] == 15)
        {
            if (barTender.elementNamesOne[1] == 4 || barTender.elementNamesOne[1] == 13 || barTender.elementNamesOne[1] == 15)
            {
                if (barTender.elementNamesOne[2] == 4 || barTender.elementNamesOne[2] == 13 || barTender.elementNamesOne[2] == 15)
                {
                    wichDrinkOne = "Afrodyta";
                    if (fight.wichOneWin == 0)
                        ultObject.sprite = ultImagesOne[13];
                    isRandomOne = false;
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 4 || barTender.elementNamesTwo[0] == 13 || barTender.elementNamesTwo[0] == 15)
        {
            if (barTender.elementNamesTwo[1] == 4 || barTender.elementNamesTwo[1] == 13 || barTender.elementNamesTwo[1] == 15)
            {
                if (barTender.elementNamesTwo[2] == 4 || barTender.elementNamesTwo[2] == 13 || barTender.elementNamesTwo[2] == 15)
                {
                    wichDrinkTwo = "Afrodyta";
                    if (fight.wichOneWin == 1)
                        ultObject.sprite = ultImagesTwo[13];
                    isRandomTwo = false;
                }
            }
        }
        // Menel


    }
}
