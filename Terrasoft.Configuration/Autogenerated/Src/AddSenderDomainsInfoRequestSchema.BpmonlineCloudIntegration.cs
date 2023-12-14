namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddSenderDomainsInfoRequestSchema

	/// <exclude/>
	public class AddSenderDomainsInfoRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddSenderDomainsInfoRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddSenderDomainsInfoRequestSchema(AddSenderDomainsInfoRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7cef863d-9684-4a82-a74b-e9746da57616");
			Name = "AddSenderDomainsInfoRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,194,64,20,60,75,194,127,120,41,23,189,180,119,62,76,20,140,241,128,33,192,205,120,88,218,215,186,73,187,91,223,219,98,144,248,223,221,15,64,4,2,161,151,246,77,103,166,111,102,171,68,133,92,139,20,97,142,68,130,117,110,226,161,86,185,44,26,18,70,106,21,15,159,102,99,157,97,201,237,214,186,221,106,183,110,26,150,170,128,217,138,13,86,241,180,81,70,86,24,207,144,164,40,229,183,215,244,60,175,67,88,216,1,134,165,96,238,194,67,150,205,80,101,72,35,93,9,169,248,69,229,122,138,159,13,178,241,244,36,73,160,207,77,85,9,90,221,111,102,47,133,92,19,80,96,130,209,32,178,12,20,126,1,123,55,200,188,93,188,117,72,14,44,250,140,40,74,214,144,18,230,131,232,98,202,248,81,48,218,52,75,153,226,102,189,8,18,231,246,54,18,70,88,149,33,145,154,119,11,212,205,162,148,41,164,126,201,51,241,160,11,199,166,86,31,234,220,245,52,33,93,35,25,137,182,172,137,183,14,239,15,139,241,192,51,26,6,219,11,187,187,249,192,189,26,142,123,8,200,82,148,13,238,198,249,41,205,31,197,135,29,99,181,64,186,125,181,255,8,12,32,10,244,232,206,101,223,134,103,67,238,111,8,161,97,13,5,154,158,91,170,7,63,215,108,175,220,39,116,238,159,107,210,75,105,139,188,46,203,5,135,243,201,182,2,55,159,204,55,217,35,156,74,217,177,71,31,142,209,207,1,253,15,122,204,93,191,116,216,167,217,115,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7cef863d-9684-4a82-a74b-e9746da57616"));
		}

		#endregion

	}

	#endregion

}

