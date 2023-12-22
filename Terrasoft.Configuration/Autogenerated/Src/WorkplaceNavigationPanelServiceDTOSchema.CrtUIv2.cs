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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,213,147,191,110,194,48,16,198,103,144,120,7,139,46,237,146,7,128,150,129,180,66,72,133,1,168,58,84,29,140,115,68,22,142,29,157,29,42,138,120,247,158,19,104,75,112,84,24,155,33,127,124,223,253,238,252,229,172,121,6,54,231,2,216,2,16,185,53,43,23,197,70,175,100,90,32,119,210,232,104,202,55,50,45,95,39,160,139,78,123,215,105,183,10,43,117,202,230,91,235,32,35,185,82,32,188,192,70,35,208,128,82,244,235,154,89,161,157,204,32,154,83,148,43,249,89,242,72,69,186,27,132,148,62,88,172,184,181,61,54,2,119,90,113,132,166,200,237,140,186,164,2,80,166,188,61,114,199,169,75,135,92,184,119,90,200,139,165,146,130,9,143,248,139,192,122,44,54,88,182,178,145,2,38,38,1,117,100,69,67,110,225,167,84,203,239,181,170,54,129,108,9,120,59,37,187,216,3,235,126,24,92,231,138,108,179,221,59,223,192,177,131,241,147,46,50,64,190,84,112,31,104,98,192,94,191,19,217,142,165,224,250,204,250,219,158,24,251,202,14,208,73,229,72,200,157,0,243,2,71,130,89,205,155,147,201,233,166,172,67,255,43,199,73,189,229,38,128,224,185,47,22,164,196,85,236,82,148,61,76,86,205,230,103,105,93,205,224,49,205,217,128,205,15,250,0,255,122,127,61,242,106,123,171,164,255,225,174,20,70,15,185,88,167,52,18,58,161,131,108,48,220,220,185,238,154,18,47,168,26,177,20,59,59,9,173,38,152,166,103,144,84,10,46,198,184,109,30,198,44,40,16,196,156,207,78,185,242,235,250,2,250,156,224,160,73,5,0,0 };
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

