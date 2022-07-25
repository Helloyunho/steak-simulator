using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibCook : MonoBehaviour
{
    public Material ribMaterial;
    public float maxCookSeconds = 300;
    public float totalCookTime = 0.0f;
    float lastTime;
    bool isCooking = false;

    void Start() {
        lastTime = Time.time;
        ribMaterial.SetFloat("_Opecity", 0f);
        maxCookSeconds = Random.Range(120f, 180f);
    }

    // Update is called once per frame
    void Update()
    {
        if (isCooking) {
            totalCookTime = Time.time - lastTime;
            ribMaterial.SetFloat("_Opecity", totalCookTime / maxCookSeconds);
        }
    }

    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.name == "Grill" && isCooking == false) {
            isCooking = true;
            lastTime = Time.time;
        } else if (collision.gameObject.name != "Grill") {
            isCooking = false;
        }
    }
}
