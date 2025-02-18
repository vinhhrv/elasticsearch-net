using System.Collections.Generic;
using Elastic.Managed.Configuration;
using Elastic.Managed.Ephemeral.Plugins;
using Elastic.Stack.Artifacts;
using Elastic.Stack.Artifacts.Products;
using Tests.Core.Client;
using Tests.Core.ManagedElasticsearch.NodeSeeders;
using static Elastic.Stack.Artifacts.Products.ElasticsearchPlugin;

namespace Tests.Core.ManagedElasticsearch.Clusters
{
	/// <summary>
	/// Use this cluster for APIs that do writes. If they are however intrusive or long running consider IntrusiveOperationCluster
	/// instead.
	/// </summary>
	public class WritableCluster : ClientTestClusterBase
	{
		public WritableCluster() : base(CreateConfiguration()) { }

		private static ClientTestClusterConfiguration CreateConfiguration()
		{
			var plugins = new List<ElasticsearchPlugin>
			{
				IngestGeoIp,
				//IngestAttachment, // latest ingest snapshot build has stderr out needs fixing in abstractions possibly
				AnalysisKuromoji,
				AnalysisIcu,
				AnalysisPhonetic,
				MapperMurmur3,
			};

			// TODO: temporary until https://github.com/elastic/elasticsearch-net-abstractions/commit/3977ccb6449870fb4f1e6059be960e12ec5e5125 is released
			if (ElasticVersion.From(TestClient.Configuration.ElasticsearchVersion) >= "6.4.0")
				plugins.Add(new ElasticsearchPlugin("analysis-nori", v => v >= "6.4.0"));

			return new ClientTestClusterConfiguration(plugins.ToArray())
			{
				MaxConcurrency = 4
			};
		}

		protected override void SeedCluster()
		{
			var seeder = new DefaultSeeder(Client);
			seeder.SeedNode();
		}
	}
}
