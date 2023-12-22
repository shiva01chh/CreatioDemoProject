namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IConfigurableMailingProviderSchema

	/// <exclude/>
	public class IConfigurableMailingProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IConfigurableMailingProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IConfigurableMailingProviderSchema(IConfigurableMailingProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cc13a695-7766-435a-88b7-db1edaea23f9");
			Name = "IConfigurableMailingProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5d774dd3-3f0d-4e5d-9409-9a3b17d3417e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,177,14,130,48,16,134,103,72,120,135,75,92,116,129,29,141,139,147,3,137,131,47,80,202,129,151,208,150,92,139,137,49,190,187,13,45,136,46,118,234,253,237,125,253,174,90,40,180,131,144,8,87,100,22,214,180,46,63,25,221,82,55,178,112,100,116,94,9,234,73,119,89,250,204,210,44,77,54,140,157,143,225,172,29,114,235,27,75,56,47,13,117,143,241,250,133,205,157,26,228,169,167,40,10,56,216,81,41,193,143,99,172,227,5,11,10,221,205,52,22,156,1,25,57,8,42,80,96,136,152,124,166,20,43,204,48,214,61,73,160,217,228,143,72,18,6,88,38,168,194,195,37,92,38,78,56,252,85,157,130,25,235,109,189,208,128,236,200,111,77,11,114,100,70,237,188,130,117,66,75,204,23,196,218,51,185,27,106,62,144,237,110,31,69,80,55,193,101,170,95,225,127,191,66,159,173,215,27,240,140,84,68,174,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cc13a695-7766-435a-88b7-db1edaea23f9"));
		}

		#endregion

	}

	#endregion

}

