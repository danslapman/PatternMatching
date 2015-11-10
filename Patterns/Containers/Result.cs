using System;
// ReSharper disable InconsistentNaming
// ReSharper disable TypeParameterCanBeVariant

namespace Patterns.Containers
{
    /// <summary>
    /// Marker interface for `Success` type
    /// </summary>
    public interface Success { }

    /// <summary>
    /// Marker interface for `Failure` type
    /// </summary>
    public interface Failure { }

    /// <summary>
    /// Base interface for typed Success
    /// </summary>
    public interface Success<TSucc> : Success
    {
        /// <summary>
        /// Success value
        /// </summary>
        TSucc Value { get; }
    }

    /// <summary>
    /// Base interface for typed Error
    /// </summary>
    /// <typeparam name="TErr"></typeparam>
    public interface Failure<TErr> : Failure
    {
        /// <summary>
        /// Error value
        /// </summary>
        TErr Error { get; }
    }

    /// <summary>
    /// Base class for Result
    /// </summary>
    /// <typeparam name="TSucc">Success type</typeparam>
    /// <typeparam name="TErr">Error type</typeparam>
    public abstract class Result<TSucc, TErr>
    {
        /// <summary>
        /// Indicates if current value is success
        /// </summary>
        public abstract bool IsSuccess { get; }

        /// <summary>
        /// Indicates if current value if error
        /// </summary>
        public abstract bool IsFailure { get; }

        /// <summary>
        /// Maps a function
        /// </summary>
        public abstract Result<TRes, TErr> Map<TRes>(Func<TSucc, TRes> f);

        /// <summary>
        /// FlatMaps a function
        /// </summary>
        public abstract Result<TRes, TErr> FlatMap<TRes>(Func<TSucc, Result<TRes, TErr>> f);

        /// <summary>
        /// Maps a function to an error case
        /// </summary>
        public abstract Result<TSucc, TRes> MapError<TRes>(Func<TErr, TRes> f);

        /// <summary>
        /// FlatMaps a function to an error case
        /// </summary>
        public abstract Result<TSucc, TRes> FlatMapError<TRes>(Func<TErr, Result<TSucc, TRes>> f); 

        /// <summary>
        /// Converts current object to optional value
        /// </summary>
        public abstract Option<TSucc> ToOption();

        /// <summary>
        /// Converts an instance of `Success` type to Result
        /// </summary>
        public static implicit operator Result<TSucc, TErr>(TSucc instance)
        {
            return new Success<TSucc, TErr>(instance);
        }

        /// <summary>
        /// Convers an instance of `Failure` type to Result
        /// </summary>
        public static implicit operator Result<TSucc, TErr>(TErr instance)
        {
            return new Failure<TSucc, TErr>(instance);
        }
    }

    /// <summary>
    /// Represents `Success` case of Result
    /// </summary>
    /// <typeparam name="TSucc">Success type</typeparam>
    /// <typeparam name="TErr">Error type</typeparam>
    public sealed class Success<TSucc, TErr> : Result<TSucc, TErr>, Success<TSucc>
    {
        /// <summary>
        /// Success value
        /// </summary>
        public TSucc Value { get; }

        /// <summary>
        /// Initializes a new Success instance
        /// </summary>
        public Success(TSucc value)
        {
            Value = value;
        }

        /// <summary>
        /// Indicates if current value is success
        /// </summary>
        public override bool IsSuccess => true;

        /// <summary>
        /// Indicates if current value if error
        /// </summary>
        public override bool IsFailure => false;

        /// <summary>
        /// Maps a function
        /// </summary>
        public override Result<TRes, TErr> Map<TRes>(Func<TSucc, TRes> f)
        {
            return f(Value);
        }

        /// <summary>
        /// FlatMaps a function
        /// </summary>
        public override Result<TRes, TErr> FlatMap<TRes>(Func<TSucc, Result<TRes, TErr>> f)
        {
            return f(Value);
        }

        /// <summary>
        /// Maps a function to an error case
        /// </summary>
        public override Result<TSucc, TRes> MapError<TRes>(Func<TErr, TRes> f)
        {
            return Value;
        }

        /// <summary>
        /// FlatMaps a function to an error case
        /// </summary>
        public override Result<TSucc, TRes> FlatMapError<TRes>(Func<TErr, Result<TSucc, TRes>> f)
        {
            return Value;
        }

        /// <summary>
        /// Converts current object to optional value
        /// </summary>
        public override Option<TSucc> ToOption()
        {
            return new Some<TSucc>(Value);
        }

        /// <summary>
        /// Determines whether the specified object is equal to the specified object
        /// </summary>
        public override bool Equals(object obj)
        {
            var success = obj as Success<TSucc, TErr>;
            return success != null && Value.Equals(success.Value);
        }

        /// <summary>
        /// Serves as the default hash function
        /// </summary>
        public override int GetHashCode()
        {
            return Value.GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        public override string ToString()
        {
            return $"Success({Value})";
        }
    }

    /// <summary>
    /// Represents `Failure` case of Result
    /// </summary>
    /// <typeparam name="TSucc">Success type</typeparam>
    /// <typeparam name="TErr">Error type</typeparam>
    public sealed class Failure<TSucc, TErr> : Result<TSucc, TErr>, Failure<TErr>
    {
        /// <summary>
        /// Error value
        /// </summary>
        public TErr Error { get; }

        /// <summary>
        /// Initializes a new Success instance
        /// </summary>
        public Failure(TErr error)
        {
            Error = error;
        }

        /// <summary>
        /// Indicates if current value is success
        /// </summary>
        public override bool IsSuccess => false;

        /// <summary>
        /// Indicates if current value if error
        /// </summary>
        public override bool IsFailure => true;

        /// <summary>
        /// Maps a function
        /// </summary>
        public override Result<TRes, TErr> Map<TRes>(Func<TSucc, TRes> f)
        {
            return Error;
        }

        /// <summary>
        /// FlatMaps a function
        /// </summary>
        public override Result<TRes, TErr> FlatMap<TRes>(Func<TSucc, Result<TRes, TErr>> f)
        {
            return Error;
        }

        /// <summary>
        /// Maps a function to an error case
        /// </summary>
        public override Result<TSucc, TRes> MapError<TRes>(Func<TErr, TRes> f)
        {
            return f(Error);
        }

        /// <summary>
        /// FlatMaps a function to an error case
        /// </summary>
        public override Result<TSucc, TRes> FlatMapError<TRes>(Func<TErr, Result<TSucc, TRes>> f)
        {
            return f(Error);
        }

        /// <summary>
        /// Converts current object to optional value
        /// </summary>
        public override Option<TSucc> ToOption()
        {
            return new None<TSucc>();
        }

        /// <summary>
        /// Determines whether the specified object is equal to the specified object
        /// </summary>
        public override bool Equals(object obj)
        {
            var failure = obj as Failure<TSucc, TErr>;
            return failure != null && Error.Equals(failure.Error);
        }

        /// <summary>
        /// Serves as the default hash function
        /// </summary>
        public override int GetHashCode()
        {
            return Error.GetHashCode();
        }

        /// <summary>
        /// Returns a string that represents the current object
        /// </summary>
        public override string ToString()
        {
            return $"Failure({Error})";
        }
    }
}
