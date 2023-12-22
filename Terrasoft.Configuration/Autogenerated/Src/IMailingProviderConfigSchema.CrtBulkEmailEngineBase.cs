namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingProviderConfigSchema

	/// <exclude/>
	public class IMailingProviderConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingProviderConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingProviderConfigSchema(IMailingProviderConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468");
			Name = "IMailingProviderConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,203,106,195,48,16,60,203,224,127,88,210,187,117,79,210,92,10,5,31,2,129,230,7,84,101,229,10,172,7,43,185,96,66,254,61,170,36,7,55,16,157,118,103,103,103,102,101,133,193,224,133,68,56,35,145,8,78,197,238,195,89,165,135,137,68,212,206,182,205,181,109,216,20,180,29,224,107,14,17,205,174,109,18,242,70,56,164,49,244,54,34,169,36,176,133,254,40,244,152,120,39,114,191,250,130,84,116,50,155,115,14,251,48,25,35,104,62,212,190,210,2,200,204,3,167,32,254,32,152,34,2,190,170,116,203,58,95,237,251,233,123,212,18,244,98,254,210,155,93,179,255,35,110,154,123,164,168,49,108,225,148,69,202,252,57,96,6,122,27,162,176,73,189,70,219,7,68,144,132,234,125,179,248,157,209,248,81,68,252,20,50,58,154,55,252,208,61,228,214,129,217,139,5,120,238,255,126,155,177,1,227,46,23,161,22,183,122,6,218,75,185,36,247,5,253,15,102,108,253,238,72,216,216,103,227,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6ab8d5ed-b75b-496a-b8f0-ba3fbf460468"));
		}

		#endregion

	}

	#endregion

}

