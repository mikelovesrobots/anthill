using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameStateController : MonoBehaviour
{
  public HoleController[] HoleControllers;
  public HeartController[] HeartControllers;
  public StateMachineChanger WinScreenChanger;
  public StateMachineChanger LoseScreenChanger;
  public float DwellTimeBeforeChangingScenes = 1.5f;
  private int currentRound = 0;
  private int currentHeartIndex = 0;

  void OnEnable()
  {
    EventHub.Instance.OnBallSwallowed += OnBallSwallowed;
    StartCoroutine(WaitForEndOfFrameThenStartGame());
  }

  void OnDisable()
  {
    EventHub.Instance.OnBallSwallowed -= OnBallSwallowed;
  }

  IEnumerator WaitForEndOfFrameThenStartGame()
  {
    yield return new WaitForEndOfFrame();
    currentRound = 0;
    currentHeartIndex = 0;
    foreach (var heart in HeartControllers)
    {
      heart.Show();
    }

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
        StartCoroutine(WaitThenChangeScene(WinScreenChanger));
      }
      else
      {
        ResetRound();
      }
    }
    else
    {
      HeartControllers[currentHeartIndex].Hide();
      currentHeartIndex += 1;
      if (IsDead)
      {
        StartCoroutine(WaitThenChangeScene(LoseScreenChanger));
      }
      else
      {
        ResetRound();
      }
    }
  }

  IEnumerator WaitThenChangeScene(StateMachineChanger sceneChanger)
  {
    yield return new WaitForSeconds(DwellTimeBeforeChangingScenes);
    sceneChanger.Change();
  }
  private bool IsDead => currentHeartIndex >= HeartControllers.Length;
  private bool HasWon => currentRound >= HoleControllers.Length;
}
