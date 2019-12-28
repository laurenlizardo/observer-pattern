using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GenericSubjectScoreManager : MonoBehaviour, IGenericSubject<GenericObserverCanvas>
{
  private static GenericSubjectScoreManager _instance;
  public static GenericSubjectScoreManager Instance => _instance;

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
  private List<GenericObserverCanvas> _observers = new List<GenericObserverCanvas>();

  public void RegisterObserver(GenericObserverCanvas o)
  {
    if (!_observers.Contains(o)) _observers.Add(o);
  }

  public void UnregisterObserver(GenericObserverCanvas o)
  {
    if (_observers.Contains(o)) _observers.Remove(o);
  }

  public void NotifyObservers()
  {
    foreach (GenericObserverCanvas o in _observers)
    {
      o.UpdateObserver();
    }
  }
#endregion
}