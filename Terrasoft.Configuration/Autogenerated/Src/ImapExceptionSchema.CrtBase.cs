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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,65,10,194,48,16,69,215,41,244,14,3,221,84,40,30,160,46,197,133,11,65,208,11,164,113,44,129,54,9,153,20,148,226,221,77,82,181,141,184,48,187,249,243,120,249,163,120,143,100,184,64,56,163,181,156,244,213,173,15,92,118,121,54,230,25,27,72,170,22,78,119,114,216,111,242,204,39,133,197,86,106,5,219,142,19,213,176,239,185,217,221,4,26,231,195,8,152,161,233,164,0,17,246,233,26,106,88,160,108,140,248,44,212,138,156,29,132,211,214,123,143,209,50,17,47,99,226,42,61,27,170,249,242,196,91,92,5,142,213,208,112,194,242,157,65,184,128,61,254,150,84,115,61,144,74,161,253,140,191,244,213,55,147,124,87,160,186,76,135,197,121,74,211,208,103,203,247,4,82,186,62,16,137,1,0,0 };
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

