using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class ObserverCanvas : MonoBehaviour, IObserver
{
  public Text ScoreText;

#region MonoBehaviour Methods
  private void Start()
  {
    SubjectScoreManager.Instance.RegisterObserver(this);
    ScoreText.text = string.Format("Score: {0}", SubjectScoreManager.Instance.Score);
  }

  private void OnDestroy()
  {
    SubjectScoreManager.Instance.UnregisterObserver(this);
  }
#endregion

#region Observer Pattern
  public void UpdateObserver()
  { 
    ScoreText.text = string.Format("Score: {0}", SubjectScoreManager.Instance.Score);
  }
#endregion
}