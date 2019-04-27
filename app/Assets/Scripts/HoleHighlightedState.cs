using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class HoleHighlightedState : State
{
  public Renderer[] Renderers;
  public Color HighlightedColor;
  public float AnimationTime = 1.0f;
  public AnimationCurve AnimationCurve;

  void OnEnable()
  {
    foreach (var renderer in Renderers)
    {
      Tween.Color(renderer, renderer.material.color, HighlightedColor, AnimationTime, 0f, AnimationCurve, Tween.LoopType.None);
    }
  }
}
