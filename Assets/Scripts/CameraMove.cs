using UnityEngine;

public class CameraMove : MonoBehaviour {
    private Transform parent;
    [SerializeField] private float rotSpeed = 5f;
    void Start() {
        parent = transform.parent;
        transform.SetParent(null);
    }

    void Update() {
        
        transform.position = new Vector3(parent.position.x, parent.position.y + 9f, parent.position.z - 20f);

        
        if (Input.GetMouseButton(0)) {
            float mouseX = Input.GetAxis("Mouse X");
            RotateCamera(mouseX);
        }
    }

    void RotateCamera(float mouseX) {
        transform.RotateAround(parent.position, Vector3.up, mouseX * rotSpeed);
    }
}
