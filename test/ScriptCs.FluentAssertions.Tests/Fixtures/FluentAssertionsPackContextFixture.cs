using System;

using ScriptCs.Contracts;

namespace Aliencube.ScriptCs.FluentAssertions.Tests.Fixtures
{
    /// <summary>
    /// This represents the fixture entity for the <see cref="FluentAssertionsPackContextTest"/> class.
    /// </summary>
    public class FluentAssertionsPackContextFixture : IDisposable
    {
        private bool _disposed;

        /// <summary>
        /// Initialises a new instance of the <see cref="FluentAssertionsPackContextFixture"/> class.
        /// </summary>
        public FluentAssertionsPackContextFixture()
        {
            this.FluentAssertionsPackContext = new FluentAssertionsPackContext();
        }

        /// <summary>
        /// Gets the <see cref="IScriptPackContext"/> instance.
        /// </summary>
        public IScriptPackContext FluentAssertionsPackContext { get; }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            if (this._disposed)
            {
                return;
            }

            this._disposed = true;
        }
    }
}
