using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour {

    public GameObject Plataform;
    public GameObject PanelVictory;
    public float restartHeight = -30f; 


    private Rigidbody rb;

    void Start() {
        rb = GetComponent<Rigidbody>();
        rb.AddForce(Vector3.down * 0.01f, ForceMode.Impulse);
    }

    private void Update() {

        if (transform.position.y < restartHeight) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Bad")) {
            Plataform.GetComponent<Collider>().isTrigger = true;
        }
        if (other.CompareTag("Great")) {
            PanelVictory.SetActive(true);
        }
    }


}
