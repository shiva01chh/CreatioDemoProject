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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,79,194,64,20,60,75,194,127,120,41,23,189,180,119,62,76,180,24,227,1,67,40,55,227,97,105,95,235,38,237,110,125,111,139,65,226,127,119,187,11,136,64,32,244,210,190,233,204,244,205,108,149,168,144,107,145,34,204,145,72,176,206,77,24,107,149,203,162,33,97,164,86,97,252,148,76,116,134,37,119,59,235,110,167,219,185,105,88,170,2,146,21,27,172,194,89,163,140,172,48,76,144,164,40,229,183,211,12,28,175,71,88,216,1,226,82,48,247,225,33,203,18,84,25,210,88,87,66,42,126,81,185,158,225,103,131,108,28,61,138,34,24,114,83,85,130,86,247,155,217,73,33,215,4,228,153,96,52,136,44,3,133,95,192,206,13,50,103,23,110,29,162,3,139,33,35,138,146,53,164,132,249,40,184,152,50,124,20,140,54,205,82,166,184,89,47,128,168,117,123,27,11,35,172,202,144,72,205,187,5,234,102,81,202,20,82,183,228,153,120,208,135,99,83,171,247,117,238,122,154,146,174,145,140,68,91,214,212,89,251,247,135,197,56,224,25,13,131,237,133,219,187,249,192,189,26,142,123,240,200,82,148,13,238,198,249,41,205,31,197,133,157,96,181,64,186,125,181,255,8,140,32,240,244,224,174,205,190,13,207,134,218,191,193,135,134,53,20,104,6,237,82,3,248,185,102,123,213,126,66,231,238,185,38,189,148,182,200,235,178,92,112,56,159,108,43,104,231,147,249,166,123,132,83,41,123,246,232,253,49,186,217,163,255,65,135,217,235,23,197,216,232,126,114,3,0,0 };
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

