using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class RibFlip : MonoBehaviour
{
    public RibCook ribCook;
    bool isFlippable = false;
    float flipTimeInterval = 0.0f;

    void Start()
    {
        flipTimeInterval = ribCook.maxCookSeconds / 4;
    }

    void Update() {
        var sthSthCookTime = ribCook.totalCookTime % flipTimeInterval;
        if ((sthSthCookTime > flipTimeInterval - 0.25f || sthSthCookTime < 0.25f) && !isFlippable) {
            isFlippable = true;
            Debug.Log("Flippable");
        } else if (isFlippable) {
            isFlippable = false;
            Debug.Log("Done lmao");
        }
    }

    public void OnFlip()
    {
        if (isFlippable) {
            var inversedRotation = Quaternion.Inverse(transform.rotation);
            while (transform.rotation == inversedRotation) {
                transform.rotation = Quaternion.Slerp(transform.rotation, inversedRotation,  Time.deltaTime);
            }
        }
    }
}
