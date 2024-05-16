using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrapdoorBehaviour : MonoBehaviour
{
    MeshRenderer trapdoor;
    BoxCollider floor;
    private bool trap_active = false;

    // Start is called before the first frame update
    void Start()
    {
        trapdoor = GetComponent<MeshRenderer>();
        floor = GetComponent<BoxCollider>();    
    }

    // Update is called once per frame
    void Update()
    {
       
       if (trap_active)
        {
            trapdoor.enabled = false;
            floor.enabled = false;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            trap_active = true;
        }

    }
}
