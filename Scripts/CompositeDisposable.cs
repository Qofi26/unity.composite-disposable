#nullable enable

using System;
using System.Collections;
using System.Collections.Generic;

namespace QModules.Extensions
{
    public sealed class CompositeDisposable : ICompositeDisposable
    {
        public int Count => _disposables.Count;
        public bool IsReadOnly => false;

        private readonly HashSet<IDisposable> _disposables = new();

        public void Dispose()
        {
            foreach (var disposable in _disposables)
            {
                disposable.Dispose();
            }

            Clear();
        }

        public IEnumerator<IDisposable> GetEnumerator()
        {
            var result = new HashSet<IDisposable>(_disposables.Count);
            foreach (var disposable in _disposables)
            {
                result.Add(disposable);
            }

            return result.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(IDisposable item)
        {
            _disposables.Add(item);
        }

        public void Clear()
        {
            _disposables.Clear();
        }

        public bool Contains(IDisposable item)
        {
            return _disposables.Contains(item);
        }

        public void CopyTo(IDisposable[] array, int arrayIndex)
        {
            _disposables.CopyTo(array, arrayIndex);
        }

        public bool Remove(IDisposable item)
        {
            return _disposables.Remove(item);
        }
    }
}
