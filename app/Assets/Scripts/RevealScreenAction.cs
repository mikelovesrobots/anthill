using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevealScreenAction : MonoBehaviour
{
  public ScreensController ScreensController;
  public string Name;

  public void Act()
  {
    ScreensController.Reveal(Name);
  }
}
