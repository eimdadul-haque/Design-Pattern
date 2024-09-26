
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

//Thread-Safe Singleton with Double-Check Locking

public class SingletonThree
{
    public static SingletonThree _singletonThree;
    private static readonly Object _lock = new Object();

    private SingletonThree() { }

    public static SingletonThree singletonThree
    {
        get
        {
            if (_singletonThree == null)
            {
                lock (_lock)
                {
                    if (_singletonThree == null)
                    {
                        _singletonThree = new SingletonThree();
                    }
                }
            }

            return _singletonThree;
        }
    }
}

//Lazy Initialization

public class SingletonFour
{
    public static readonly Lazy<SingletonFour> _singletonFour = new Lazy<SingletonFour>(() => new SingletonFour());

    private SingletonFour() { }

    public static SingletonFour singletonFour
    {
        get
        {
            return _singletonFour.Value;
        }
    }
}

//Eager Initialization

public class SingletonFive
{
    public static readonly SingletonFive _singletonFive = new SingletonFive();

    private SingletonFive() { }

    public static SingletonFive singletonFive
    {
        get
        {
            return _singletonFive;
        }
    }
}