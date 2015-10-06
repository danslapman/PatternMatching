using System;
// ReSharper disable InconsistentNaming

namespace Patterns.Containers
{
    public interface None { }
    public interface Some { }

#pragma warning disable 660,661
    public abstract class Option
#pragma warning restore 660,661
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

        public abstract T GetOrElse(T defaultValue);
        public abstract Option<TR> Map<TR>(Func<T, TR> func);
        public abstract Option<TR> FlatMap<TR>(Func<T, Option<TR>> func);
    }

    public sealed class Some<T> : Option<T>, Some
    {
        private readonly T _value;

        public Some(T value)
        {
            _value = value;
        }

        public override bool HasValue => true;

        public override T Value => _value;

        public override T GetOrElse(T defaultValue)
        {
            return _value;
        }

        public override Option<TR> Map<TR>(Func<T, TR> func)
        {
            return func(_value);
        }

        public override Option<TR> FlatMap<TR>(Func<T, Option<TR>> func)
        {
            return func(_value);
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

        public override string ToString()
        {
            return $"Some({Value})";
        }
    }

    public sealed class None<T> : Option<T>, None
    {
        public override bool HasValue => false;

        public override T Value
        {
            get { throw new NoneValueAccessException(); }
        }

        public override T GetOrElse(T defaultValue)
        {
            return defaultValue;
        }

        public override Option<TR> Map<TR>(Func<T, TR> func)
        {
            return new None<TR>();
        }

        public override Option<TR> FlatMap<TR>(Func<T, Option<TR>> func)
        {
            return new None<TR>();
        }

        public override bool Equals(object obj)
        {
            return obj is None;
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return "None";
        }
    }

    public class NoneValueAccessException : Exception
    {
        public override string Message => "None value attempt";
    }
}