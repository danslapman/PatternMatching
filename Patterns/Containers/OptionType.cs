using System;
#pragma warning disable 660,661
// ReSharper disable InconsistentNaming

namespace Patterns.Containers
{
    /// <summary>
    /// Marker interface for `None` type
    /// </summary>
    public interface None { }

    /// <summary>
    /// Marker interface for `Some` type
    /// </summary>
    public interface Some { }

    /// <summary>
    /// Non-generic base `Option` class
    /// </summary>
    public abstract class Option
    {
        /// <summary>
        /// Checks equality of `Option` instances
        /// </summary>
        public static bool operator ==(Option left, Option right)
        {
            return !ReferenceEquals(left, null) && !ReferenceEquals(right, null) && left.Equals(right);
        }

        /// <summary>
        /// Checks inequality of `Option` instances
        /// </summary>
        public static bool operator !=(Option left, Option right)
        {
            return !(left == right);
        }

        /// <summary>
        /// Wraps instance of T into Some&lt;T&gt;
        /// </summary>
        /// <typeparam name="T">instance to wrap</typeparam>
        public static Option<T> Some<T>(T value)
        {
            return new Some<T>(value);
        }

        /// <summary>
        /// Return None&lt;T&gt;
        /// </summary>
        public static Option<T> None<T>()
        {
            return new None<T>();
        }
    }

    /// <summary>
    /// Generic base `Option` class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class Option<T> : Option
    {
        /// <summary>
        /// Indicates if instance contains value
        /// </summary>
        public abstract bool HasValue { get; }

        /// <summary>
        /// Returns containing value
        /// </summary>
        public abstract T Value { get; }

        /// <summary>
        /// Converts T value to Option&lt;T&gt;
        /// </summary>
        /// <param name="value">value to convert</param>
        public static implicit operator Option<T>(T value)
        {
            return value == null ? (Option<T>) new None<T>() : new Some<T>(value);
        }

        /// <summary>
        /// Converts Option&lt;T&gt; into T
        /// </summary>
        /// <param name="value"></param>
        public static explicit operator T(Option<T> value)
        {
            return value.Value;
        }

        /// <summary>
        /// Gets value from Option&lt;T&gt; or returns default
        /// </summary>
        /// <param name="defaultValue">default value to return</param>
        /// <returns></returns>
        public abstract T GetOrElse(T defaultValue);

        /// <summary>
        /// Maps a function
        /// </summary>
        /// <param name="func">function</param>
        public abstract Option<TR> Map<TR>(Func<T, TR> func);

        /// <summary>
        /// FlatMaps a function
        /// </summary>
        /// <param name="func">function</param>
        public abstract Option<TR> FlatMap<TR>(Func<T, Option<TR>> func);

        /// <summary>
        /// Converts current Option&lt;&gt; instance into Result instance
        /// </summary>
        public abstract Result<Some<T>, None<T>> ToResult();

        /// <summary>
        /// Converts current Option&lt;&gt; instance into Result instance
        /// </summary>
        /// <typeparam name="TSucc">Success type</typeparam>
        /// <typeparam name="TErr">Error type</typeparam>
        /// <param name="fs">Function to map on `Some` value</param>
        /// <param name="fn">Function that emits `TErr`</param>
        public abstract Result<TSucc, TErr> ToResult<TSucc, TErr>(Func<T, TSucc> fs, Func<TErr> fn);
    }

    /// <summary>
    /// Represents `Some` case of Option
    /// </summary>
    public sealed class Some<T> : Option<T>, Some
    {
        private readonly T _value;

        /// <summary>
        /// Initializes new Some
        /// </summary>
        public Some(T value)
        {
            _value = value;
        }

        /// <summary>
        /// Indicates if instance contains value
        /// </summary>
        public override bool HasValue => true;

        /// <summary>
        /// Returns containing value
        /// </summary>
        public override T Value => _value;

        /// <summary>
        /// Gets value from Option&lt;T&gt; or returns default
        /// </summary>
        /// <param name="defaultValue">default value to return</param>
        public override T GetOrElse(T defaultValue)
        {
            return _value;
        }

        /// <summary>
        /// Maps a function
        /// </summary>
        /// <param name="func">function</param>
        public override Option<TR> Map<TR>(Func<T, TR> func)
        {
            return func(_value);
        }

        /// <summary>
        /// FlatMaps a function
        /// </summary>
        /// <param name="func">function</param>
        public override Option<TR> FlatMap<TR>(Func<T, Option<TR>> func)
        {
            return func(_value);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object
        /// </summary>
        public override bool Equals(object obj)
        {
            var otherValue = obj as Some<T>;
            return !ReferenceEquals(otherValue, null) && _value.Equals(otherValue.Value);
        }

        /// <summary>
        /// Serves as the default hash function
        /// </summary>
        public override int GetHashCode()
        {
            return _value.GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        public override string ToString()
        {
            return $"Some({Value})";
        }

        /// <summary>
        /// Converts current Option&lt;&gt; instance into Result instance
        /// </summary>
        public override Result<Some<T>, None<T>> ToResult()
        {
            return this;
        }

        /// <summary>
        /// Converts current Option&lt;&gt; instance into Result instance
        /// </summary>
        /// <typeparam name="TSucc">Success type</typeparam>
        /// <typeparam name="TErr">Error type</typeparam>
        /// <param name="fs">Function to map on `Some` value</param>
        /// <param name="fn">Function that emits `TErr`</param>
        public override Result<TSucc, TErr> ToResult<TSucc, TErr>(Func<T, TSucc> fs, Func<TErr> fn)
        {
            return new Success<TSucc, TErr>(fs(Value));
        }
    }

    /// <summary>
    /// Represents `None` case of option
    /// </summary>
    public sealed class None<T> : Option<T>, None
    {
        /// <summary>
        /// Indicates if instance contains value
        /// </summary>
        public override bool HasValue => false;

        /// <summary>
        /// Returns containing value
        /// </summary>
        public override T Value
        {
            get { throw new NoneValueAccessException(); }
        }

        /// <summary>
        /// Gets value from Option&lt;T&gt; or returns default
        /// </summary>
        /// <param name="defaultValue">default value to return</param>
        public override T GetOrElse(T defaultValue)
        {
            return defaultValue;
        }

        /// <summary>
        /// Maps a function
        /// </summary>
        /// <param name="func">function</param>
        public override Option<TR> Map<TR>(Func<T, TR> func)
        {
            return new None<TR>();
        }

        /// <summary>
        /// FlatMaps a function
        /// </summary>
        /// <param name="func">function</param>
        public override Option<TR> FlatMap<TR>(Func<T, Option<TR>> func)
        {
            return new None<TR>();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the current object
        /// </summary>
        public override bool Equals(object obj)
        {
            return obj is None;
        }

        /// <summary>
        /// Serves as the default hash function
        /// </summary>
        public override int GetHashCode()
        {
            return 0;
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        public override string ToString()
        {
            return "None";
        }

        /// <summary>
        /// Converts current Option&lt;&gt; instance into Result instance
        /// </summary>
        public override Result<Some<T>, None<T>> ToResult()
        {
            return this;
        }

        /// <summary>
        /// Converts current Option&lt;&gt; instance into Result instance
        /// </summary>
        /// <typeparam name="TSucc">Success type</typeparam>
        /// <typeparam name="TErr">Error type</typeparam>
        /// <param name="fs">Function to map on `Some` value</param>
        /// <param name="fn">Function that emits `TErr`</param>
        public override Result<TSucc, TErr> ToResult<TSucc, TErr>(Func<T, TSucc> fs, Func<TErr> fn)
        {
            return new Failure<TSucc, TErr>(fn());
        }
    }

    /// <summary>
    /// Represents error that occurs during getting value of None instance
    /// </summary>
    public class NoneValueAccessException : Exception
    {
        /// <summary>
        /// Error message
        /// </summary>
        public override string Message => "None value attempt";
    }
}