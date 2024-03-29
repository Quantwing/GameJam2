﻿using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour {

    public float speed;
    public bool StartAttacking = false;

	void Start () {
        animator = GetComponent<Animator>();
        if (GetComponent<Rigidbody>().position.x < 0)
        {
            int invert = -1;
            GetComponent<Rigidbody>().velocity = transform.right * speed;
            transform.localScale = new Vector3(-transform.localScale.x, transform.localScale.y, transform.localScale.z);
        }
        if (GetComponent<Rigidbody>().position.x >= 0)
        {
            GetComponent<Rigidbody>().velocity = transform.right * -speed;
        }
	}
    Animator animator;
    void OnTriggerEnter(Collider StopPosition)
    {
        GetComponent<Rigidbody>().velocity = transform.right * 0;
        StartAttacking = true;
        bool asd = true;
        animator.SetBool("Attacking", asd);
    }
}
