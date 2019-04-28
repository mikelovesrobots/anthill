using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class StateMachineChanger : MonoBehaviour
{
  public StateMachine StateMachine;
  public string NextState;

  public void Change()
  {
    StateMachine.ChangeState(NextState);
  }
}
