using System.Collections.Generic;

using ScriptCs.Contracts;

namespace Aliencube.ScriptCs.FluentAssertions
{
    /// <summary>
    /// This represents the entity for script pack.
    /// </summary>
    public class ScriptPack : IScriptPack
    {
        /// <summary>
        /// Gets the list of reference assemblies.
        /// </summary>
        public static List<string> References = new List<string>()
                                                {
                                                    "mscorlib",
                                                    "System",
                                                    "System.Core",
                                                    "FluentAssertions",
                                                    "FluentAssertions.Core",
                                                };

        /// <summary>
        /// Gets the list of namespaces.
        /// </summary>
        public static List<string> Namespaces = new List<string>()
                                                {
                                                    "FluentAssertions",
                                                };
        /// <summary>
        /// Initialises reference assemblies.
        /// </summary>
        /// <param name="session"><see cref="IScriptPackSession"/> instance.</param>
        public void Initialize(IScriptPackSession session)
        {
            References.ForEach(session.AddReference);
            Namespaces.ForEach(session.ImportNamespace);
        }

        /// <summary>
        /// Gets the context.
        /// </summary>
        /// <returns>Returns the context.</returns>
        public IScriptPackContext GetContext()
        {
            return new FluentAssertionsPackContext();
        }

        /// <summary>
        /// Terminates the script pack.
        /// </summary>
        public void Terminate()
        {
        }
    }
}
