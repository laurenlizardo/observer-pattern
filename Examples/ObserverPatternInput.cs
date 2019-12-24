using UnityEngine;

public class ObserverPatternInput : MonoBehaviour
{
#region MonoBehaviour Methods
  private void Update()
  {
    if (Input.GetKeyDown(KeyCode.UpArrow)) ScoreSubject.Instance.UpdateScore(10);
    else if (Input.GetKeyDown(KeyCode.DownArrow)) ScoreSubject.Instance.UpdateScore(-10);
  }
#endregion
}