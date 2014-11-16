using System;

namespace Patterns.Containers
{
    public interface None { }
    public interface Some { }

    public abstract class Option
    {
        public static bool operator ==(Option left, Option right)
        {
            return !ReferenceEquals(left, null) && !ReferenceEquals(right, null) && left.Equals(right);
        }

        public static bool operator !=(Option left, Option right)
        {
            return !(left == right);
        }
    }

    public abstract class Option<T> : Option
    {
        public abstract bool HasValue { get; }

        public abstract T Value { get; }

        public static implicit operator Option<T>(T value)
        {
            return value == null ? (Option<T>) new None<T>() : new Some<T>(value);
        }

        public static explicit operator T(Option<T> value)
        {
            return value.Value;
        }
    }

    public sealed class Some<T> : Option<T>, Some
    {
        private readonly T _value;

        public Some(T value)
        {
            _value = value;
        }

        public override bool HasValue
        {
            get { return true; }
        }

        public override T Value
        {
            get { return _value; }
        }

        public override bool Equals(object obj)
        {
            var otherValue = obj as Some<T>;
            return !ReferenceEquals(otherValue, null) && _value.Equals(otherValue.Value);
        }

        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }
    }

    public sealed class None<T> : Option<T>, None
    {
        public override bool HasValue
        {
            get { return false; }
        }

        public override T Value
        {
            get { throw new NoneValueAccessException(); }
        }

        public override bool Equals(object obj)
        {
            return obj is None;
        }

        public override int GetHashCode()
        {
            return 0;
        }
    }

    public class NoneValueAccessException : Exception
    {
        public override string Message
        {
            get { return "None value attempt"; }
        }
    }
}