
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

//Thread-Safe (Using lock)
public class SingletonTwo
{
    public static SingletonTwo _singletonTwo;
    private static readonly Object _lock = new Object();

    private SingletonTwo() { }

    public static SingletonTwo singletonTwo
    {
        get
        {
            lock (_lock)
            {
                if (_singletonTwo == null)
                {
                    _singletonTwo = new SingletonTwo();
                }
            }

            return _singletonTwo;
        }
    }
}