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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,49,107,195,48,16,133,231,24,252,31,4,93,218,197,218,19,227,165,148,16,104,130,161,133,204,138,116,118,68,229,147,56,73,41,161,244,191,215,146,83,135,26,170,73,79,122,247,221,187,139,94,99,207,222,174,62,192,80,61,91,99,64,6,109,209,87,91,64,32,45,55,101,17,179,229,29,136,132,183,93,24,93,216,233,62,146,72,198,234,32,46,186,207,215,61,96,28,237,101,193,57,103,181,143,195,32,232,218,76,242,104,233,195,25,33,129,41,17,4,115,100,47,90,1,177,206,18,195,153,192,156,64,48,213,141,192,239,8,23,79,70,75,166,49,0,117,137,178,155,129,247,254,109,42,110,111,228,178,248,74,81,86,15,4,125,34,239,33,156,173,242,107,214,102,84,254,91,228,204,250,213,10,229,217,231,72,247,46,53,234,201,70,231,255,203,185,90,6,157,30,8,66,36,244,205,113,137,145,243,130,107,254,107,26,139,118,47,24,7,32,113,50,80,255,221,231,54,213,53,57,213,227,211,102,154,8,80,77,67,37,249,93,22,233,252,0,146,57,197,95,199,1,0,0 };
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

