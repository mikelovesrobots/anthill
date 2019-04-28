using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Camera))]
public class FixedWidthCamera : MonoBehaviour
{
  public float DesiredWidthInUnits = 16f;

  private float size;
  private float ratio;
  private float screenHeight;

  void Awake()
  {
    var camera = GetComponent<Camera>();
    camera.orthographicSize = DesiredWidthInUnits * Screen.height / Screen.width / 2;
  }
}