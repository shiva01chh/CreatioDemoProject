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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,142,49,14,194,48,12,69,231,68,202,29,34,117,129,133,3,192,70,167,206,208,3,132,212,173,44,181,78,229,36,19,226,238,56,137,24,186,97,121,177,253,255,247,35,183,65,220,157,7,251,4,102,23,195,156,46,125,160,25,151,204,46,97,32,107,244,219,104,149,35,210,114,208,48,220,140,150,75,199,176,20,221,64,9,120,150,164,171,29,250,28,83,216,14,57,15,207,184,167,123,198,117,2,22,155,244,158,95,43,122,139,63,227,95,190,2,163,98,226,130,83,183,77,112,26,35,176,24,9,124,165,206,135,241,44,168,234,211,190,118,64,83,67,174,179,108,75,125,1,24,141,181,110,8,1,0,0 };
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

