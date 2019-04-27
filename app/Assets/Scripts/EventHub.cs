using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHub : MonoBehaviour
{
  public static EventHub Instance;
  public delegate void GenericEvent();
  public delegate void BoolEvent(bool isHighlighted);
  public GenericEvent OnResetRequested;
  public BoolEvent OnBallSwallowed;
  public GenericEvent OnBallSpawned;

  void Awake()
  {
    Instance = this;
  }

  public void BallSwallowed(bool isHighlighted)
  {
    if (OnBallSwallowed != null)
      OnBallSwallowed(isHighlighted);
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
