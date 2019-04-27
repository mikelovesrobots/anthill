using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class LeverEffectorDroppingState : State
{
  public LeverLiftController LeverLiftController;
  public float MinBounds = -6;
  public float MaxBounds = 6;

  void Update()
  {
    LeverLiftController.Step(-1, MinBounds, MaxBounds);
  }
}
