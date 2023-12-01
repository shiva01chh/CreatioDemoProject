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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,142,49,14,194,48,12,69,231,84,202,29,34,117,129,133,3,192,70,167,206,208,3,132,212,173,44,181,78,228,36,19,226,238,56,141,24,178,97,121,177,253,255,247,35,187,67,12,214,129,121,2,179,141,126,73,151,193,211,130,107,102,155,208,147,209,221,91,119,42,71,164,181,209,48,220,116,39,151,158,97,45,186,145,18,240,34,73,87,51,14,57,38,191,55,57,15,199,24,210,61,227,54,3,139,77,58,228,215,134,206,224,207,248,151,175,192,168,152,184,224,28,219,42,56,77,17,88,140,4,238,160,206,205,120,22,84,245,169,95,123,160,185,34,31,179,108,165,190,187,143,225,209,7,1,0,0 };
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

