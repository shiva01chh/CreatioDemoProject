namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GetGroupsOfDuplicatesParamsSchema

	/// <exclude/>
	public class GetGroupsOfDuplicatesParamsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GetGroupsOfDuplicatesParamsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GetGroupsOfDuplicatesParamsSchema(GetGroupsOfDuplicatesParamsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b7f703a5-c87f-41f4-8e13-77635795a696");
			Name = "GetGroupsOfDuplicatesParams";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,194,48,12,134,207,67,226,29,44,184,108,151,246,62,182,93,202,198,105,3,13,110,136,67,40,78,21,169,73,42,199,57,48,180,119,95,146,2,2,209,161,86,85,37,255,254,251,217,177,99,132,70,215,136,18,97,133,68,194,89,201,89,97,141,84,149,39,193,202,154,108,138,59,223,212,170,76,209,112,112,24,14,30,188,83,166,130,229,222,49,234,236,219,27,86,26,179,37,146,18,181,250,73,190,201,112,16,124,99,194,42,4,80,212,194,185,103,152,33,207,200,250,198,205,229,244,136,68,183,16,36,180,75,246,240,230,121,14,47,206,107,45,104,255,118,140,147,3,25,201,129,182,59,172,65,90,186,199,202,78,156,252,2,180,158,10,22,225,96,76,162,228,77,16,26,191,13,127,65,25,91,187,223,217,195,33,117,119,62,205,130,108,131,196,10,195,145,22,137,210,230,83,137,79,212,91,164,199,175,208,49,188,194,8,195,108,120,31,163,209,83,172,122,42,235,152,226,8,223,207,105,56,64,133,60,1,23,63,191,255,3,75,91,123,109,92,23,109,189,129,162,205,246,133,89,41,131,229,154,165,12,195,60,233,253,91,10,55,224,22,82,68,185,47,131,109,115,49,120,164,180,141,91,230,170,203,214,183,134,84,117,188,68,157,139,248,104,115,93,168,49,154,93,187,249,20,183,234,181,24,180,203,231,15,167,218,49,157,84,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b7f703a5-c87f-41f4-8e13-77635795a696"));
		}

		#endregion

	}

	#endregion

}

