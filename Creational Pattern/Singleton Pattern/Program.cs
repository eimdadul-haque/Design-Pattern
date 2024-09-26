
//Non-Thread-Safe
public class SingletonOne
{
    public static SingletonOne _singletonOne;
    private SingletonOne() { }

    public static SingletonOne Instance
    {
        get
        {
            if (_singletonOne == null)
            {
                _singletonOne = new SingletonOne();
            }

            return _singletonOne;
        }
    }
}
