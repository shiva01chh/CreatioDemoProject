namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IDeduplicationRemindingRepositorySchema

	/// <exclude/>
	public class IDeduplicationRemindingRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IDeduplicationRemindingRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IDeduplicationRemindingRepositorySchema(IDeduplicationRemindingRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de0d4303-7aff-4f8a-be80-67a2241441e9");
			Name = "IDeduplicationRemindingRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,110,194,48,12,134,207,32,241,14,86,79,155,132,218,7,24,235,5,46,187,76,83,25,15,16,26,183,100,90,146,202,73,144,208,180,119,159,83,74,73,7,154,214,67,84,219,241,239,207,191,98,132,70,215,137,26,225,29,137,132,179,141,207,215,214,52,170,13,36,188,178,38,223,160,12,221,167,170,251,104,49,255,90,204,103,193,41,211,78,26,8,159,22,115,174,20,69,1,43,23,180,22,116,42,135,248,141,236,81,73,116,160,209,31,172,132,198,18,104,97,68,27,69,100,170,14,132,90,25,201,121,151,95,196,138,68,173,11,123,190,10,202,120,164,38,50,191,76,224,170,75,119,133,157,117,202,91,58,113,83,4,190,225,234,19,107,66,225,153,171,159,218,211,236,79,208,170,35,38,32,12,232,106,82,93,212,95,130,11,251,15,172,61,8,35,167,228,23,73,87,31,80,11,48,236,106,62,206,45,126,15,94,117,130,132,238,111,61,103,193,33,177,227,134,117,89,40,43,119,28,67,61,38,242,85,209,223,190,223,60,114,110,174,152,89,89,221,163,255,167,208,246,188,98,42,50,108,253,183,192,121,243,87,254,207,202,109,226,66,218,116,180,74,14,174,143,234,15,187,201,254,48,181,131,45,247,20,25,238,45,122,91,28,224,151,113,216,108,40,94,193,30,249,141,206,190,227,59,229,35,253,126,0,160,18,245,220,5,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de0d4303-7aff-4f8a-be80-67a2241441e9"));
		}

		#endregion

	}

	#endregion

}

