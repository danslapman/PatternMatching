using System;
using Patterns.Containers;
using Xunit;

namespace Patterns.Tests
{
    public class ResultTests
    {
        [Fact]
        public void SuccessBehaviourTest()
        {
            Result<int, Exception> res = new Success<int, Exception>(42);
            Assert.True(res.IsSuccess);
            Assert.False(res.IsFailure);
            Assert.Equal(new Some<int>(42), res.ToOption());   
        }

        [Fact]
        public void FailureBehaviourTest()
        {
            Result<int, Exception> res = new Failure<int, Exception>(new ArgumentException("yay"));
            Assert.False(res.IsSuccess);
            Assert.True(res.IsFailure);
            Assert.Equal(new None<int>(), res.ToOption());
        }
    }
}
