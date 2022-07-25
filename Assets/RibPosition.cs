using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RibPosition : MonoBehaviour
{
    public GameObject burger;

    void Start() {
        var rb = gameObject.GetComponent<Rigidbody>();
        var position = new Vector3(
            Random.Range(-6.2f, -5.5f),
            Random.Range(2.5f, 10f),
            Random.Range(-2.85f, -2.1f)
        );
        var size = Random.Range(0.5f, 1.5f);
        var thiccness = Random.Range(0.5f, 1.5f);
        var mass = Random.Range(1.0f, 10.0f) * Random.Range(0.5f, 10.0f);
        
        if (Mathf.Round(Random.Range(0f, 4f)) == 0) {
            size = size * 1.5f;
            gameObject.SetActive(false);
            burger.SetActive(true);
            burger.transform.position = position;
            burger.transform.localScale = new Vector3(size, size, size);
            burger.GetComponent<Rigidbody>().mass = mass;
        } else {
            rb.mass = mass;
            transform.position = position;
            transform.localScale = new Vector3(size, size, size);
        }
    }
}
