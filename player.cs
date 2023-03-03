using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player : MonoBehaviour {
    public float speed = 5.0f;

    void Update() {
        if (Input.GetKey("w")) {
            transform.Translate(0, 0, (speed * Time.deltaTime));
        }
        if (Input.GetKey("s")) {
            transform.Translate(0, 0, -(speed * Time.deltaTime));
        }
        if (Input.GetKey("a")) {
            transform.Translate(-(speed * Time.deltaTime), 0, 0);
        }
        if (Input.GetKey("d")) {
            transform.Translate((speed * Time.deltaTime), 0, 0);
        }
    }
}