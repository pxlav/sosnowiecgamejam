using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class Ending : MonoBehaviour
{
    public float timer;
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            Application.LoadLevel(0);
        }
    }
}
