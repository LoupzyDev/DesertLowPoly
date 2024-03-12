using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveTornado : MonoBehaviour
{
    public Camera miniMap;
    void Update() {
        
        if (Input.GetMouseButtonDown(1)) {
            
            Ray ray = miniMap.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if (Physics.Raycast(ray, out hit, Mathf.Infinity, LayerMask.GetMask("Suelo"))) {
                
                transform.position = hit.point;
            }
        }
    }
}
