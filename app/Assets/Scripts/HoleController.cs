using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using TMPro;

public class HoleController : MonoBehaviour
{
  public StateMachine StateMachine;
  public TextMeshPro TextMeshPro;

  public void SetHoleNumber(int number)
  {
    TextMeshPro.text = number.ToString();
  }

  public void Reset()
  {
    StateMachine.ChangeState("_Default");
  }

  public void Highlight()
  {
    StateMachine.ChangeState("_Highlighted");
  }

  public void Swallow(BallController ballController)
  {
    ballController.Swallow();
    EventHub.Instance.BallSwallowed(IsHighlighted);
  }

  private bool IsHighlighted => StateMachine.currentState.name == "_Highlighted";
}
