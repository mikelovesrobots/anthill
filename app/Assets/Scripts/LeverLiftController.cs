using System.Collections;
using System.Collections.Generic;
using Pixelplacement;
using UnityEngine;

public class LeverLiftController : MonoBehaviour
{
  public float Speed = 2.0f;
  public Rigidbody2D Rigidbody2D;
  public StateMachine StateMachine;

  public float Y => transform.position.y;

  public void Drop()
  {
    StateMachine.ChangeState("_Dropping");
  }

  public void Ready()
  {
    StateMachine.ChangeState("_Resetting");
  }

  public void Step(float desiredDirection, float minBounds, float maxBounds)
  {
    var delta = desiredDirection * Speed * Time.deltaTime;
    var delta2D = new Vector2(0, delta);
    var desiredPosition = Rigidbody2D.position + delta2D;
    if (desiredPosition.y < minBounds)
    {
      desiredPosition.y = minBounds;
    }
    if (desiredPosition.y > maxBounds)
    {
      desiredPosition.y = maxBounds;
    }

    Rigidbody2D.MovePosition(desiredPosition);
  }
}
