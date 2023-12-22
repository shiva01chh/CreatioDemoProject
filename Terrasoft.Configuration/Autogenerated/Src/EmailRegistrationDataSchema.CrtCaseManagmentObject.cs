namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailRegistrationDataSchema

	/// <exclude/>
	public class EmailRegistrationDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailRegistrationDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailRegistrationDataSchema(EmailRegistrationDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("472ffed7-d0b2-439a-902c-a1ccb20b2456");
			Name = "EmailRegistrationData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,77,107,195,48,12,61,167,208,255,32,218,203,6,163,185,175,31,48,186,49,122,24,148,109,127,64,75,148,32,104,156,96,59,133,82,246,223,39,59,105,235,182,233,8,91,78,145,172,167,247,100,61,43,44,200,84,152,16,124,146,214,104,202,204,78,150,165,202,56,175,53,90,46,213,112,176,31,14,162,218,176,202,225,99,103,44,21,211,225,64,50,99,77,185,28,195,114,131,198,60,194,75,129,188,121,151,148,177,13,238,25,45,74,89,28,199,48,51,117,81,160,222,45,218,88,250,91,100,69,26,178,82,3,57,36,136,10,131,57,153,201,1,19,7,160,170,254,218,112,2,137,163,186,201,228,100,30,85,173,117,89,145,182,76,34,109,237,209,94,244,149,28,159,88,165,164,44,103,44,130,202,12,18,77,104,41,133,167,196,242,150,237,110,114,196,133,146,14,154,94,107,62,149,174,210,104,15,57,217,41,84,154,183,210,5,140,4,209,119,111,110,63,219,91,115,21,110,172,30,220,221,156,208,159,179,66,45,225,95,168,215,30,217,98,86,41,252,111,118,113,197,150,180,241,43,237,65,30,150,59,110,119,30,121,126,199,235,162,254,212,135,149,39,104,168,15,181,148,157,198,13,175,123,76,42,109,28,232,226,208,144,34,87,252,90,39,182,212,189,44,41,213,168,228,85,138,186,153,33,114,18,179,249,168,211,251,163,120,1,118,87,5,202,101,165,88,128,146,167,61,31,97,194,182,241,230,104,113,62,245,209,224,179,216,3,22,157,120,190,194,93,57,229,87,124,117,110,146,203,102,183,220,119,213,179,107,27,157,215,113,231,119,116,26,251,161,89,26,31,126,46,4,221,183,214,57,189,97,152,7,104,239,164,200,39,185,13,46,109,63,191,108,25,186,47,116,68,155,11,83,146,9,191,31,151,0,150,225,142,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("472ffed7-d0b2-439a-902c-a1ccb20b2456"));
		}

		#endregion

	}

	#endregion

}

