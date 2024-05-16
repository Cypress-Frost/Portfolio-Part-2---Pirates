using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class npcBehaviour : MonoBehaviour
{
    public Animator animator;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            //play animation
            animator.SetTrigger("player_near");
        }

    }
}
