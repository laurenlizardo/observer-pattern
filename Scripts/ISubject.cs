public interface ISubject<T> where T : class
{
  void Register(T o);
  void Unregister(T o);
  void Notify();
}