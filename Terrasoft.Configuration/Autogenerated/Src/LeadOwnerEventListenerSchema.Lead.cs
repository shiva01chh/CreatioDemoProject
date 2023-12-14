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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,144,63,111,2,49,12,197,103,144,248,14,214,117,105,151,100,167,208,161,136,13,181,3,108,85,7,55,248,174,145,46,14,138,115,160,19,226,187,147,132,210,127,130,54,83,158,243,179,253,242,24,29,201,6,13,193,138,66,64,241,117,84,51,207,181,109,186,128,209,122,30,13,247,163,225,160,19,203,13,44,123,137,228,238,63,245,247,150,64,215,234,106,206,209,70,75,242,47,160,230,91,226,152,185,68,222,4,106,210,126,152,181,40,50,134,5,225,250,121,199,20,10,179,176,201,73,18,133,212,90,195,68,58,231,48,244,15,31,250,12,128,175,193,239,202,133,203,12,160,188,172,87,231,62,253,171,113,34,68,216,138,7,19,168,158,86,127,59,85,143,40,84,106,253,15,91,21,232,60,239,229,194,211,237,210,188,147,195,167,148,59,76,161,202,150,170,187,215,4,111,186,183,214,26,48,249,187,87,126,11,99,248,90,120,41,140,193,190,4,114,56,5,72,188,62,101,152,101,169,229,115,4,134,84,117,146,242,1,0,0 };
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

