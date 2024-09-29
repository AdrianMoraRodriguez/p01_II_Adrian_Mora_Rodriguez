using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obtenerPos : MonoBehaviour
{
    // Start is called before the first frame update
  void Start() {
    GameObject[] allObjects = FindObjectsOfType<GameObject>();
    foreach (GameObject obj in allObjects) {
      Debug.Log("Nombre: " + obj.name + " Posicion: " + obj.transform.position + "Tag: " + obj.tag);
    }
  }

    // Update is called once per frame
  void Update() {
        
  }
}
