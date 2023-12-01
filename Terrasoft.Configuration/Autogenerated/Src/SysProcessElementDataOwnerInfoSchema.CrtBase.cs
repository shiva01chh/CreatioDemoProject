namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SysProcessElementDataOwnerInfoSchema

	/// <exclude/>
	public class SysProcessElementDataOwnerInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SysProcessElementDataOwnerInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SysProcessElementDataOwnerInfoSchema(SysProcessElementDataOwnerInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f11982c-9819-47d8-bc8d-e74e12e283ba");
			Name = "SysProcessElementDataOwnerInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,81,203,106,195,48,16,60,91,224,127,88,200,221,190,55,165,151,52,20,95,146,64,250,3,170,181,114,5,150,100,164,53,198,152,254,123,245,72,130,41,165,41,237,69,104,103,71,51,179,43,195,53,250,129,183,8,175,232,28,247,86,82,181,179,70,170,110,116,156,148,53,37,91,74,86,140,94,153,14,206,179,39,212,219,146,5,100,227,176,11,109,216,245,220,251,135,216,58,57,219,162,247,251,30,53,26,122,230,196,143,147,65,215,24,105,211,139,186,174,225,209,143,90,115,55,63,93,234,51,89,135,30,84,224,56,157,252,192,96,84,9,28,32,11,237,59,55,29,130,141,66,96,37,12,217,3,48,155,128,8,46,213,85,187,94,137,15,227,91,175,90,104,99,186,187,225,138,37,5,188,205,20,200,3,58,82,24,6,59,37,161,220,255,58,65,2,26,17,4,149,84,57,96,188,211,92,221,216,235,76,215,80,47,163,18,176,79,196,70,192,2,29,210,22,124,60,62,238,248,72,69,23,31,219,139,111,151,145,87,245,11,255,99,47,242,6,254,154,192,224,244,191,4,7,156,126,72,176,65,35,242,119,164,58,163,107,176,40,89,0,25,251,4,35,171,115,109,194,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f11982c-9819-47d8-bc8d-e74e12e283ba"));
		}

		#endregion

	}

	#endregion

}

