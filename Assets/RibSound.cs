using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibSound : MonoBehaviour
{
    public AudioSource audioSource;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Grill" && audioSource.enabled == false) {
            audioSource.enabled = true;
        } else if (collision.gameObject.name != "Grill") {
            audioSource.enabled = false;
        }
    }
}
