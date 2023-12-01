 namespace Terrasoft.Configuration
{
	using System;
	using System.Collections.Generic;
	using Terrasoft.Core.DB;
	using Terrasoft.Core.Factories;

	#region Class: LeadStagesMergePreProcessor
	
	/// <summary>
	/// LeadInStage merge detail preprocessor. 
	/// </summary>
	[DefaultBinding(typeof(IDuplicatesSchemaMergePreProcessor), Name="LeadStagesMergePreProcessor")]
	public class LeadStagesMergePreProcessor : BaseStageMergeProcessor, IDuplicatesSchemaMergePreProcessor
	{
		/// <summary>
		/// Master entity schema name.
		/// </summary>
		public string EntitySchemaName { get; } = "Lead";

		/// <summary>
		/// Process merge actions.
		/// </summary>
		/// <param name="duplicates">Duplicates collection.</param>
		/// <param name="goldenRecord">Gold record Id</param>
		/// <param name="dbExecutor">DBExecutor instance.</param>
		public void Process(List<Guid> duplicates, Guid goldenRecord, DBExecutor dbExecutor) {
			var stageParams = new KeyValuePair<string, string>("QualifyStatus_StageNumber", "QualifyStatus.IsDisplayed");
			base.Process(duplicates, goldenRecord, dbExecutor, "Lead", stageParams, "LeadInQualifyStatus");
		}
	}

	#endregion
}




