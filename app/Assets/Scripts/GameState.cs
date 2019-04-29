using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class GameState : State
{
  public DropLeversAction DropLeversAction;
  public RevealScreenAction RevealScreenAction;
  public Transform HolesRoot;

  void OnEnable()
  {
    RevealScreenAction.Act();
    var holes = HolesRoot.GetComponentsInChildren<HoleController>();
    foreach (var hole in holes)
    {
      hole.Reset();
    }
  }

  void OnDisable()
  {
    DropLeversAction.Act();
  }
}
