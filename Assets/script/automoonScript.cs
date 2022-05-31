using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class automoonScript : MonoBehaviour
{
    public Animator moonnaimation;

    private void OnTriggerEnter(Collider other)

    {
        if(other.tag == "Player")
        {
            moonnaimation.Play("New Animation 0");
        }

    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "Player")
        {
            moonnaimation.Play("New Animation");
        }
    }

}
