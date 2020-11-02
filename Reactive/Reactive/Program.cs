using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;

namespace Reactive
{
    class ReactiveExtension
    {
        public static void Main(string[] args)
        {

            var observableInstance = new DemoObservable();
            var observerInstance = new DemoObserver();
            var subscriptionHandle = observableInstance.Subscribe(observerInstance);

        }
    }
        public class DemoObserver : IObserver<int>
        {
            public void OnCompleted()
            {
                Console.WriteLine("Observable is done sending all the data.");
            }

            public void OnError(Exception error)
            {
                Console.WriteLine($"Observable failed with error: {error.Message}");
            }

            public void OnNext(int value)
            {
                Console.WriteLine($"Observable emitted : {value}");
            }
        }
    public class DemoObservable : IObservable<int>
    {
        public IDisposable Subscribe(IObserver<int> observer)
        {
            observer.OnNext(1);
            observer.OnNext(2);
            observer.OnNext(3);
            observer.OnNext(4);
            observer.OnNext(5);
            observer.OnCompleted();
            return Disposable.Empty;
        }
    }
    public interface IObservable<T>
    {
        IDisposable Subscribe(IObserver<T> observer);
    }
    
    
}
