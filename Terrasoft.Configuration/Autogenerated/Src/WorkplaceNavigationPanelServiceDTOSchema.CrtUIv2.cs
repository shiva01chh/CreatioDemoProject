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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,147,191,110,194,48,16,198,103,34,245,29,44,186,180,75,30,0,90,6,210,10,33,21,6,160,234,80,117,56,156,35,178,112,236,200,118,168,40,226,221,123,78,160,21,193,81,97,236,146,127,247,249,119,159,191,156,21,228,104,11,224,200,22,104,12,88,189,114,113,162,213,74,100,165,1,39,180,138,167,176,17,89,245,56,65,85,222,68,187,155,168,83,90,161,50,54,223,90,135,57,201,165,68,238,5,54,30,161,66,35,120,191,169,153,149,202,137,28,227,57,85,65,138,175,138,71,42,210,221,26,204,232,133,37,18,172,237,177,17,186,211,142,35,163,203,194,206,200,37,53,192,106,201,251,19,56,32,151,206,0,119,31,244,161,40,151,82,112,198,61,226,47,2,235,177,68,155,202,202,70,112,156,232,20,229,145,21,15,193,226,111,171,142,223,107,221,109,130,249,18,205,221,148,226,98,143,172,251,169,205,186,144,20,155,237,222,123,3,71,7,227,103,85,230,104,96,41,241,33,96,98,192,222,126,22,178,29,203,208,245,153,245,151,61,49,246,117,28,168,210,58,145,80,58,1,230,5,137,4,87,181,111,78,164,167,155,178,206,248,95,57,78,155,150,219,0,28,10,223,44,72,73,234,218,165,40,123,152,172,70,204,47,194,186,70,192,99,154,179,1,155,31,244,1,254,245,249,122,228,213,241,214,139,254,71,186,130,107,53,4,190,206,104,36,84,74,7,89,155,176,185,115,221,53,45,94,141,108,197,82,237,236,36,116,218,96,138,238,65,82,37,184,24,227,182,69,24,179,160,66,16,115,62,59,213,151,40,250,6,224,173,232,133,64,5,0,0 };
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

