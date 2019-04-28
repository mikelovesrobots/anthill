using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class GameState : State
{
  public DropLeversAction DropLeversAction;
  public RevealScreenAction RevealScreenAction;

  void OnEnable()
  {
    RevealScreenAction.Act();
  }

  void OnDisable()
  {
    DropLeversAction.Act();
  }
}
