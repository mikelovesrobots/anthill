using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHub : MonoBehaviour
{
  public static EventHub Instance;
  public delegate void GenericEvent();
  public GenericEvent OnBallSwallowed;

  void Awake()
  {
    Instance = this;
  }

  public void BallSwallowed()
  {
    OnBallSwallowed();
  }
}
