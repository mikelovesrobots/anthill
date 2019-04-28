using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class RevealWindowState : State
{
  public ScreensController ScreensController;
  public string Name;

  void OnEnable()
  {
    ScreensController.Reveal(Name);
  }
}
