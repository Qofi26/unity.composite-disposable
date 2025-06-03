#nullable enable

using System;
using System.Collections.Generic;

namespace QModules.Extensions
{
    public interface ICompositeDisposable : ICollection<IDisposable>, IDisposable
    {
    }
}
