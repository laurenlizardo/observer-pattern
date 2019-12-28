using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubjectScoreManager : MonoBehaviour, ISubject
{
  private static SubjectScoreManager _instance;
  public static SubjectScoreManager Instance => _instance;

  public int Score;

#region Singleton Pattern
  private void Awake()
  {
    if (_instance == null) _instance = this;
    else Destroy(gameObject);
  }
#endregion

#region Private Methods
  public void UpdateScore(int points)
  {
    Score += points;
    NotifyObservers();
  }
#endregion

#region Observer Pattern
  private List<IObserver> _observers = new List<IObserver>();

  public void RegisterObserver(IObserver o)
  {
    if (!_observers.Contains(o)) _observers.Add(o);
  }

  public void UnregisterObserver(IObserver o)
  {
    if (_observers.Contains(o)) _observers.Remove(o);
  }

  public void NotifyObservers()
  {
    foreach (IObserver o in _observers)
    {
      o.UpdateObserver();
    }
  }
#endregion
}