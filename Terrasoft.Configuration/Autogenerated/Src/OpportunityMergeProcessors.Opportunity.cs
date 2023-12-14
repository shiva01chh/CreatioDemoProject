namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: OpportunityStagesMergePreProcessor
	
	/// <summary>
	/// OpportunityInStage merge detail preprocessor. 
	/// </summary>
	[DefaultBinding(typeof(IDuplicatesSchemaMergePreProcessor), Name = "OpportunityStagesMergePreProcessor")]
	public class OpportunityStagesMergePreProcessor : BaseStageMergeProcessor, IDuplicatesSchemaMergePreProcessor
	{
		/// <summary>
		/// Master entity schema name.
		/// </summary>
		public string EntitySchemaName { get; } = "Opportunity";

		/// <summary>
		/// Process merge actions.
		/// </summary>
		/// <param name="duplicates">Duplicates collection.</param>
		/// <param name="goldenRecord">Gold record Id</param>
		/// <param name="dbExecutor">DBExecutor instance.</param>
		public void Process(List<Guid> duplicates, Guid goldenRecord, DBExecutor dbExecutor) {
			var stageParams = new KeyValuePair<string, string>("Stage_Number", "Stage.ShowInProgressBar");
			base.Process(duplicates, goldenRecord, dbExecutor, "Opportunity", stageParams, "OpportunityInStage");
		}
	}
	
	#endregion
}





