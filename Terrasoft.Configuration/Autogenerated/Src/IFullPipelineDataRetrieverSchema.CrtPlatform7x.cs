namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFullPipelineDataRetrieverSchema

	/// <exclude/>
	public class IFullPipelineDataRetrieverSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFullPipelineDataRetrieverSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFullPipelineDataRetrieverSchema(IFullPipelineDataRetrieverSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bab0b7d8-fd3f-4488-b7c0-eec4053f33c3");
			Name = "IFullPipelineDataRetriever";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eccc4091-3404-497f-94e5-8c10d0f3a0d7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,77,110,194,48,16,133,215,32,229,14,163,116,211,110,226,61,132,108,90,90,101,81,9,81,46,96,146,73,176,228,216,209,216,166,66,168,119,175,227,16,146,210,22,239,60,63,159,222,123,182,226,13,154,150,23,8,59,36,226,70,87,54,121,214,170,18,181,35,110,133,86,209,252,28,205,103,206,8,85,195,199,201,88,108,124,95,74,44,186,166,73,222,80,33,137,98,25,205,253,212,3,97,237,171,144,43,139,84,121,232,2,242,87,39,229,70,180,40,133,194,23,110,249,22,45,9,60,34,133,13,198,24,164,198,53,13,167,83,118,185,111,72,31,69,137,6,196,128,1,93,1,245,123,92,66,229,137,208,94,144,80,122,102,50,144,216,4,213,186,189,20,197,4,114,79,202,236,28,228,92,29,188,163,61,232,210,44,96,19,40,125,243,86,108,40,12,144,171,144,223,74,250,74,203,137,55,160,124,222,171,120,80,191,86,86,216,83,159,183,137,179,221,1,71,99,24,122,80,76,31,195,36,41,11,156,17,235,115,113,164,76,54,62,74,151,86,106,16,161,32,172,86,241,212,245,86,127,198,44,75,217,176,212,81,242,181,114,13,18,223,75,76,111,102,51,152,198,244,248,223,228,212,69,6,127,122,123,90,94,242,69,85,246,17,135,251,87,255,109,126,20,125,173,59,223,39,192,138,48,153,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bab0b7d8-fd3f-4488-b7c0-eec4053f33c3"));
		}

		#endregion

	}

	#endregion

}

