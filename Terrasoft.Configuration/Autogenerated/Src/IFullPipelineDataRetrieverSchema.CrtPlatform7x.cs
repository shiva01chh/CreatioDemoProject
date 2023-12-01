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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,77,110,194,48,16,133,215,68,226,14,163,116,211,110,226,61,132,108,90,90,177,168,132,40,23,48,201,36,88,114,236,104,108,83,69,168,119,175,227,36,144,210,22,239,60,63,159,222,123,182,226,53,154,134,231,8,123,36,226,70,151,54,121,214,170,20,149,35,110,133,86,243,232,60,143,102,206,8,85,193,71,107,44,214,190,47,37,230,93,211,36,111,168,144,68,190,156,71,126,234,129,176,242,85,216,40,139,84,122,232,2,54,175,78,202,173,104,80,10,133,47,220,242,29,90,18,120,66,10,27,140,49,72,141,171,107,78,109,54,220,183,164,79,162,64,3,98,196,128,46,129,250,61,46,161,244,68,104,6,36,20,158,153,140,36,54,65,53,238,32,69,62,129,220,147,50,59,7,57,23,7,239,104,143,186,48,11,216,6,74,223,188,21,27,10,35,228,34,228,183,146,190,210,112,226,53,40,159,247,42,30,213,175,149,21,182,237,243,54,113,182,63,226,213,24,134,30,228,211,199,48,73,202,2,231,138,245,185,56,82,38,187,62,74,151,86,106,16,33,39,44,87,241,212,245,78,127,198,44,75,217,184,212,81,54,107,229,106,36,126,144,152,222,204,102,48,141,233,241,191,201,169,139,12,254,244,246,180,28,242,69,85,244,17,135,251,87,255,109,126,20,125,205,159,111,195,190,85,48,152,2,0,0 };
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

