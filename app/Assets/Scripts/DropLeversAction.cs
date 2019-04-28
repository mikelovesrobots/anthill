using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DropLeversAction : MonoBehaviour
{
  public LeverLiftController[] LeverLiftControllers;
  public void Act()
  {
    foreach (var leverLiftController in LeverLiftControllers)
    {
      leverLiftController.Drop();
    }
  }
}
