using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlataformMove : MonoBehaviour {
    [SerializeField] private float rotationSpeed = 50f;

    void Update() {
        HandleInput();
    }

    void HandleInput() {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        if (horizontalInput != 0 || verticalInput != 0) {
            float rotationAmount = rotationSpeed * Time.deltaTime;
            Vector3 rotation = new Vector3(verticalInput, 0, -horizontalInput) * rotationAmount;
            transform.Rotate(rotation);
        }
    }
}