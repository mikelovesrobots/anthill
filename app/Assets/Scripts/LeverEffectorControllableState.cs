using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class LeverEffectorControllableState : State
{
  public string AxisName = "VerticalLeft";
  public LeverLiftController LeverLiftController;
  public float MinBounds = -4;
  public float MaxBounds = 4;

  void Update()
  {
    LeverLiftController.Step(-Input.GetAxis(AxisName), MinBounds, MaxBounds);
  }
}
