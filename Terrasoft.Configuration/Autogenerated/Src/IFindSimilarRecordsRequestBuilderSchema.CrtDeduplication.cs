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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,84,77,107,27,49,16,61,59,144,255,48,108,46,49,20,45,45,133,66,226,248,208,134,64,14,165,37,78,78,161,7,121,53,107,11,188,210,118,70,162,132,180,255,189,163,253,242,71,83,178,46,221,219,104,52,239,205,155,55,90,167,43,228,90,23,8,247,72,164,217,151,65,125,242,174,180,171,72,58,88,239,212,53,154,88,111,108,209,68,167,39,207,167,39,147,200,214,173,96,241,196,1,171,203,33,222,5,32,148,115,201,156,17,174,164,12,110,93,64,42,133,230,2,110,111,172,51,11,91,217,141,166,59,44,60,25,190,195,239,17,57,124,140,118,99,144,154,194,60,207,97,198,177,170,52,61,205,187,184,203,131,47,33,172,81,210,136,80,16,150,87,89,130,188,238,186,196,30,46,203,231,80,122,2,70,77,197,58,117,40,133,220,18,119,136,232,130,13,22,89,245,140,249,14,101,29,151,2,8,182,111,125,76,231,147,231,166,251,65,247,103,12,107,111,248,2,190,54,96,109,242,80,219,86,28,143,23,70,190,2,13,92,99,97,75,139,230,176,104,191,205,27,185,189,8,226,138,217,129,8,190,27,13,152,129,65,13,253,229,135,13,206,106,77,186,2,39,11,115,149,149,35,40,230,247,162,133,218,32,145,45,147,194,70,160,195,31,61,117,151,87,179,188,129,223,178,17,134,72,142,27,16,235,56,104,39,14,28,225,252,139,234,102,121,15,155,120,94,172,109,141,232,130,243,17,163,132,17,179,152,94,190,238,124,63,169,237,202,254,131,47,145,145,228,249,58,44,210,107,205,230,15,18,67,49,28,252,57,230,163,77,237,85,27,29,244,223,93,91,28,10,232,239,239,206,255,241,203,146,253,6,3,158,103,31,212,219,119,234,61,252,236,30,12,88,41,192,154,48,213,26,5,34,227,245,215,167,142,117,110,154,77,191,141,220,131,135,189,185,194,254,152,223,64,66,153,252,231,93,57,67,103,218,191,72,19,255,106,255,167,123,135,114,150,190,223,206,183,10,135,196,5,0,0 };
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

