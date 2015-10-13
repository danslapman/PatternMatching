using System;

namespace Patterns.Containers
{
    public abstract class Result<TSucc, TErr>
    {
        public abstract bool IsSuccess { get; }
        public abstract bool IsFailure { get; }
        public abstract Result<TRes, TErr> Map<TRes>(Func<TSucc, TRes> f);
        public abstract Result<TRes, TErr> FlatMap<TRes>(Func<TSucc, Result<TRes, TErr>> f);
        public abstract Result<TSucc, TRes> MapError<TRes>(Func<TErr, TRes> f);
        public abstract Result<TSucc, TRes> FlatMapError<TRes>(Func<TErr, Result<TSucc, TRes>> f); 
        public abstract Option<TSucc> ToOption();

        public static implicit operator Result<TSucc, TErr>(TSucc instance)
        {
            return new Success<TSucc, TErr>(instance);
        }

        public static implicit operator Result<TSucc, TErr>(TErr instance)
        {
            return new Failure<TSucc, TErr>(instance);
        }
    }

    public sealed class Success<TSucc, TErr> : Result<TSucc, TErr>
    {
        public TSucc Value { get; }

        public Success(TSucc value)
        {
            Value = value;
        }

        public override bool IsSuccess => true;
        public override bool IsFailure => false;
        public override Result<TRes, TErr> Map<TRes>(Func<TSucc, TRes> f)
        {
            return f(Value);
        }

        public override Result<TRes, TErr> FlatMap<TRes>(Func<TSucc, Result<TRes, TErr>> f)
        {
            return f(Value);
        }

        public override Result<TSucc, TRes> MapError<TRes>(Func<TErr, TRes> f)
        {
            return Value;
        }

        public override Result<TSucc, TRes> FlatMapError<TRes>(Func<TErr, Result<TSucc, TRes>> f)
        {
            return Value;
        }

        public override Option<TSucc> ToOption()
        {
            return new Some<TSucc>(Value);
        }

        public override string ToString()
        {
            return $"Success({Value})";
        }
    }

    public sealed class Failure<TSucc, TErr> : Result<TSucc, TErr>
    {
        public TErr Error { get; }

        public Failure(TErr error)
        {
            Error = error;
        }

        public override bool IsSuccess => false;
        public override bool IsFailure => true;

        public override Result<TRes, TErr> Map<TRes>(Func<TSucc, TRes> f)
        {
            return Error;
        }

        public override Result<TRes, TErr> FlatMap<TRes>(Func<TSucc, Result<TRes, TErr>> f)
        {
            return Error;
        }

        public override Result<TSucc, TRes> MapError<TRes>(Func<TErr, TRes> f)
        {
            return f(Error);
        }

        public override Result<TSucc, TRes> FlatMapError<TRes>(Func<TErr, Result<TSucc, TRes>> f)
        {
            return f(Error);
        }

        public override Option<TSucc> ToOption()
        {
            return new None<TSucc>();
        }

        public override string ToString()
        {
            return $"Failure({Error})";
        }
    }
}
