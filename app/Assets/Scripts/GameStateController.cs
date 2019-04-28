﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
  public HoleController[] HoleControllers;
  public HeartController[] HeartControllers;
  public SceneChanger WinSceneChanger;
  public SceneChanger RetrySceneChanger;
  private int currentRound = 0;
  private int currentHeartIndex = 0;

  void Start()
  {
    EventHub.Instance.OnBallSwallowed += OnBallSwallowed;
    StartCoroutine(WaitForEndOfFrameThenStartGame());
  }

  IEnumerator WaitForEndOfFrameThenStartGame()
  {
    yield return new WaitForEndOfFrame();
    ResetRound();
  }

  void ResetRound()
  {
    for (var i = 0; i < HoleControllers.Length; i++)
    {
      var holeController = HoleControllers[i];
      if (i == currentRound)
      {
        holeController.SetHoleNumber(i + 1);
        holeController.Highlight();
      }
      else
      {
        holeController.Reset();
      }
    }
    EventHub.Instance.ResetRequested();
  }

  void OnBallSwallowed(bool isHighlighted)
  {
    if (isHighlighted)
    {
      currentRound += 1;
      if (HasWon)
      {
        WinSceneChanger.ChangeScene();
      }
    }
    else
    {
      HeartControllers[currentHeartIndex].Remove();
      currentHeartIndex += 1;
      if (IsDead)
      {
        RetrySceneChanger.ChangeScene();
      }
    }
    ResetRound();
  }
  private bool IsDead => currentHeartIndex >= HeartControllers.Length;
  private bool HasWon => currentRound >= HoleControllers.Length;
}
