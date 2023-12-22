namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFindSimilarRecordsRequestBuilderSchema

	/// <exclude/>
	public class IFindSimilarRecordsRequestBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFindSimilarRecordsRequestBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFindSimilarRecordsRequestBuilderSchema(IFindSimilarRecordsRequestBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3f0cc1cb-f956-4f6e-ba88-abeb40ffc587");
			Name = "IFindSimilarRecordsRequestBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,107,219,64,16,61,59,144,255,48,40,151,24,202,138,132,66,33,113,124,104,67,32,135,146,18,39,167,208,195,90,59,178,23,172,93,101,102,151,18,210,254,247,142,62,45,187,41,145,75,117,155,157,157,247,230,205,155,149,211,5,114,169,51,132,7,36,210,236,243,160,190,120,151,219,85,36,29,172,119,234,26,77,44,55,54,171,163,227,163,215,227,163,73,100,235,86,176,120,225,128,197,101,31,15,1,8,229,92,50,39,132,43,41,131,91,23,144,114,161,185,128,219,27,235,204,194,22,118,163,233,30,51,79,134,239,241,57,34,135,207,209,110,12,82,93,152,166,41,204,56,22,133,166,151,121,27,183,121,240,57,132,53,74,26,17,50,194,252,42,169,32,175,219,46,177,131,75,210,57,228,158,128,81,83,182,174,58,148,66,110,136,91,68,116,193,6,139,172,58,198,116,64,89,198,165,0,130,237,90,31,211,249,228,181,238,190,215,253,21,195,218,27,190,128,111,53,88,147,220,215,182,21,199,227,133,145,47,64,3,151,152,217,220,162,217,47,218,109,243,70,110,47,130,184,98,6,16,193,183,163,1,211,51,168,190,191,116,191,193,89,169,73,23,224,100,97,174,146,124,4,197,252,65,180,80,19,84,100,203,74,97,45,208,225,143,142,186,205,171,89,90,195,111,217,8,67,36,199,53,136,117,28,180,19,7,14,112,254,77,117,179,180,131,173,120,222,172,109,140,104,131,211,17,163,132,17,179,152,94,190,239,124,55,169,237,202,254,131,47,145,145,228,249,58,204,170,215,154,204,31,37,134,172,63,248,115,204,7,155,218,169,54,58,232,191,187,182,216,23,208,221,31,206,255,233,110,201,126,131,1,79,147,79,234,236,92,125,132,159,237,131,1,43,5,88,18,86,181,70,129,200,120,255,245,169,67,157,155,38,211,239,35,247,224,113,103,174,176,59,230,15,80,161,76,254,243,174,156,160,51,205,95,164,142,127,53,255,211,157,67,57,27,126,191,1,193,168,10,235,204,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3f0cc1cb-f956-4f6e-ba88-abeb40ffc587"));
		}

		#endregion

	}

	#endregion

}

