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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,106,195,48,12,134,207,13,244,29,68,78,27,148,228,1,214,229,210,94,118,25,35,93,31,192,137,149,212,99,182,131,108,23,202,216,187,79,78,211,52,89,203,88,14,38,146,172,95,159,126,108,132,70,215,137,26,225,29,137,132,179,141,207,54,214,52,170,13,36,188,178,38,219,162,12,221,167,170,251,104,153,124,45,147,69,112,202,180,179,6,194,167,101,194,149,60,207,97,237,130,214,130,78,197,16,191,145,61,42,137,14,52,250,131,149,208,88,2,45,140,104,163,136,156,170,3,161,86,70,114,222,101,23,177,124,162,214,133,138,175,130,50,30,169,137,204,47,51,184,242,210,93,98,103,157,242,150,78,220,20,129,111,184,250,196,134,80,120,230,234,167,246,52,213,9,90,117,196,9,8,3,186,154,84,23,245,87,224,66,245,129,181,7,97,228,156,252,34,233,234,3,106,1,134,93,205,198,185,249,239,193,235,78,144,208,253,173,231,52,56,36,118,220,176,46,11,165,197,158,99,168,199,68,182,206,251,219,247,155,71,206,237,21,51,45,202,123,244,255,20,218,157,87,156,138,12,91,255,45,112,222,252,149,255,211,98,55,113,97,218,116,180,74,14,174,143,234,15,251,217,254,48,183,131,45,247,20,25,238,45,122,91,28,224,87,113,216,98,40,94,193,30,249,141,46,190,227,59,229,35,126,63,179,0,108,80,253,2,0,0 };
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

