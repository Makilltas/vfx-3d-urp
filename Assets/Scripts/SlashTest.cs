using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlashTest : MonoBehaviour
{
    public ParticleSystem slashEffect;


    private Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            StartCoroutine(Slash());
        }
    }


    IEnumerator Slash()
    {
        anim.Play("Slash");
        yield return new WaitForSeconds(0.8f);
        slashEffect.Play();
    }
}
