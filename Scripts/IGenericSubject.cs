public interface IGenericSubject<T> where T : class
{
  void RegisterObserver();
  void UnregisterObserver();
  void NotifyObservers();
}