namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapExceptionSchema

	/// <exclude/>
	public class ImapExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapExceptionSchema(ImapExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("136f52d1-b451-48cb-a9cb-2a36268a593c");
			Name = "ImapException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("80eb4b00-d20b-4335-a2cc-1f02c0e63f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,65,10,194,48,16,69,215,41,244,14,3,221,40,20,15,80,151,226,194,133,32,232,5,166,113,44,129,54,41,153,20,148,226,221,77,82,181,70,92,152,221,252,121,188,252,209,216,17,247,40,9,78,100,45,178,185,184,213,30,85,155,103,99,158,137,129,149,110,224,120,99,71,221,58,207,124,82,88,106,148,209,176,105,145,185,130,93,135,253,246,42,169,119,62,140,64,63,212,173,146,32,195,62,93,67,5,31,168,24,35,62,11,141,102,103,7,233,140,245,222,67,180,76,196,211,152,184,22,158,13,213,124,121,198,134,150,129,19,21,212,200,180,120,101,16,46,16,247,191,37,229,92,15,148,214,100,223,227,47,125,249,205,36,223,21,164,207,211,97,113,158,210,52,244,153,127,15,53,73,133,2,128,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("136f52d1-b451-48cb-a9cb-2a36268a593c"));
		}

		#endregion

	}

	#endregion

}

