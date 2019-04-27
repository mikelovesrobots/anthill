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

  public void Highlight()
  {
    StateMachine.ChangeState("_Highlighted");
  }

  public void Swallow()
  {
    StateMachine.ChangeState("_Default");
    TextMeshPro.text = "";
  }
}
