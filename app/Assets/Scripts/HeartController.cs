using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class HeartController : MonoBehaviour
{
  public StateMachine StateMachine;

  public void Show()
  {
    StateMachine.ChangeState("_Showing");
  }

  public void Hide()
  {
    StateMachine.ChangeState("_Hiding");
  }
}
