using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShowSphereVector : MonoBehaviour {
  private Vector3 spherePosition;

  void Start() {
    showVector();
  }

  void OnValidate() {
    showVector();
  }

  void showVector() {
    spherePosition = transform.position;
    Debug.Log("Posición de la esfera: " + spherePosition.ToString("F2"));
  }
}