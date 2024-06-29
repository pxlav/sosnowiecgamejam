using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuBook : MonoBehaviour
{
    public int wichPage;
    public GameObject bookObj;
    public GameObject[] pages;
    public bool isOn;

    private void Update()
    {
        for(int i = 0; i < pages.Length; i++)
        {
            if(i == wichPage)
            {
                pages[i].SetActive(true);
            }else
            {
                pages[i].SetActive(false);
            }
            if(i == pages.Length)
            {
                i = 0;
            }
        }
        if(isOn == true)
        {
            bookObj.SetActive(true);
        }
        else
        {
            bookObj.SetActive(false);
        }
    }
    public void OnMouseDown()
    {
        isOn = !isOn;
    }
    public void NextPage()
    {
        if (wichPage < 2)
            wichPage++;
    }
    public void backpage()
    {
        if(wichPage > 0)
        wichPage--;
    }
}
