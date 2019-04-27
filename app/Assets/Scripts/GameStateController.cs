using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
  void Start()
  {
    EventHub.Instance.OnBallSwallowed += OnBallSwallowed;
    StartCoroutine(WaitForEndOfFrameThenStartGame());
  }

  IEnumerator WaitForEndOfFrameThenStartGame()
  {
    yield return new WaitForEndOfFrame();
    EventHub.Instance.ResetRequested();
  }

  void OnBallSwallowed()
  {
    EventHub.Instance.ResetRequested();
  }
}
