namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IWorkplaceNavigationPanelProviderSchema

	/// <exclude/>
	public class IWorkplaceNavigationPanelProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IWorkplaceNavigationPanelProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IWorkplaceNavigationPanelProviderSchema(IWorkplaceNavigationPanelProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8254b1c8-62eb-4388-85ee-c89cb0aa6a53");
			Name = "IWorkplaceNavigationPanelProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b5fa047-b3f1-455e-b921-26461fc6607e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,49,107,195,48,16,133,231,24,252,31,4,93,218,197,222,19,227,165,148,16,104,130,161,133,204,138,117,86,68,229,147,56,73,41,161,244,191,87,146,83,135,26,170,73,79,122,247,221,187,11,78,161,100,111,87,231,97,172,158,141,214,208,123,101,208,85,91,64,32,213,111,202,34,100,203,59,16,113,103,6,31,93,56,40,25,136,39,99,117,224,23,37,243,117,15,24,162,189,44,234,186,102,141,11,227,200,233,218,78,242,104,232,195,106,222,3,19,220,115,102,201,92,148,0,98,131,33,134,51,129,89,142,160,171,27,161,190,35,108,56,105,213,51,133,30,104,72,148,221,12,188,247,239,82,113,119,35,151,197,87,138,178,122,32,144,137,188,7,127,54,194,173,89,151,81,249,111,145,51,235,87,195,133,99,159,145,238,108,106,36,201,4,235,254,203,185,90,6,157,30,8,124,32,116,237,113,137,233,231,5,55,245,175,41,22,237,94,48,140,64,252,164,161,249,187,207,109,170,107,115,170,199,167,205,52,17,160,152,134,74,242,187,44,226,249,1,21,234,219,207,198,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8254b1c8-62eb-4388-85ee-c89cb0aa6a53"));
		}

		#endregion

	}

	#endregion

}

