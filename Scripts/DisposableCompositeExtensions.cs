#nullable enable

using System;
using System.Collections.Generic;

namespace QModules.Extensions
{
    public static class DisposableCompositeExtensions
    {
        public static T AddTo<T>(this T? disposable, ICollection<IDisposable> composite) where T : IDisposable
        {
            if (disposable != null)
            {
                composite.Add(disposable);
            }

            return disposable!;
        }
    }
}
