using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VectorComparison : MonoBehaviour
{
  public Vector3 vectorA;
  public Vector3 vectorB;

  public float magnitudeA;
  public float magnitudeB;
  public float angleBetween;
  public float distanceBetween;
  public string higherVectorMessage;

  void Start() {
    showProperties();
  }

  void OnValidate() {
    showProperties();
  }

  void showProperties() {
    magnitudeA = vectorA.magnitude;
    magnitudeB = vectorB.magnitude;

    angleBetween = Vector3.Angle(vectorA, vectorB);

    distanceBetween = Vector3.Distance(vectorA, vectorB);

    if (vectorA.y > vectorB.y) {
      higherVectorMessage = "Vector A está a mayor altura";
    } else if (vectorA.y < vectorB.y) {
      higherVectorMessage = "Vector B está a mayor altura";
    } else {
      higherVectorMessage = "Ambos vectores están a la misma altura";
    }
    Debug.Log("Mostrando propiedades de los vectores");
    Debug.Log("Magnitud de Vector A: " + magnitudeA);
    Debug.Log("Magnitud de Vector B: " + magnitudeB);
    Debug.Log("Ángulo entre Vector A y Vector B: " + angleBetween + " grados");
    Debug.Log("Distancia entre Vector A y Vector B: " + distanceBetween);
    Debug.Log(higherVectorMessage);
  }
}