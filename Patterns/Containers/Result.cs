using System;

namespace Patterns.Containers
{
    public abstract class Result<TSucc, TErr>
    {
        public abstract bool IsSuccess { get; }
        public abstract bool IsFailure { get; }
        public abstract Result<TSucc, TErr> Map(Func<TSucc, TSucc> f);
        public abstract Result<TSucc, TErr> FlatMap(Func<TSucc, Result<TSucc, TErr>> f);
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
        public override Result<TSucc, TErr> Map(Func<TSucc, TSucc> f)
        {
            return new Success<TSucc, TErr>(f(Value));
        }

        public override Result<TSucc, TErr> FlatMap(Func<TSucc, Result<TSucc, TErr>> f)
        {
            return f(Value);
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

        public override Result<TSucc, TErr> Map(Func<TSucc, TSucc> f)
        {
            return this;
        }

        public override Result<TSucc, TErr> FlatMap(Func<TSucc, Result<TSucc, TErr>> f)
        {
            return this;
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
