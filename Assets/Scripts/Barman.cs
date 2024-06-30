using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Barman : MonoBehaviour
{
    public Animator barmanAnimator;
    public bool isPlayShake;
    public bool isPlayNalewanie;
    public float nalewanieTimer;
    public float shakeTimer;
    public AudioSource shakeSound;
    public AudioSource nalewanieSound;
    private void Start()
    {
        nalewanieTimer = 0.4f;
        shakeTimer = 1.0f;
    }
    private void Update()
    {
        if(isPlayNalewanie == true)
        {
            barmanAnimator.Play("barman");
            nalewanieTimer -= Time.deltaTime;
            if(nalewanieTimer <= 0)
            {
                nalewanieTimer = 0.4f;
                isPlayNalewanie = false;
            }
        }
        if(isPlayShake == true)
        {
            barmanAnimator.Play("shake");
            shakeTimer -= Time.deltaTime;
            if(shakeTimer <= 0)
            {
                shakeTimer = 1.0f;
                isPlayShake = false;
            }
        }
        if(isPlayShake == false && isPlayNalewanie == false)
        {
            barmanAnimator.Play("BarManIdle");
        }
    }

    public void PlayShake()
    {
        isPlayShake = true;
        shakeSound.Play();
    }
    public void PlayNalewanie()
    {
        isPlayNalewanie = true;
        nalewanieSound.Play();
    }
}
