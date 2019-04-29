using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class ActionRunningState : State
{
  public ActionBase[] Actions;

  void OnEnable()
  {
    foreach (var action in Actions)
    {
      action.Act();
    }
  }
}
