using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class UIObserver : MonoBehaviour, IObserver
{
  public Text ScoreText;

#region MonoBehaviour Methods
  private void Start()
  {
    ScoreSubject.Instance.RegisterObserver(this);
    ScoreText.text = string.Format("Score: {0}", ScoreSubject.Instance.Score);
  }

  private void OnDestroy()
  {
    ScoreSubject.Instance.UnregisterObserver(this);
  }
#endregion

#region Observer Pattern
  public void UpdateObserver()
  { 
    ScoreText.text = string.Format("Score: {0}", ScoreSubject.Instance.Score);
  }
#endregion
}