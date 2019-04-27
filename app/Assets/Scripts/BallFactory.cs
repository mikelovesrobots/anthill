using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallFactory : MonoBehaviour
{
  public GameObject Prefab;

  public GameObject Create()
  {
    var instance = GameObject.Instantiate(Prefab, transform.position, Quaternion.identity) as GameObject;
    return instance;
  }
}
