using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class LeverEffectorResettingState : State
{
  public LeverLiftController LeverLiftController;
  public float MinBounds = -6;
  public float DesiredY = -4;
  public float MaxBounds = 6;

  void Update()
  {
    if (LeverLiftController.Y < DesiredY)
    {
      LeverLiftController.Step(1.0f, MinBounds, MaxBounds);
    }
    else
    {
      ChangeState("_Controllable");
    }
  }
}
