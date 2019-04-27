using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleHighlightTest : MonoBehaviour
{
  public HoleController HoleController;

  void Start()
  {
    HoleController.Highlight();
  }
}
