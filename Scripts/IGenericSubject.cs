public interface IGenericSubject<T> where T : class
{
  void RegisterObserver(T o);
  void UnregisterObserver(T o);
  void NotifyObservers();
}