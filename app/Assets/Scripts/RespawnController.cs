using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnController : MonoBehaviour
{
  public LeverLiftController[] LeverLiftControllers;
  public float DropDelay = 3.0f;
  public BallFactory BallFactory;

  private void Start()
  {
    EventHub.Instance.OnBallSwallowed += Respawn;
  }

  public void Respawn()
  {
    foreach (var leverLiftController in LeverLiftControllers)
    {
      leverLiftController.Drop();
    }

    StartCoroutine(WaitThenResetLevers());
  }

  private IEnumerator WaitThenResetLevers()
  {
    yield return new WaitForSeconds(DropDelay);

    BallFactory.Create();

    foreach (var leverLiftController in LeverLiftControllers)
    {
      leverLiftController.Ready();
    }
  }
}
