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
    if (IsHighlighted)
      StateMachine.ChangeState("_Default");
  }

  public void Highlight()
  {
    StateMachine.ChangeState("_Highlighted");
  }

  public void Swallow(BallController ballController)
  {
    if (!IsHighlighted)
    {
      StateMachine.ChangeState("_Shrinking");
    }
    ballController.Swallow(transform);
    EventHub.Instance.BallSwallowed(IsHighlighted);
  }

  private bool IsHighlighted => StateMachine.currentState.name == "_Highlighted";
}
