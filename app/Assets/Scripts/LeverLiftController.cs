using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LeverLiftController : MonoBehaviour
{
  public string AxisName = "VerticalLeft";
  public int MinBounds = -4;
  public int MaxBounds = 4;
  public float Speed = 2.0f;
  public Rigidbody2D Rigidbody2D;
  public float ResetAnimationTime = 2.0f;
  public bool IsLive = true;

  public void Reset()
  {
    IsLive = false;
    StartCoroutine(WaitAndThenLive());
  }

  IEnumerator WaitAndThenLive()
  {
    yield return new WaitForSeconds(ResetAnimationTime);
    IsLive = true;
  }

  void Update()
  {
    var delta = (IsLive ? -Input.GetAxis(AxisName) : -1) * Speed * Time.deltaTime;
    var delta2D = new Vector2(0, delta);
    var desiredPosition = Rigidbody2D.position + delta2D;
    if (desiredPosition.y < MinBounds)
    {
      desiredPosition.y = MinBounds;
    }
    if (desiredPosition.y > MaxBounds)
    {
      desiredPosition.y = MaxBounds;
    }

    Rigidbody2D.MovePosition(desiredPosition);
  }
}
