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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,49,107,195,48,16,133,231,24,252,31,4,93,218,197,218,19,227,165,148,16,104,138,161,133,204,138,116,118,69,229,147,56,73,9,161,244,191,215,146,83,167,53,84,147,158,244,238,187,119,23,189,198,158,189,94,124,128,161,122,180,198,128,12,218,162,175,182,128,64,90,110,202,34,102,203,27,16,9,111,187,48,186,176,211,125,36,145,140,213,139,56,233,62,95,247,128,113,180,151,5,231,156,213,62,14,131,160,75,51,201,131,165,15,103,132,4,166,68,16,204,145,61,105,5,196,58,75,12,103,2,115,2,193,84,87,2,191,33,92,60,26,45,153,198,0,212,37,202,110,6,222,250,183,169,184,189,146,203,226,51,69,89,221,17,244,137,188,135,240,110,149,95,179,54,163,242,223,34,103,214,207,86,40,207,206,35,221,187,212,168,39,27,157,255,47,231,106,25,116,122,32,8,145,208,55,135,37,70,206,11,174,249,143,105,44,218,61,97,28,128,196,209,64,253,119,159,219,84,215,228,84,247,15,155,105,34,64,53,13,149,228,87,89,252,62,223,30,71,145,104,207,1,0,0 };
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

