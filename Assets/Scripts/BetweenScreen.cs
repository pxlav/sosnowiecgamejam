using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BetweenScreen : MonoBehaviour
{
    [SerializeField] float timer;
    private void Update()
    {
        timer -= Time.deltaTime;
        if(timer <= 0)
        {
            this.gameObject.SetActive(false);
        }
    }
}
