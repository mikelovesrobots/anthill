using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHub : MonoBehaviour
{
  public static EventHub Instance;
  public delegate void GenericEvent();
  public GenericEvent OnResetRequested;
  public GenericEvent OnBallSwallowed;
  public GenericEvent OnBallSpawned;

  void Awake()
  {
    Instance = this;
  }

  public void BallSwallowed()
  {
    if (OnBallSwallowed != null)
      OnBallSwallowed();
  }

  public void BallSpawned()
  {
    if (OnBallSpawned != null)
      OnBallSpawned();
  }

  public void ResetRequested()
  {
    if (OnResetRequested != null)
      OnResetRequested();
  }
}
