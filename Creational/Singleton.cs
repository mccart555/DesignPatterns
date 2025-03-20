using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DesignPatterns.Creational;
// The Singleton pattern ensures a class has only one instance and provides a global point of access to it.
// Summary
//    Singleton:           Ensures a single instance of the class is created.
//    Private Constructor: Prevents instantiation from outside the class.
//    Static Instance:     Holds the single instance.
//    Thread-Safety:       Ensures that only one thread can create the instance at a time using lock.

// This implementation provides a robust and efficient way to ensure a single instance of the class is created, even in a multithreaded environment.
public class Singleton
{
    // Private static variable to hold the single instance
    private static Singleton? _instance;

    // Private constructor to prevent instantiation
    private Singleton()
    {
    }

    // Public static method to get the instance
    public static Singleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new Singleton();
            }
            return _instance;
        }
    }

    // Example method to demonstrate functionality
    public void DoSomething()
    {
        Console.WriteLine("Singleton instance is working!");
    }
}

public class ThreadSafeSingleton
{
    // Private static variable to hold the single instance
    private static ThreadSafeSingleton? _instance;

    // Lock object to synchronize threads
    private static readonly object _lock = new object();

    // Private constructor to prevent instantiation
    private ThreadSafeSingleton()
    {
    }

    // Public static method to get the instance
    public static ThreadSafeSingleton Instance
    {
        get
        {
            // Use double-checked locking to reduce the overhead of acquiring a lock
            if (_instance == null)
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new ThreadSafeSingleton();
                    }
                }
            }

            return _instance;
        }
    }

    // Example method to demonstrate functionality
    public void DoSomething()
    {
        Console.WriteLine("ThreadSafeSingleton instance is working!");
    }
}

// Key Points About Lock for Thread safety:
//   Lock Object: Always use a private object as the lock. Never use types or instances that are accessible from outside the class, such as this,
//                to avoid deadlocks and unintended behavior.
//   Scope:       Only the code inside the lock block is protected. Other parts of the code can still be accessed by multiple threads simultaneously.
//   Performance: Overusing lock can lead to performance bottlenecks.Be mindful of the granularity of your locking.
// By using the lock statement, you can ensure that your code operates correctly in a multithreaded environment, maintaining data integrity and
// preventing race conditions.