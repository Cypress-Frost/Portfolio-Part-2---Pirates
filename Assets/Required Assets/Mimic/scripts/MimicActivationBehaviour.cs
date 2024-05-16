using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MimicActivationBehaviour : MonoBehaviour

{
    MeshRenderer mimic_component;
    private bool mimic_active = false;

    // Start is called before the first frame update
    void Start()
    {
        mimic_component = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        if (!mimic_active)
        {
            mimic_component.enabled = false;
        }

        else if (mimic_active)
        {
            //activate eyes and tongue
            mimic_component.enabled = true;
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            mimic_active = true;
        }

    }
}
