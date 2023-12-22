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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,77,107,195,48,12,61,167,208,255,32,186,75,7,35,185,183,165,176,150,13,10,41,27,108,176,179,147,168,153,33,182,131,173,132,149,178,255,62,197,118,70,186,213,23,99,189,15,233,201,90,40,116,173,40,17,222,209,90,225,204,137,210,189,209,39,89,119,86,144,52,122,62,187,204,103,73,231,164,174,175,40,22,211,103,81,146,177,18,221,250,6,227,3,11,102,41,101,52,163,140,223,89,172,217,14,246,141,112,110,5,220,131,88,126,204,133,174,119,82,87,104,61,43,203,50,216,184,78,41,97,207,219,248,142,84,80,93,67,178,97,126,39,106,132,114,240,129,194,75,211,81,153,77,164,109,87,52,178,140,188,255,237,96,5,143,109,251,212,163,166,92,58,66,141,118,39,28,178,240,226,39,249,29,248,136,244,105,42,30,249,213,27,6,48,154,155,158,243,202,10,161,55,178,130,23,205,142,111,36,44,45,71,235,161,47,126,17,148,225,190,135,97,153,73,82,112,167,116,66,31,225,181,71,253,138,194,114,207,233,48,237,230,144,199,216,7,66,254,22,99,31,198,68,127,129,237,114,17,145,69,112,251,142,105,80,87,33,144,127,135,234,117,145,107,211,243,3,23,198,197,55,26,2,0,0 };
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

