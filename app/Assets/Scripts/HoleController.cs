using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleController : MonoBehaviour
{
  public void OnTriggerEnter2D(Collider2D other)
  {
    Debug.Log("Hit");
  }
}
