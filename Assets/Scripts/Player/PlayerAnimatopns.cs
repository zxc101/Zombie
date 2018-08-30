using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatopns : MonoBehaviour {

    Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void OnAnimatorMove()
    {
        anim.SetFloat("", 0.5f);
    }
}
