using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * 0.01f, ForceMode.Impulse);
    }

}
