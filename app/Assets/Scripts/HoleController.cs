using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class HoleController : MonoBehaviour
{
  public StateMachine StateMachine;

  public void Highlight()
  {
    StateMachine.ChangeState("_Highlighted");
  }
}
