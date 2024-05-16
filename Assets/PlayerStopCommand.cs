using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerStopCommand : MonoBehaviour
{
    PlayerInput input;
    private bool stop = false;

    // Start is called before the first frame update
    void Start()
    {
        input = GetComponent<PlayerInput>();
    }

    // Update is called once per frame
    void Update()
    {
        if (stop)
        {
            input.enabled = false;
        }
        else
        {
            input.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Mirror" || other.tag == "Trapdoor")
        {
            stop = true;
        }
        else
        {
            stop = false;
        }

    }
}
