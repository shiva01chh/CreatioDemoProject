namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactSelectModelSchema

	/// <exclude/>
	public class ContactSelectModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactSelectModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactSelectModelSchema(ContactSelectModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c995aa53-261b-474b-b723-c7bbe16e4062");
			Name = "ContactSelectModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bb225b1d-9856-4e2d-8d05-b81de9745531");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,209,74,196,48,16,69,159,187,224,63,12,236,171,180,239,174,8,90,101,17,84,86,182,126,64,76,167,109,160,77,234,100,178,80,22,255,221,36,237,46,93,145,218,135,144,153,228,222,57,205,213,162,67,219,11,137,80,32,145,176,166,226,52,55,186,82,181,35,193,202,232,171,213,241,106,149,56,171,116,13,251,193,50,118,155,115,157,27,194,244,241,193,55,124,107,77,88,251,251,144,183,194,218,27,127,166,89,72,222,99,139,146,95,77,137,109,188,149,101,25,220,90,215,117,130,134,187,169,46,134,30,193,84,39,201,187,67,26,118,100,14,170,68,2,66,235,90,14,199,91,156,187,65,135,220,152,50,61,121,102,51,211,222,125,182,74,130,12,36,127,130,36,199,8,115,102,246,211,122,36,86,232,193,119,81,60,158,255,166,141,141,143,231,50,224,248,199,216,203,6,59,1,149,33,16,174,84,168,101,252,143,23,20,229,53,60,29,80,115,33,168,70,6,100,153,158,253,230,164,39,212,173,83,37,220,79,30,163,109,24,115,4,175,222,128,13,203,247,2,82,209,32,104,159,228,236,21,189,90,154,214,117,122,121,176,101,26,147,156,68,121,212,188,5,175,144,123,146,4,128,184,177,211,102,137,35,70,7,220,8,246,185,177,35,109,65,64,171,44,207,192,192,105,245,229,16,124,186,154,85,165,144,236,50,226,152,220,101,142,255,192,173,81,151,99,180,177,30,187,151,77,223,243,223,15,142,11,251,249,255,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c995aa53-261b-474b-b723-c7bbe16e4062"));
		}

		#endregion

	}

	#endregion

}

