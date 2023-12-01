namespace Terrasoft.Configuration.GenAI
{
	using Creatio.FeatureToggling;

	public static class GenAIFeatures
	{
		public class GenerateDcm: FeatureMetadata
		{
			public GenerateDcm() {
				IsEnabled = true;
				Description = "Use AI for generating Dcm for application";
			}
		}

		public class GenerateDemoData: FeatureMetadata
		{
			public GenerateDemoData() {
				IsEnabled = true;
				Description = "Use AI for generating demo data for application";
			}
		}

		public class GenerateNextSteps: FeatureMetadata
		{
			public GenerateNextSteps() {
				IsEnabled = false;
				Description = "Use AI for generating next steps for application";
			}
		}
	}
}




