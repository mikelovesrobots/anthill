using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class HoleResizeState : State
{
  public Transform Root;
  public float AnimationTime = 1.0f;
  public AnimationCurve AnimationCurve;
  public float TargetSize = 0.5f;

  void OnEnable()
  {
    Tween.LocalScale(Root, Vector3.one * TargetSize, AnimationTime, 0, AnimationCurve);
  }
}
