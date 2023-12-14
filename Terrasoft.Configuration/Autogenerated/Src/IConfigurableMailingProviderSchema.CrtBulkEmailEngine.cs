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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,191,14,130,48,16,135,103,72,120,135,75,92,116,129,29,141,139,147,3,137,131,47,80,202,129,151,208,150,92,139,137,49,190,187,149,22,252,179,216,169,247,107,239,235,119,213,66,161,29,132,68,56,35,179,176,166,117,249,193,232,150,186,145,133,35,163,243,74,80,79,186,203,210,123,150,102,105,178,98,236,124,12,71,237,144,91,223,88,194,113,105,168,123,140,215,79,108,174,212,32,79,61,69,81,192,206,142,74,9,190,237,99,29,47,88,80,232,46,166,177,224,12,200,200,65,80,129,2,67,196,228,51,165,248,192,12,99,221,147,4,154,77,254,136,36,97,128,101,130,42,60,92,194,105,226,132,195,95,213,41,152,177,222,214,11,13,200,142,252,214,180,32,71,102,212,206,43,88,39,180,196,124,65,124,122,38,87,67,205,27,178,222,108,163,8,234,38,184,76,245,35,252,239,87,232,179,215,122,2,11,247,64,140,166,1,0,0 };
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

