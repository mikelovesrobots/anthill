using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisableGameObjectsAction : ActionBase
{
  public GameObject[] GameObjects;

  public override void Act()
  {
    foreach (var gameObject in GameObjects)
    {
      gameObject.SetActive(false);
    }
  }
}