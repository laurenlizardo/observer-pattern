using System.Collections;
using UnityEngine;
using UnityEngine.UI;

public class GenericObserverCanvas : MonoBehaviour, IGenericObserver<GenericSubjectScoreManager>
{
  public Text ScoreText;

#region MonoBehaviour Methods
  private void Start()
  {
    GenericSubjectScoreManager.Instance.RegisterObserver(this);
    ScoreText.text = string.Format("Score: {0}", GenericSubjectScoreManager.Instance.Score);
  }

  private void OnDestroy()
  {
    GenericSubjectScoreManager.Instance.UnregisterObserver(this);
  }
#endregion

#region Observer Pattern
  public void UpdateObserver()
  { 
    ScoreText.text = string.Format("Score: {0}", GenericSubjectScoreManager.Instance.Score);
  }
#endregion
}