using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnInput : MonoBehaviour {
  public Color cylinderColor = Color.red;  
  public Color cubeColor = Color.blue;     
  private Renderer m_Renderer;
  private GameObject cube;     
  private GameObject cylinder; 

  void Start() {
    cube = GameObject.FindWithTag("Yellow_Cube");
    cylinder = GameObject.FindWithTag("Black_Cylinder");
  }

  void Update() {
    if (Input.GetKeyDown(KeyCode.C)) {
      changeColor("cube", cylinderColor);
    } if (Input.GetKeyDown(KeyCode.UpArrow)) {
      changeColor("cylinder", cubeColor);
    }
  }

  void changeColor(string ObjectType, Color newColor){
    if (ObjectType == "cube") {
      cube.GetComponent<Renderer>().material.color = newColor;
    } if (ObjectType == "cylinder") {
      cylinder.GetComponent<Renderer>().material.color = newColor;
    }
  }
}