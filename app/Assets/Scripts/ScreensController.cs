using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class ScreensController : MonoBehaviour
{
  public Transform[] Screens;
  public Vector3 OnscreenPosition = Vector3.zero;
  public Vector3 OffscreenPosition;
  public float AnimationTime = 1f;
  public AnimationCurve AnimationCurve;

  private void Start()
  {
    foreach (var screen in Screens)
    {
      screen.gameObject.SetActive(true);
      screen.transform.localPosition = OffscreenPosition;
    }
  }

  public void Reveal(string name)
  {
    foreach (var screen in Screens)
    {
      if (screen.gameObject.name == name)
      {
        Tween.LocalPosition(screen, OnscreenPosition, AnimationTime, 0f, AnimationCurve);
      }
      else
      {
        Tween.LocalPosition(screen, OffscreenPosition, AnimationTime, AnimationTime, AnimationCurve);
      }
    }
  }
}
