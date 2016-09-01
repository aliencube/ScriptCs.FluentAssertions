using Aliencube.ScriptCs.FluentAssertions.Tests.Fixtures;

using FluentAssertions;
using FluentAssertions.Primitives;

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
        /// <param name="actualValue"></param>
        [Theory]
        [InlineData("helloworld")]
        public void Given_String_Should_ShouldReturn_Result(string actualValue)
        {
            var result = this._context.Should(actualValue);
            result.Should().BeOfType<StringAssertions>();
        }
    }
}
