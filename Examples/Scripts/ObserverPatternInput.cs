using UnityEngine;

public class ObserverPatternInput : MonoBehaviour
{
#region MonoBehaviour Methods
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow))
    {
      if (SubjectScoreManager.Instance != null) SubjectScoreManager.Instance.UpdateScore(10);
      if (GenericSubjectScoreManager.Instance != null) GenericSubjectScoreManager.Instance.UpdateScore(10);
    }
    else if (Input.GetKeyDown(KeyCode.DownArrow))
    {
      if (SubjectScoreManager.Instance != null) SubjectScoreManager.Instance.UpdateScore(-10);
      if (GenericSubjectScoreManager.Instance != null) GenericSubjectScoreManager.Instance.UpdateScore(-10);
    }
  }
#endregion
}