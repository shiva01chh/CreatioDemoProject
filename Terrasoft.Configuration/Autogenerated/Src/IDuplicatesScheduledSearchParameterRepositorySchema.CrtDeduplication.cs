namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDuplicatesScheduledSearchParameterRepositorySchema

	/// <exclude/>
	public class IDuplicatesScheduledSearchParameterRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDuplicatesScheduledSearchParameterRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDuplicatesScheduledSearchParameterRepositorySchema(IDuplicatesScheduledSearchParameterRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99c0874b-e6e1-4d26-9563-bae0f7a8c6d5");
			Name = "IDuplicatesScheduledSearchParameterRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,83,205,110,219,48,12,62,55,64,222,129,104,47,43,80,216,247,46,203,161,201,48,228,176,161,88,242,2,140,76,199,66,21,201,32,229,180,70,177,119,159,164,216,78,154,0,27,210,67,235,147,73,147,223,31,97,139,91,146,26,21,193,138,152,81,92,233,179,153,179,165,222,52,140,94,59,155,205,169,104,106,163,85,170,198,163,215,241,232,234,134,105,19,10,88,88,79,92,134,229,123,88,204,187,33,146,165,170,194,138,161,98,73,200,170,122,68,14,28,97,240,55,213,78,180,119,220,142,71,1,36,207,115,152,72,179,221,34,183,211,174,14,35,76,66,214,11,32,240,48,15,222,1,42,69,34,241,173,238,1,5,92,9,190,34,144,142,17,138,65,4,72,34,207,122,162,252,136,169,110,214,97,10,116,175,254,82,241,87,49,131,33,132,159,228,43,87,200,61,60,38,216,228,237,204,92,106,204,42,82,79,146,20,227,14,181,193,181,54,218,183,209,5,30,92,253,223,20,172,219,176,32,53,41,93,106,42,250,110,92,216,34,216,0,147,13,26,242,83,17,147,68,148,166,190,93,239,87,126,133,247,235,233,42,114,158,33,197,192,85,212,157,77,242,180,121,0,98,242,13,91,153,174,184,33,208,151,122,120,214,190,234,196,48,149,231,122,242,41,208,139,22,47,119,224,2,20,63,107,33,40,209,8,5,37,61,117,212,178,118,206,192,15,242,11,57,57,153,124,143,251,95,196,179,182,27,56,64,223,126,253,215,141,152,146,202,119,152,41,168,196,198,120,216,161,105,194,167,15,60,210,155,219,236,156,46,58,27,243,189,162,147,92,30,218,229,128,120,97,58,115,50,116,121,58,159,154,196,94,242,187,34,184,33,91,236,127,242,80,253,73,189,227,86,234,28,63,127,1,82,178,4,236,76,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99c0874b-e6e1-4d26-9563-bae0f7a8c6d5"));
		}

		#endregion

	}

	#endregion

}

