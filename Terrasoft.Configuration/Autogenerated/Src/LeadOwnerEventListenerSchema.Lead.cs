namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LeadOwnerEventListenerSchema

	/// <exclude/>
	public class LeadOwnerEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LeadOwnerEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LeadOwnerEventListenerSchema(LeadOwnerEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("265f0b5e-a6be-455d-942d-40f04c0b5236");
			Name = "LeadOwnerEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b424f2c1-869b-44e8-aaf1-c9a818421e06");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,65,79,2,49,16,133,207,144,240,31,38,235,69,47,237,29,193,131,132,27,145,3,222,140,135,177,204,174,77,182,83,210,233,66,54,196,255,110,91,68,209,128,244,212,55,253,102,230,245,49,58,146,13,26,130,103,10,1,197,215,81,205,60,215,182,233,2,70,235,121,52,220,143,134,131,78,44,55,176,234,37,146,187,255,214,167,45,129,46,213,213,156,163,141,150,228,42,160,230,91,226,152,185,68,222,4,106,210,126,152,181,40,50,134,5,225,122,185,99,10,133,89,216,228,36,137,66,106,173,97,34,157,115,24,250,135,47,125,4,192,215,224,119,229,194,101,6,80,94,214,171,99,159,254,211,56,17,34,108,197,131,9,84,79,171,255,157,170,71,20,42,181,254,151,173,10,116,158,247,114,230,233,118,101,222,201,225,83,202,29,166,80,101,75,213,221,107,130,55,221,91,107,13,152,252,221,11,191,133,49,252,44,60,23,198,96,95,2,249,56,4,72,188,62,100,152,101,169,157,158,79,245,106,78,113,250,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("265f0b5e-a6be-455d-942d-40f04c0b5236"));
		}

		#endregion

	}

	#endregion

}

