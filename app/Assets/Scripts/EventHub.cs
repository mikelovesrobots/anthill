using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventHub : MonoBehaviour
{
  public static EventHub Instance;
  public RespawnController RespawnController;

  void Awake()
  {
    Instance = this;
  }

  public void BallSwallowed()
  {
    RespawnController.Respawn();
  }
}
