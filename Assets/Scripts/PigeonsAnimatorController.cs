using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PigeonsAnimatorController : MonoBehaviour
{
    public Animator oneAnimator;
    public Animator twoAnimator;
    public Fight fight;

    private void Update()
    {
        if(fight.isPlayerOneWon == false && fight.playersScores[0] == 0)
        {
            oneAnimator.Play("szerokipicie");
        }
        if (fight.isPlayerTwoWon == false && fight.playersScores[1] == 0)
        {
            twoAnimator.Play("Picie");
        }
        if (fight.isPlayerOneWon == true)
        {
            if(fight.combinations.isRandomOne == true)
            {
                if(fight.combinations.isGoodOrBadOne == 0)
                {
                    oneAnimator.Play("SzerokiRzyg");
                }
                if (fight.combinations.isGoodOrBadOne == 1)
                {
                    oneAnimator.Play("Idle");
                }
            }
            if(fight.combinations.isRandomOne == false)
            {
                oneAnimator.Play("Idle");
            }
        }
        if(fight.isPlayerTwoWon == true)
        {
            if (fight.combinations.isRandomTwo == true)
            {
                if (fight.combinations.isGoodOrBadTwo == 0)
                {
                    twoAnimator.Play("Rzyg");
                }
                if (fight.combinations.isGoodOrBadTwo == 1)
                {
                    twoAnimator.Play("Idle");
                }
            }
            if (fight.combinations.isRandomTwo == false)
            {
                oneAnimator.Play("Idle");
            }
        }

    }
}
