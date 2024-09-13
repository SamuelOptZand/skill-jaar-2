using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;

public class Animations : MonoBehaviour
{
    public Timer clock;
    private Animator anim;
    private Rigidbody rb;
    public Fishnish Linetrigga;

    void Start()
    {
        clock = GameObject.Find("Canvas").GetComponent<Timer>();
        Linetrigga = GetComponent<Fishnish>();
        anim = gameObject.GetComponent<Animator>();
        rb = gameObject.GetComponent<Rigidbody>();
    }
    void Update()
    {
        ResetAllTriggers();
        if (rb.velocity.x > 0f)
        {
            anim.SetTrigger("Swim");
        }
        if (rb.velocity.x == 0f && clock.timer >= 0f)
        {
            anim.SetTrigger("Idle");
        }
        if (clock.timer == 0f)
        {
            anim.SetTrigger("Death");
        }
        if (Linetrigga.finish == true)
        {
            anim.SetTrigger("Win");
        }
    }
    void ResetAllTriggers()
    {
        anim.ResetTrigger("Swim");
        anim.ResetTrigger("Idle");
        anim.ResetTrigger("Death");
        anim.ResetTrigger("Win");
    }
}
