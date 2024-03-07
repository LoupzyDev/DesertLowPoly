using System.Collections;
using UnityEngine;

public class TornadoForce : MonoBehaviour {
    public Transform tornadoCenter;
    public float attractionForce = 10f;
    public float attractionRate = 0.1f;

    private bool isAttracting = false;

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Box")) {
            StartCoroutine(ApplyTornadoForce(other.gameObject));
        }
    }

    private void OnTriggerExit(Collider other) {
        if (other.CompareTag("Box")) {
            isAttracting = false;
        }
    }

    private IEnumerator ApplyTornadoForce(GameObject objectToAttract) {
        Rigidbody rb = objectToAttract.GetComponent<Rigidbody>();

        if (rb != null) {
            isAttracting = true;

            while (isAttracting) {
                Vector3 directionToTornado = tornadoCenter.position - objectToAttract.transform.position;

                rb.AddForce(directionToTornado.normalized * attractionForce);

                yield return new WaitForSeconds(attractionRate);
            }
        }
    }
}
