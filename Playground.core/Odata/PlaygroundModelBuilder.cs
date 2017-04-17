using Microsoft.AspNetCore.OData;
using Microsoft.AspNetCore.OData.Builder;
using Microsoft.OData.Edm;
using Playground.core.Models;

namespace Playground.core.Odata
{
    public class PlaygroundModelBuilder
    {
        private readonly IAssemblyProvider m_assemblyProvider;
        public PlaygroundModelBuilder(IAssemblyProvider assemblyProvider)
        {
            m_assemblyProvider = assemblyProvider;
        }

        public IEdmModel GetEdmModel()
        {
            var builder = new ODataConventionModelBuilder(m_assemblyProvider);
            builder.EntitySet<Company>(nameof(PlaygroundContext.Companies));
            builder.EntitySet<Site>(nameof(PlaygroundContext.Sites));
            
            return builder.GetEdmModel();
        }
    }
}
