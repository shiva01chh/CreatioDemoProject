namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFullPipelineQueryBuilderSchema

	/// <exclude/>
	public class IFullPipelineQueryBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFullPipelineQueryBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFullPipelineQueryBuilderSchema(IFullPipelineQueryBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("72be6cd2-93c1-4725-9a00-7c556867169a");
			Name = "IFullPipelineQueryBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,79,195,48,12,61,51,105,255,193,42,23,144,80,115,223,186,30,54,6,218,1,52,180,253,129,172,117,183,72,249,40,78,130,84,77,252,119,210,100,29,99,32,42,181,138,159,253,158,95,29,107,174,208,182,188,66,216,34,17,183,166,113,249,194,232,70,236,61,113,39,140,30,143,142,227,209,141,183,66,239,97,211,89,135,42,228,165,196,170,79,218,252,25,53,146,168,166,231,154,133,33,204,31,231,1,8,208,45,225,62,148,193,74,59,164,38,116,153,192,234,201,75,185,22,45,74,161,241,205,35,117,115,47,100,141,20,9,140,49,40,172,87,138,83,87,158,226,53,153,15,81,163,5,133,238,96,106,112,6,222,123,30,236,18,17,26,19,222,160,10,237,73,54,31,148,216,133,84,235,119,82,84,32,6,43,255,57,185,57,70,55,103,255,47,177,179,157,192,58,138,164,228,181,215,8,68,9,11,238,128,201,100,126,174,100,215,165,69,203,137,43,208,225,6,102,89,21,103,110,179,114,27,152,167,32,47,88,44,249,155,97,171,3,42,254,26,206,89,217,127,193,52,177,109,194,127,115,9,157,39,109,203,194,98,232,64,216,204,178,13,246,247,152,177,178,96,67,182,47,79,112,250,149,56,151,187,213,82,123,133,196,119,18,139,203,169,45,181,19,174,75,251,82,14,182,31,192,58,234,87,225,219,225,253,244,52,79,212,117,26,105,140,63,211,146,252,0,35,118,249,124,1,139,128,204,4,162,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72be6cd2-93c1-4725-9a00-7c556867169a"));
		}

		#endregion

	}

	#endregion

}

