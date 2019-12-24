using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestObserver : MonoBehaviour, IObserver
{
  private TestObserver _instance;
  public TestObserver Instance => _instance;

  public void UpdateObserver() { }
}
