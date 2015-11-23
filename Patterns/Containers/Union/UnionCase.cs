using System;

namespace Patterns.Containers.Union
{
    /// <summary>
    /// Represents typed union case
    /// </summary>
    /// <typeparam name="T">Type of case</typeparam>
    public interface UnionCase<T> : IEquatable<UnionCase<T>>
    {
    }
}
