# Use one IDisposable to dispose collection of IDisposable objects

## Install via UPM (using Git URL) or use release package

````
https://github.com/Qofi26/unity.composite-disposable.git
````

## Example Usage

```csharp
    public class Element : IDisposable
    {
        public void Dispose() { }
    }

    public class Example
    {
        private readonly ICompositeDisposable _disposable = new CompositeDisposable();

        private void Initialize()
        {
            // Example of adding a disposable to the composite
            var element1 = Create();
            _disposable.Add(element1);

            var element2 = Create();
            _disposable.Add(element2);

            // You can use extension methods for convenience
            Create().AddTo(_disposable);
            Create().AddTo(_disposable);
            Create().AddTo(_disposable);
        }

        private void Deinitialize()
        {
            // Dispose of all elements in the composite
            _disposable.Dispose();
        }

        private Element Create()
        {
            return new Element();
        }
    }

```
