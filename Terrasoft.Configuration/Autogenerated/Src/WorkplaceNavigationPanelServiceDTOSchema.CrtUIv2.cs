namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WorkplaceNavigationPanelServiceDTOSchema

	/// <exclude/>
	public class WorkplaceNavigationPanelServiceDTOSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WorkplaceNavigationPanelServiceDTOSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WorkplaceNavigationPanelServiceDTOSchema(WorkplaceNavigationPanelServiceDTOSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7e6ee3c5-590e-48d3-b5b9-30fd1fb88a29");
			Name = "WorkplaceNavigationPanelServiceDTO";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b5fa047-b3f1-455e-b921-26461fc6607e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,147,191,110,194,48,16,198,103,144,120,7,139,46,237,146,7,128,150,129,180,66,72,133,1,168,58,84,29,140,115,68,22,142,29,249,28,42,138,120,247,158,19,104,69,112,4,140,205,144,63,190,239,126,119,254,114,214,60,3,204,185,0,182,0,107,57,154,149,139,98,163,87,50,45,44,119,210,232,104,202,55,50,45,95,39,160,139,78,123,215,105,183,10,148,58,101,243,45,58,200,72,174,20,8,47,192,104,4,26,172,20,253,186,102,86,104,39,51,136,230,20,229,74,126,151,60,82,145,238,206,66,74,31,44,86,28,177,199,70,224,78,43,142,172,41,114,156,81,151,84,0,202,148,143,103,238,56,117,233,44,23,238,147,22,242,98,169,164,96,194,35,46,17,88,143,197,198,150,173,108,164,128,137,73,64,29,89,209,144,35,252,149,106,249,189,86,213,38,144,45,193,222,79,201,46,246,196,186,95,198,174,115,69,182,97,247,193,55,112,236,96,252,162,139,12,44,95,42,120,12,52,49,96,239,191,137,108,199,82,112,125,134,254,182,39,198,190,178,3,116,82,57,18,114,39,192,188,194,145,96,86,243,230,100,114,186,41,116,214,255,202,113,82,111,185,9,32,120,238,139,5,41,113,21,187,22,133,135,201,170,217,252,42,209,213,12,30,211,156,13,216,252,160,15,240,111,247,215,35,111,182,183,74,250,31,238,74,97,244,144,139,117,74,35,161,19,58,200,198,134,155,59,215,221,82,226,205,170,70,44,197,206,78,66,171,9,166,233,25,36,149,130,171,49,110,155,135,49,11,10,4,49,231,179,83,174,208,245,3,70,12,88,146,65,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7e6ee3c5-590e-48d3-b5b9-30fd1fb88a29"));
		}

		#endregion

	}

	#endregion

}

