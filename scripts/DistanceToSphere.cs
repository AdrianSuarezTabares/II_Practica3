using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DistanceToSphere : MonoBehaviour {
  private GameObject cube;
  private GameObject cylinder;
  private GameObject sphere;

  void calculateDistance() {
    Vector3 spherePos = sphere.transform.position;
    Vector3 cubePos = cube.transform.position;
    Vector3 cylinderPos = cylinder.transform.position;

    float distanceCube = Vector3.Distance(spherePos, cubePos);
    float distanceCylinder = Vector3.Distance(spherePos, cylinderPos);

    Debug.Log("Distancia entre la esfera y el cubo: " + distanceCube);
    Debug.Log("Distancia entre la esfera y el cilindro: " + distanceCylinder);
  }
  void Start() {
    sphere = GameObject.FindWithTag("White_Sphere");
    cube = GameObject.FindWithTag("Yellow_Cube");
    cylinder = GameObject.FindWithTag("Black_Cylinder");
    calculateDistance();
  }
}
