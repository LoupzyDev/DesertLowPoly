using UnityEngine;

public class PlataformMove : MonoBehaviour {
    public float maxRotationX = 45f;
    public float maxRotationZ = 45f;
    public float rotationSpeed = 5f;

    void Update() {

        float rotationX = Input.GetAxis("Vertical") * maxRotationX;
        rotationX = Mathf.Clamp(rotationX, -maxRotationX, maxRotationX);
        Quaternion newRotationX = Quaternion.Euler(rotationX, 0f, 0f);


        float rotationZ = Input.GetAxis("Horizontal") * maxRotationZ;
        rotationZ = Mathf.Clamp(rotationZ, -maxRotationZ, maxRotationZ);
        Quaternion newRotationZ = Quaternion.Euler(0f, 0f, rotationZ);

        transform.rotation = Quaternion.Slerp(transform.rotation, newRotationX * newRotationZ, rotationSpeed * Time.deltaTime);
    }
}
