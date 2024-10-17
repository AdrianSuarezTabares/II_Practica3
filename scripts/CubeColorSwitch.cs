using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeColorSwitch : MonoBehaviour {
  public int framesPerChange = 120;

  private Renderer rend;
  private Color colorVector;
  private int frameCount; 

  void Start() {
    rend = GetComponent<Renderer>();
    colorVector = new Color(Random.value, Random.value, Random.value);
    rend.material.color = colorVector;
    frameCount = 0;
  }

  void Update() {
    frameCount++;
    if (frameCount % framesPerChange == 0) {
      frameCount = 0;
      int index = Random.Range(0, 3); 
      colorVector[index] = Random.value;
      rend.material.color = colorVector;
    }
  }
}
