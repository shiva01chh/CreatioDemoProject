namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICustomConfigurationScriptBuilderSchema

	/// <exclude/>
	public class ICustomConfigurationScriptBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICustomConfigurationScriptBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICustomConfigurationScriptBuilderSchema(ICustomConfigurationScriptBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9b66793-dace-4458-a258-e4f09a3b7b8b");
			Name = "ICustomConfigurationScriptBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,142,49,14,194,48,12,69,231,68,234,29,34,117,129,133,3,192,70,167,206,192,1,66,234,86,150,90,39,114,146,9,113,119,156,68,72,116,195,242,98,251,255,239,71,118,131,24,172,3,115,7,102,27,253,156,78,131,167,25,151,204,54,161,39,211,233,87,167,85,142,72,203,78,195,112,233,180,92,122,134,165,232,70,74,192,179,36,157,205,56,228,152,252,182,203,185,57,198,144,174,25,215,9,88,108,210,33,63,87,116,6,191,198,191,124,5,70,197,196,5,167,110,155,224,240,136,192,98,36,112,149,58,239,198,163,160,170,119,251,218,3,77,13,185,206,178,253,173,15,72,41,51,233,16,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9b66793-dace-4458-a258-e4f09a3b7b8b"));
		}

		#endregion

	}

	#endregion

}

