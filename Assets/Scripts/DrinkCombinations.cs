using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrinkCombinations : MonoBehaviour
{
    public string wichDrinkOne;
    public string wichDrinkTwo;
    public BarTender barTender;
    public int drinkValue;
    public int[] ValuesToID;

    private void Update()
    {
        //Ragnarok
        if (barTender.elementNamesOne[0] == 1 || barTender.elementNamesOne[0] == 5 || barTender.elementNamesOne[0] == 8)
        {
            if (barTender.elementNamesOne[1] == 1 || barTender.elementNamesOne[1] == 5 || barTender.elementNamesOne[1] == 8)
            {
                if (barTender.elementNamesOne[2] == 1 || barTender.elementNamesOne[2] == 5 || barTender.elementNamesOne[2] == 8)
                {
                    wichDrinkOne = "Ragnarok";
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
                    wichDrinkOne = "Pocalunek Posejdona";
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
                }
            }
        }
        //Dar Kloacyny
        if (barTender.elementNamesOne[0] == 16 || barTender.elementNamesOne[0] == 7 || barTender.elementNamesOne[0] == 12)
        {
            if (barTender.elementNamesOne[1] == 16 || barTender.elementNamesOne[1] == 7 || barTender.elementNamesOne[1] == 12)
            {
                if (barTender.elementNamesOne[2] == 16 || barTender.elementNamesOne[2] == 7 || barTender.elementNamesOne[2] == 12)
                {
                    wichDrinkOne = "Dar Kolacyny";
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
                }
            }
        }
        //Szczek anubisa
        if (barTender.elementNamesOne[0] == 2 || barTender.elementNamesOne[0] == 8 || barTender.elementNamesOne[0] == 16)
        {
            if (barTender.elementNamesOne[1] == 2 || barTender.elementNamesOne[1] == 8 || barTender.elementNamesOne[1] == 16)
            {
                if (barTender.elementNamesOne[2] ==2 || barTender.elementNamesOne[2] == 8 || barTender.elementNamesOne[2] == 16)
                {
                    wichDrinkOne = "Szczek Anubisa";
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
                    wichDrinkOne = "Nabuzowanie";
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
                }
            }
        }
        if (barTender.elementNamesOne[0] == 7 || barTender.elementNamesOne[0] == 7 || barTender.elementNamesOne[0] == 7)
        {
            if (barTender.elementNamesOne[1] == 7 || barTender.elementNamesOne[1] == 7 || barTender.elementNamesOne[1] == 7)
            {
                if (barTender.elementNamesOne[2] ==7 || barTender.elementNamesOne[2] == 7 || barTender.elementNamesOne[2] == 7)
                {
                    wichDrinkOne = "Nabuzowanie";
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 7 || barTender.elementNamesTwo[0] == 7 || barTender.elementNamesTwo[0] == 7)
        {
            if (barTender.elementNamesTwo[1] == 7 || barTender.elementNamesTwo[1] == 7 || barTender.elementNamesTwo[1] == 7)
            {
                if (barTender.elementNamesTwo[2] == 7 || barTender.elementNamesTwo[2] == 7 || barTender.elementNamesTwo[2] == 7)
                {
                    wichDrinkTwo = "Nabuzowanie";
                }
            }
        }
        //Polak
        if (barTender.elementNamesOne[0] == 15 || barTender.elementNamesOne[0] == 15 || barTender.elementNamesOne[0] == 15)
        {
            if (barTender.elementNamesOne[1] == 15 || barTender.elementNamesOne[1] == 15 || barTender.elementNamesOne[1] == 15)
            {
                if (barTender.elementNamesOne[2] == 15 || barTender.elementNamesOne[2] == 15 || barTender.elementNamesOne[2] == 15)
                {
                    wichDrinkOne = "Polak";
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 15 || barTender.elementNamesTwo[0] == 15 || barTender.elementNamesTwo[0] == 15)
        {
            if (barTender.elementNamesTwo[1] == 15 || barTender.elementNamesTwo[1] == 15 || barTender.elementNamesTwo[1] == 15)
            {
                if (barTender.elementNamesTwo[2] == 15 || barTender.elementNamesTwo[2] == 15 || barTender.elementNamesTwo[2] == 15)
                {
                    wichDrinkTwo = "Polak";
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
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 7 || barTender.elementNamesTwo[0] == 12 || barTender.elementNamesTwo[0] == 15)
        {
            if (barTender.elementNamesTwo[1] == 7 || barTender.elementNamesTwo[1] == 12 || barTender.elementNamesTwo[1] == 15)
            {
                if (barTender.elementNamesTwo[2] == 7 || barTender.elementNamesTwo[2] == 12 || barTender.elementNamesTwo[2] == 15)
                {
                    wichDrinkTwo = "Ikar";
                }
            }
        }
        // Afrodyta
        if (barTender.elementNamesOne[0] == 4 || barTender.elementNamesOne[0] == 12 || barTender.elementNamesOne[0] == 15)
        {
            if (barTender.elementNamesOne[1] == 4 || barTender.elementNamesOne[1] == 12 || barTender.elementNamesOne[1] == 15)
            {
                if (barTender.elementNamesOne[2] == 4 || barTender.elementNamesOne[2] == 12 || barTender.elementNamesOne[2] == 15)
                {
                    wichDrinkOne = "Afrodyta";
                }
            }
        }
        if (barTender.elementNamesTwo[0] == 4 || barTender.elementNamesTwo[0] == 12 || barTender.elementNamesTwo[0] == 15)
        {
            if (barTender.elementNamesTwo[1] == 4 || barTender.elementNamesTwo[1] == 12 || barTender.elementNamesTwo[1] == 15)
            {
                if (barTender.elementNamesTwo[2] == 4 || barTender.elementNamesTwo[2] == 12 || barTender.elementNamesTwo[2] == 15)
                {
                    wichDrinkTwo = "Afrodyta";
                }
            }
        }
        // Menel
        if (barTender.elementNamesOne[0] == 9 || barTender.elementNamesOne[0] == 5 || barTender.elementNamesOne[0] == 15)
        {
            if (barTender.elementNamesOne[1] == 9 || barTender.elementNamesOne[1] == 5 || barTender.elementNamesOne[1] == 15)
            {
                if (barTender.elementNamesOne[2] == 9 || barTender.elementNamesOne[2] == 5 || barTender.elementNamesOne[2] == 15)
                {
                    wichDrinkOne = "Menel";
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
                }
            }
        }

    }
}
