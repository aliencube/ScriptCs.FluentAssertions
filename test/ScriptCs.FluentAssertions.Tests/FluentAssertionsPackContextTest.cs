using System;
using System.Collections;
using System.Linq;
using System.Threading.Tasks;

using Aliencube.ScriptCs.FluentAssertions.Tests.Fixtures;

using FluentAssertions;
using FluentAssertions.Collections;
using FluentAssertions.Numeric;
using FluentAssertions.Primitives;
using FluentAssertions.Specialized;

using Xunit;

namespace Aliencube.ScriptCs.FluentAssertions.Tests
{
    /// <summary>
    /// This represents the test entity for the <see cref="FluentAssertionsPackContext"/> class.
    /// </summary>
    public class FluentAssertionsPackContextTest : IClassFixture<FluentAssertionsPackContextFixture>
    {
        private readonly FluentAssertionsPackContext _context;

        /// <summary>
        /// Initialises a new instance of the <see cref="FluentAssertionsPackContextTest"/> class.
        /// </summary>
        /// <param name="fixture"><see cref="FluentAssertionsPackContextFixture"/> instance.</param>
        public FluentAssertionsPackContextTest(FluentAssertionsPackContextFixture fixture)
        {
            this._context = fixture.FluentAssertionsPackContext as FluentAssertionsPackContext;
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData("helloworld")]
        public void Given_String_Should_ShouldReturn_Result(string actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<StringAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(1)]
        public void Given_Int32_Should_ShouldReturn_Result(int actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NumericAssertions<int>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(1)]
        public void Given_NullableInt32_Should_ShouldReturn_Result(int? actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NullableNumericAssertions<int>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(1)]
        public void Given_Int16_Should_ShouldReturn_Result(short actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NumericAssertions<short>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(1)]
        public void Given_NullableInt16_Should_ShouldReturn_Result(int actualValue)
        {
            var converted1 = (short) actualValue;
            var converted2 = (short?) converted1;
            var result = this._context.Should(converted2);
            result.Should().BeOfType<NullableNumericAssertions<short>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(1)]
        public void Given_Int64_Should_ShouldReturn_Result(long actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NumericAssertions<long>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(1)]
        public void Given_NullableInt64_Should_ShouldReturn_Result(int actualValue)
        {
            var converted1 = (long) actualValue;
            var converted2 = (long?) converted1;
            var result = this._context.Should(converted2);
            result.Should().BeOfType<NullableNumericAssertions<long>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(3.14)]
        public void Given_Single_Should_ShouldReturn_Result(float actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NumericAssertions<float>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(3.14)]
        public void Given_NullableSingle_Should_ShouldReturn_Result(double actualValue)
        {
            var converted1 = (float) actualValue;
            var converted2 = (float?) converted1;
            var result = this._context.Should(converted2);
            result.Should().BeOfType<NullableNumericAssertions<float>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(3.14)]
        public void Given_Double_Should_ShouldReturn_Result(double actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NumericAssertions<double>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(3.14)]
        public void Given_NullableDouble_Should_ShouldReturn_Result(double? actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NullableNumericAssertions<double>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(3.14)]
        public void Given_Decimal_Should_ShouldReturn_Result(decimal actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NumericAssertions<decimal>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(3.14)]
        public void Given_NullableDecimal_Should_ShouldReturn_Result(double actualValue)
        {
            var converted1 = (decimal) actualValue;
            var converted2 = (decimal?) converted1;
            var result = this._context.Should(converted2);
            result.Should().BeOfType<NullableNumericAssertions<decimal>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(true)]
        public void Given_Boolean_Should_ShouldReturn_Result(bool actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<BooleanAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="actualValue">Value to assert.</param>
        [Theory]
        [InlineData(true)]
        public void Given_NullableBoolean_Should_ShouldReturn_Result(bool? actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NullableBooleanAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_DateTime_Should_ShouldReturn_Result()
        {
            var actualValue = DateTime.Now;
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<DateTimeAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_NullableDateTime_Should_ShouldReturn_Result()
        {
            var actualValue = (DateTime?) DateTime.Now;
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NullableDateTimeAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_DateTimeOffset_Should_ShouldReturn_Result()
        {
            var actualValue = DateTimeOffset.Now;
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<DateTimeOffsetAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_NullableDateTimeOffset_Should_ShouldReturn_Result()
        {
            var actualValue = (DateTimeOffset?)DateTimeOffset.Now;
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NullableDateTimeOffsetAssertions>();
        }


        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="value1">Value 1.</param>
        /// <param name="value2">Value 2.</param>
        /// <param name="value3">Value 3.</param>
        /// <param name="value4">Value 4.</param>
        [Theory]
        [InlineData(1, 2, 3, 4)]
        public void Given_IEnumerable_Should_ShouldReturn_Result(int value1, int value2, int value3, int value4)
        {
            var actualValue = (IEnumerable) new[] { value1, value2, value3, value4 };
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<NonGenericCollectionAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="value1">Value 1.</param>
        /// <param name="value2">Value 2.</param>
        /// <param name="value3">Value 3.</param>
        /// <param name="value4">Value 4.</param>
        [Theory]
        [InlineData(1, 2, 3, 4)]
        public void Given_IEnumerableT_Should_ShouldReturn_Result(int value1, int value2, int value3, int value4)
        {
            var actualValue = new[] { value1, value2, value3, value4 }.AsEnumerable();
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<GenericCollectionAssertions<int>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        /// <param name="value1">Value 1.</param>
        /// <param name="value2">Value 2.</param>
        /// <param name="value3">Value 3.</param>
        /// <param name="value4">Value 4.</param>
        [Theory]
        [InlineData("a", "b", "c", "d")]
        public void Given_IEnumerableString_Should_ShouldReturn_Result(string value1, string value2, string value3, string value4)
        {
            var actualValue = new[] { value1, value2, value3, value4 }.AsEnumerable();
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<StringCollectionAssertions>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_ActionWithException_ShouldThrow_ShouldReturn_Result()
        {
            Action action = () => { throw new NotImplementedException(); };

            var result = this._context.ShouldThrow<NotImplementedException>(action);
            result.Should().BeOfType<ExceptionAssertions<NotImplementedException>>();
        }

        /// <summary>
        /// Tests whether the method should return result or not.
        /// </summary>
        [Fact]
        public void Given_FuncWithException_ShouldThrow_ShouldReturn_Result()
        {
            Func<Task> func = () => { throw new NotImplementedException(); };

            var result = this._context.ShouldThrow<NotImplementedException>(func);
            result.Should().BeOfType<ExceptionAssertions<NotImplementedException>>();
        }
    }
}
