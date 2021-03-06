﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EarthAnimatorController : AnimatorController
{
    [SerializeField] private Animator animator;
    public void PlayAttack()
    {
        animator.SetTrigger("Attack");
    }
    public void PlayBigAttack()
    {
        animator.SetTrigger("BigAttack");
    }
    public void PlayCounterAttack()
    {
        animator.SetTrigger("Counter");
    }
    /*public void PlayCounterSucessAttack()
    {
        animator.SetTrigger("CounterHit");
    }*/
    override public void ToIdle()
    {
        animator.SetBool("GoForward", false);
        animator.SetBool("GoBackward", false);
        animator.SetBool("GoLeft", false);
        animator.SetBool("GoRight", false);
    }
    override public void WalkForward()
    {
        animator.SetBool("GoForward", true);
        animator.SetBool("GoBackward", false);
        animator.SetBool("GoLeft", false);
        animator.SetBool("GoRight", false);
    }
    override public void WalkBackward()
    {
        animator.SetBool("GoForward", false);
        animator.SetBool("GoBackward", true);
        animator.SetBool("GoLeft", false);
        animator.SetBool("GoRight", false);
    }
    override public void WalkLeft()
    {
        animator.SetBool("GoForward", false);
        animator.SetBool("GoBackward", false);
        animator.SetBool("GoLeft", true);
        animator.SetBool("GoRight", false);
    }
    override public void WalkRight()
    {
        animator.SetBool("GoForward", false);
        animator.SetBool("GoBackward", false);
        animator.SetBool("GoLeft", false);
        animator.SetBool("GoRight", true);
    }
    public void PlayDash()
    {
        animator.SetTrigger("Dash");
    }
    public void PlayLand()
    {
        animator.SetTrigger("Landing");
    }
    public void PlayWall()
    {
        animator.SetTrigger("WallAttack");
    }

    public override void Die()
    {
        animator.enabled = false;
    }
    public override void Revive()
    {
        animator.enabled = true;
        animator.CrossFade("Idle", 0);
    }
    public override void Spawn()
    {
        animator.CrossFade("Idle", 0);
    }

    public override void PlayTaunt(Vector2 tauntVect)
    {
        animator.SetTrigger("Taunt01");
    }

}
