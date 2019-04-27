using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class BallSwallowedState : State
{
  public Rigidbody2D Rigidbody2D;
  public Transform Root;
  public Renderer RendererTarget;
  public float ScaleTime = 0.25f;
  [SerializeField, Layer] public int LeverAvoidingLayer;

  void OnEnable()
  {
    Rigidbody2D.isKinematic = true;
    Root.gameObject.layer = LeverAvoidingLayer;
    Tween.LocalScale(Root, Vector3.one, Vector3.zero, ScaleTime, 0, Tween.EaseIn, Tween.LoopType.None, null, HandleTweenFinished);
    Tween.Color(RendererTarget, new Color(1, 1, 1, 1), new Color(1, 1, 1, 0), ScaleTime, 0f, Tween.EaseIn, Tween.LoopType.None);
  }

  private void HandleTweenFinished()
  {
    Destroy(Root.gameObject);
  }
}
