namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactMLangBinderSchema

	/// <exclude/>
	public class ContactMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactMLangBinderSchema(ContactMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("28c6993a-5103-498a-bc0d-ef34c1059002");
			Name = "ContactMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,223,107,194,48,16,126,86,240,127,56,220,139,131,209,190,171,8,83,54,16,42,27,108,176,231,180,61,187,64,147,148,228,82,38,178,255,125,215,36,29,186,153,151,144,251,126,220,125,23,45,20,186,78,84,8,239,104,173,112,230,72,217,206,232,163,108,188,21,36,141,158,77,207,179,233,196,59,169,155,43,138,197,236,89,84,100,172,68,183,186,193,248,192,146,89,74,25,205,40,227,119,22,27,182,131,93,43,156,91,2,247,32,150,31,10,161,155,173,212,53,218,192,202,243,28,214,206,43,37,236,105,147,222,137,10,202,183,36,91,230,123,209,32,84,131,15,148,65,154,141,202,252,66,218,249,178,149,85,226,253,111,7,75,120,236,186,167,30,53,21,210,17,106,180,91,225,144,133,231,48,201,239,192,7,164,79,83,243,200,175,193,48,130,201,220,244,156,87,214,8,189,145,53,188,104,118,124,35,97,105,49,90,15,125,241,139,160,138,247,61,12,203,156,76,74,238,148,93,208,71,120,21,208,176,162,184,220,83,54,76,187,222,23,41,246,158,144,191,197,216,135,49,209,95,96,179,152,39,100,30,221,190,83,26,212,117,12,20,222,177,122,93,228,26,159,31,23,33,184,80,17,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("28c6993a-5103-498a-bc0d-ef34c1059002"));
		}

		#endregion

	}

	#endregion

}

