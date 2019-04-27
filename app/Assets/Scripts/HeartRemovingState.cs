using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;
using UnityEngine.UI;

public class HeartRemovingState : State
{
  public Image[] Images;
  public Color DesiredColor;
  public float AnimationTime = 1.0f;
  public AnimationCurve AnimationCurve;
  public GameObject Root;

  void OnEnable()
  {
    foreach (var image in Images)
    {
      Tween.Color(image, image.color, DesiredColor, AnimationTime, 0f, AnimationCurve, Tween.LoopType.None, null, OnCompleteCallback);
    }
  }

  void OnCompleteCallback()
  {
    Destroy(Root);
  }
}
