using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ModifySpheres : MonoBehaviour {
  private GameObject cube;

  void Start() {
    // Buscar el cubo en la escena
    cube = GameObject.FindWithTag("Black_Cube");
    incClosestType2();
  }

  void Update() {
    // Comprobar si se presiona la barra espaciadora
    if (Input.GetKeyDown(KeyCode.Space)) {
      ChgFurthestSphereColor();
    }
  }

  private void ChgFurthestSphereColor() {
    GameObject[] spheresType2 = GameObject.FindGameObjectsWithTag("Type2S");
    GameObject[] spheresType1 = GameObject.FindGameObjectsWithTag("Type1S");
    GameObject[] spheres = spheresType1.Concat(spheresType2).ToArray();
    GameObject furthest = null;
    float maxDistance = -1;

    foreach (GameObject sphere in spheres) {
      float distance = Vector3.Distance(sphere.transform.position, cube.transform.position);
      if (distance > maxDistance) {
        maxDistance = distance;
        furthest = sphere;
      }
    }

    Renderer renderer = furthest.GetComponent<Renderer>();
    // Cambiar el color a un color aleatorio,
    renderer.material.color = Random.ColorHSV();
    Debug.Log("Color cambiado a verde");
  }

  private void incClosestType2() {
    GameObject[] Type2Spheres = GameObject.FindGameObjectsWithTag("Type2S");

    GameObject closestSphere = null;
    float minDistance = float.MaxValue;

    foreach (GameObject sphere in Type2Spheres) {
      float distance = Vector3.Distance(sphere.transform.position, cube.transform.position);
      if (distance < minDistance) {
        minDistance = distance;
        closestSphere = sphere;
      }
    }

    Vector3 newPos = closestSphere.transform.position;
    newPos.y += 1;
    closestSphere.transform.position = newPos;
  }
}