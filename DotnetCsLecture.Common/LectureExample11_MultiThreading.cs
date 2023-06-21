using DotnetCsLecture.Common.HelperFiles;

namespace DotnetCsLecture.Common;

public class LectureExample11_MultiThreading : ExampleBase, ILectureExample
{
    private object _obj = new object();
    private object _lock1 = new object();
    private object _lock2 = new object();
    
    public void ShowExample()
    {
        // Thread and Task
        Thread thread = new Thread(DoWork);
        thread.Start();

        Task task = Task.Run(DoWork);

        thread.Join();
        task.Wait();
        
        PrintSeparator();

        Thread threadWithLock = new Thread(DoWorkWithLock);
        threadWithLock.Start();

        Task taskWithLock = Task.Run(DoWorkWithLock);

        threadWithLock.Join();
        taskWithLock.Wait();
        
        PrintSeparator();
        
        ShowDeadlock();
    }

    private void DoWork()
    {
        Console.WriteLine("Starting...");
        
        Thread.Sleep(3000);
        
        Console.WriteLine("Completed!");
    }

    private void DoWorkWithLock()
    {
        Console.WriteLine("Starting...");

        lock(_obj)
        {
            Thread.Sleep(2000);
        }

        Console.WriteLine("Completed!");
    }

    private void ShowDeadlock()
    {
        Thread thread1 = new Thread(DoLockedWork1);
        Thread thread2 = new Thread(DoLockedWork2);

        thread1.Start();
        thread2.Start();

        thread1.Join();
        thread2.Join();
        
        Console.WriteLine("After deadlock");
    }

    private void DoLockedWork1()
    {
        lock (_lock1)
        {
            Console.WriteLine("Thread 1 acquired lock1");
            
            Thread.Sleep(1000);

            lock (_lock2)
            {
                Console.WriteLine("Thread 1 acquired lock2");
            }
        }
    }

    private void DoLockedWork2()
    {
        lock (_lock2)
        {
            Console.WriteLine("Thread 2 acquired lock1");
            
            Thread.Sleep(1000);

            lock (_lock1)
            {
                Console.WriteLine("Thread 2 acquired lock2");
            }
        }
    }
}