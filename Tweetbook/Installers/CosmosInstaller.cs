//using Cosmonaut;
//using Cosmonaut.Extensions.Microsoft.DependencyInjection;
//using Microsoft.Azure.Documents.Client;
//using Microsoft.Extensions.Configuration;
//using Microsoft.Extensions.DependencyInjection;
//using Tweetbook.Domain;

//namespace Tweetbook.Installers
//{
//    public class CosmosInstaller : IInstaller
//    {
//        public void InstallServices(IServiceCollection services, IConfiguration configuration)
//        {
//           var cosmosStoreSettings = new CosmosStoreSettings(
//               configuration["CosmosSettings:DataBaseName"],
//               configuration["CosmosSettings:AccountUrl"],
//               configuration["CosmosSettings:AccountKey"],
//               new ConnectionPolicy{ConnectionMode = ConnectionMode.Direct, ConnectionProtocol = Protocol.Tcp});

//           services.AddCosmosStore<CosmosPostDto>(cosmosStoreSettings);
//        }
//    }
//}
