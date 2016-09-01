using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

using FluentAssertions.Collections;
using FluentAssertions.Numeric;
using FluentAssertions.Primitives;
using FluentAssertions.Specialized;

using ScriptCs.Contracts;

using AssertionExtensions = FluentAssertions.AssertionExtensions;

namespace Aliencube.ScriptCs.FluentAssertions
{
    /// <summary>
    /// This represents script pack context entity.
    /// </summary>
    public class FluentAssertionsPackContext : IScriptPackContext
    {
        /// <summary>
        /// Returns an <see cref="StringAssertions"/> object that can be used to assert the current string value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="StringAssertions"/> instance.</returns>
        public StringAssertions Should(string actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NumericAssertions{Int32}"/> object that can be used to assert the current integer value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NumericAssertions{Int32}"/> instance.</returns>
        public NumericAssertions<int> Should(int actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableNumericAssertions{Int32}"/> object that can be used to assert the current nullable integer value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableNumericAssertions{Int32}"/> instance.</returns>
        public NullableNumericAssertions<int> Should(int? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NumericAssertions{Int16}"/> object that can be used to assert the current short (int16) value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NumericAssertions{Int16}"/> instance.</returns>
        public NumericAssertions<short> Should(short actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableNumericAssertions{Int16}"/> object that can be used to assert the current nullable short (int16) value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableNumericAssertions{Int16}"/> instance.</returns>
        public NullableNumericAssertions<short> Should(short? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NumericAssertions{Int64}"/> object that can be used to assert the current long (int64) value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NumericAssertions{Int64}"/> instance.</returns>
        public NumericAssertions<long> Should(long actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableNumericAssertions{Int64}"/> object that can be used to assert the current nullable long (int64) value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableNumericAssertions{Int64}"/> instance.</returns>
        public NullableNumericAssertions<long> Should(long? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NumericAssertions{Single}"/> object that can be used to assert the current float (single) value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NumericAssertions{Single}"/> instance.</returns>
        public NumericAssertions<float> Should(float actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableNumericAssertions{Single}"/> object that can be used to assert the current nullable float (single) value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableNumericAssertions{Single}"/> instance.</returns>
        public NullableNumericAssertions<float> Should(float? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NumericAssertions{Double}"/> object that can be used to assert the current double value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NumericAssertions{Double}"/> instance.</returns>
        public NumericAssertions<double> Should(double actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableNumericAssertions{Double}"/> object that can be used to assert the current nullable double value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableNumericAssertions{Double}"/> instance.</returns>
        public NullableNumericAssertions<double> Should(double? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NumericAssertions{Decimal}"/> object that can be used to assert the current decimal value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NumericAssertions{Decimal}"/> instance.</returns>
        public NumericAssertions<decimal> Should(decimal actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableNumericAssertions{Decimal}"/> object that can be used to assert the current nullable decimal value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableNumericAssertions{Decimal}"/> instance.</returns>
        public NullableNumericAssertions<decimal> Should(decimal? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="BooleanAssertions"/> object that can be used to assert the current bool value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="BooleanAssertions"/> instance.</returns>
        public BooleanAssertions Should(bool actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableBooleanAssertions"/> object that can be used to assert the current nullable bool value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableBooleanAssertions"/> instance.</returns>
        public NullableBooleanAssertions Should(bool? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="DateTimeAssertions"/> object that can be used to assert the current <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="DateTimeAssertions"/> instance.</returns>
        public DateTimeAssertions Should(DateTime actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableDateTimeAssertions"/> object that can be used to assert the current nullable <see cref="DateTime"/> value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableDateTimeAssertions"/> instance.</returns>
        public NullableDateTimeAssertions Should(DateTime? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="DateTimeOffsetAssertions"/> object that can be used to assert the current <see cref="DateTimeOffset"/> value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="DateTimeOffsetAssertions"/> instance.</returns>
        public DateTimeOffsetAssertions Should(DateTimeOffset actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NullableDateTimeOffsetAssertions"/> object that can be used to assert the current nullable <see cref="DateTimeOffset"/> value.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NullableDateTimeOffsetAssertions"/> instance.</returns>
        public NullableDateTimeOffsetAssertions Should(DateTimeOffset? actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="NonGenericCollectionAssertions" /> object that can be used to assert the current <see cref="IEnumerable" /> instance.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="NonGenericCollectionAssertions"/> instance.</returns>
        public NonGenericCollectionAssertions Should(IEnumerable actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="GenericCollectionAssertions{T}" /> object that can be used to assert the current <see cref="IEnumerable{T}" /> instance.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="GenericCollectionAssertions{T}"/> instance.</returns>
        public GenericCollectionAssertions<T> Should<T>(IEnumerable<T> actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Returns an <see cref="StringCollectionAssertions" /> object that can be used to assert the current <see cref="IEnumerable{String}" /> instance.
        /// </summary>
        /// <param name="actualValue">Value for assertion.</param>
        /// <returns>Returns the <see cref="StringCollectionAssertions"/> instance.</returns>
        public StringCollectionAssertions Should(IEnumerable<string> actualValue)
        {
            return AssertionExtensions.Should(actualValue);
        }

        /// <summary>
        /// Asserts that the <paramref name="action" /> throws an exception.
        /// </summary>
        /// <param name="action">A reference to the method or property.</param>
        /// <typeparam name="TException">The type of the exception it should throw.</typeparam>
        /// <returns>Returns an object that allows asserting additional members of the thrown exception.</returns>
        public ExceptionAssertions<TException> ShouldThrow<TException>(Action action) where TException : Exception
        {
            return AssertionExtensions.ShouldThrow<TException>(action);
        }

        /// <summary>
        /// Asserts that the <paramref name="asyncAction" /> throws an exception.
        /// </summary>
        /// <param name="asyncAction">A reference to the method or property.</param>
        /// <typeparam name="TException">The type of the exception it should throw.</typeparam>
        /// <returns>Returns an object that allows asserting additional members of the thrown exception.</returns>
        public ExceptionAssertions<TException> ShouldThrow<TException>(Func<Task> asyncAction) where TException : Exception
        {
            return AssertionExtensions.ShouldThrow<TException>(asyncAction);
        }

        /// <summary>
        /// Asserts that the <paramref name="action" /> does not throw a particular exception.
        /// </summary>
        /// <param name="action">The current method or property.</param>
        /// <typeparam name="TException">The type of the exception it should not throw. Any other exceptions are ignored and will satisfy the assertion.</typeparam>
        public void ShouldNotThrow<TException>(Action action) where TException : Exception
        {
            AssertionExtensions.ShouldNotThrow<TException>(action);
        }

        /// <summary>
        /// Asserts that the <paramref name="asyncAction" /> does not throw a particular exception.
        /// </summary>
        /// <param name="asyncAction">The current method or property.</param>
        /// <typeparam name="TException">The type of the exception it should not throw. Any other exceptions are ignored and will satisfy the assertion.</typeparam>
        public void ShouldNotThrow<TException>(Func<Task> asyncAction)
        {
            AssertionExtensions.ShouldNotThrow<TException>(asyncAction);
        }
    }
}
