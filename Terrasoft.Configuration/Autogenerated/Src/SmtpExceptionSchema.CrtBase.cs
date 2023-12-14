namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SmtpExceptionSchema

	/// <exclude/>
	public class SmtpExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SmtpExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SmtpExceptionSchema(SmtpExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f9b38078-c13e-40e2-9656-40242891b8a4");
			Name = "SmtpException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,81,209,74,196,48,16,124,110,161,255,176,112,47,39,20,63,160,135,15,162,247,40,28,212,31,200,197,181,4,218,36,236,110,196,227,240,223,77,210,214,179,229,16,17,3,129,236,108,102,118,134,181,106,64,246,74,35,60,35,145,98,247,42,183,79,202,244,85,121,174,202,34,176,177,29,180,39,22,28,118,85,25,145,13,97,103,156,133,135,94,49,55,208,14,226,247,239,26,189,68,48,127,240,225,216,27,13,58,245,151,109,104,224,222,251,216,84,169,186,192,105,80,145,238,172,125,32,231,145,196,96,28,112,8,137,145,149,103,105,22,74,174,246,67,180,217,162,125,105,69,73,224,81,166,232,80,118,249,225,201,188,41,65,224,9,248,24,53,54,145,48,142,153,234,57,143,179,81,55,104,113,116,125,234,34,202,118,242,128,75,15,53,92,199,31,145,53,153,204,188,201,230,26,56,42,198,237,15,223,166,56,235,144,119,107,233,239,217,254,215,105,13,151,21,25,107,145,190,202,95,102,168,215,180,191,100,90,237,107,68,151,96,196,210,249,4,49,210,194,47,202,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f9b38078-c13e-40e2-9656-40242891b8a4"));
		}

		#endregion

	}

	#endregion

}

