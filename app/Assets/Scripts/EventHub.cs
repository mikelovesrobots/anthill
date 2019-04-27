using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHub : MonoBehaviour
{
  public static EventHub Instance;
  public LeverLiftController[] LeverLiftControllers;

  void Awake()
  {
    Instance = this;
  }

  public void BallSwallowed()
  {
    foreach (var leverLiftController in LeverLiftControllers)
    {
      leverLiftController.Reset();
    }
  }
}
