namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailIndicatorSchema

	/// <exclude/>
	public class EmailIndicatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailIndicatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailIndicatorSchema(EmailIndicatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051");
			Name = "EmailIndicator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,77,111,211,64,16,134,207,169,212,255,48,114,47,112,113,238,180,84,2,23,69,145,0,85,13,226,130,56,76,214,147,100,213,245,174,181,51,70,42,21,255,157,217,181,99,242,81,137,64,124,177,231,227,157,121,198,179,235,177,33,110,209,16,124,161,24,145,195,74,202,42,248,149,93,119,17,197,6,127,121,241,124,121,49,233,216,250,53,44,158,88,168,185,62,176,53,223,57,50,41,153,203,25,121,138,214,28,229,60,116,94,108,67,229,66,163,232,236,207,92,91,179,52,239,42,210,90,13,168,28,50,191,129,15,13,90,55,247,181,53,40,33,230,140,233,116,10,55,220,53,13,198,167,219,193,126,160,54,18,147,23,6,74,10,144,24,186,165,35,176,91,105,185,85,78,119,164,223,238,80,80,7,148,136,70,190,171,163,85,145,53,96,82,243,163,222,147,231,220,127,68,188,143,161,165,40,150,148,243,62,11,251,248,33,96,118,204,72,217,66,4,78,239,145,10,12,182,105,246,114,212,237,226,245,124,159,168,89,82,124,245,89,119,3,111,161,24,20,197,235,196,187,5,102,137,233,247,86,125,12,210,146,38,147,53,201,117,254,224,225,227,215,169,124,75,242,102,163,225,71,248,129,174,163,127,160,27,149,251,124,214,11,188,31,139,158,139,167,203,234,208,245,108,16,86,32,155,131,69,159,8,219,215,169,130,158,198,99,220,119,57,248,53,247,56,23,152,5,229,100,210,236,201,179,141,102,133,30,140,30,83,180,158,135,177,139,240,88,164,250,133,94,212,16,139,157,90,127,164,47,205,156,81,94,60,60,139,12,121,238,168,206,178,164,73,231,119,188,29,56,223,72,6,168,109,13,62,8,52,40,102,243,95,11,203,149,230,245,71,237,177,63,66,242,220,204,58,91,223,14,183,54,231,252,101,152,43,242,117,127,149,179,221,123,247,157,217,167,207,111,54,137,237,145,25,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8e8d82a0-a320-4f28-97ed-a3ba83092051"));
		}

		#endregion

	}

	#endregion

}

