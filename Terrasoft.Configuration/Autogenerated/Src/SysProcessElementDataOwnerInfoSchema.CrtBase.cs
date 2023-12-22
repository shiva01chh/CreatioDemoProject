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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,81,203,106,195,48,16,60,219,224,127,88,200,221,190,55,165,151,52,20,95,146,64,250,3,170,181,82,5,214,202,72,50,198,152,254,123,245,72,130,41,165,41,173,14,66,154,29,205,204,174,136,105,116,3,235,16,94,209,90,230,140,240,245,206,144,80,114,180,204,43,67,85,185,84,101,49,58,69,18,206,179,243,168,183,85,25,144,141,69,25,202,176,235,153,115,15,177,116,178,166,67,231,246,61,106,36,255,204,60,59,78,132,182,37,97,210,139,166,105,224,209,141,90,51,59,63,93,238,103,111,44,58,80,129,99,117,242,3,194,168,18,56,224,13,116,239,140,36,130,137,66,96,4,12,217,3,48,155,0,15,46,245,85,187,89,137,15,227,91,175,58,232,98,186,187,225,138,37,5,188,245,20,200,3,90,175,48,52,118,74,66,185,254,181,131,4,180,60,8,42,161,114,192,120,246,115,125,99,175,51,93,67,189,140,138,195,62,17,91,14,11,72,244,91,112,113,251,184,227,35,148,191,248,152,158,127,59,140,60,170,95,248,31,123,158,39,240,215,4,132,211,255,18,28,112,250,33,193,6,137,231,239,72,247,140,174,193,162,42,3,184,90,159,217,17,29,240,203,2,0,0 };
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

