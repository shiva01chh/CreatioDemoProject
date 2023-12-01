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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,75,28,65,16,61,175,224,127,40,198,139,11,161,135,4,65,208,117,15,42,130,135,144,224,234,73,60,244,78,215,236,54,236,116,79,170,186,9,98,252,239,214,124,238,135,6,103,67,230,86,93,93,239,213,171,87,61,78,23,200,165,206,16,238,145,72,179,207,131,186,242,46,183,139,72,58,88,239,212,53,154,88,174,108,86,71,135,7,47,135,7,163,200,214,45,96,246,204,1,139,243,62,222,4,32,148,115,201,28,17,46,164,12,110,93,64,202,133,230,12,110,111,172,51,51,91,216,149,166,59,204,60,25,190,195,95,17,57,92,70,187,50,72,117,97,154,166,48,225,88,20,154,158,167,109,220,230,193,231,16,150,40,105,68,200,8,243,139,164,130,188,110,187,196,14,46,73,167,144,123,2,70,77,217,178,234,80,10,185,33,110,17,209,5,27,44,178,234,24,211,13,202,50,206,5,16,108,215,250,144,206,71,47,117,247,189,238,239,24,150,222,240,25,252,172,193,154,228,174,182,181,56,30,46,140,124,1,26,184,196,204,230,22,205,110,209,118,155,55,114,123,22,196,21,179,1,17,124,59,26,48,61,131,234,251,75,119,27,156,148,154,116,1,78,22,230,34,201,7,80,76,239,69,11,53,65,69,54,175,20,214,2,29,254,238,168,219,188,154,164,53,252,154,141,48,68,114,92,131,88,199,65,59,113,96,15,231,63,84,55,73,59,216,138,231,195,218,198,136,54,56,30,48,74,24,48,139,241,249,231,206,119,147,90,175,236,63,248,18,25,73,158,175,195,172,122,173,201,244,65,98,200,250,131,247,99,222,219,212,78,181,209,65,255,221,181,217,174,128,238,254,230,252,31,127,204,217,175,48,224,113,114,170,190,126,83,39,240,167,125,48,96,165,0,75,194,170,214,40,16,25,159,191,62,181,175,115,227,100,252,52,112,15,30,182,230,10,219,99,254,2,21,202,232,63,239,202,17,58,211,252,69,234,248,181,249,159,110,29,202,153,124,111,189,108,126,13,195,5,0,0 };
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

