using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class BallController : MonoBehaviour
{
  public StateMachine StateMachine;

  public void Swallow()
  {
    EventHub.Instance.BallSwallowed();
    StateMachine.ChangeState("_Swallowed");
  }
}
