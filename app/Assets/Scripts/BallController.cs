using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Pixelplacement;

public class BallController : MonoBehaviour
{
  public Rigidbody2D Rigidbody2D;
  public Renderer RendererTarget;
  public float ScaleTime = 0.25f;
  [SerializeField, Layer] public int LeverAvoidingLayer;

  public void Swallow(Transform hole)
  {
    Rigidbody2D.isKinematic = true;
    gameObject.layer = LeverAvoidingLayer;
    foreach (var childTransform in GetComponentsInChildren<Transform>(true))
    {
      childTransform.gameObject.layer = LeverAvoidingLayer;
    }

    Tween.Position(transform, hole.position, ScaleTime, 0, Tween.EaseIn, Tween.LoopType.None);
    Tween.LocalScale(transform, Vector3.one, Vector3.zero, ScaleTime, 0, Tween.EaseIn, Tween.LoopType.None, null, HandleTweenFinished);
    Tween.Color(RendererTarget, new Color(1, 1, 1, 1), new Color(1, 1, 1, 0), ScaleTime, 0f, Tween.EaseIn, Tween.LoopType.None);
  }

  private void HandleTweenFinished()
  {
    Destroy(gameObject);
  }
}
