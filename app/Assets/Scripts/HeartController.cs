using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class HeartController : MonoBehaviour
{
  public StateMachine StateMachine;

  public void Remove()
  {
    StateMachine.ChangeState("_Removing");
  }
}
