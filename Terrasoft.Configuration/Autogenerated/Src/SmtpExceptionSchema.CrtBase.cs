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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,81,209,74,196,48,16,124,110,161,255,176,112,47,39,20,63,160,135,15,162,247,120,112,80,127,32,23,215,18,104,147,176,187,17,69,252,119,147,180,245,174,229,16,17,3,129,236,108,102,118,134,181,106,64,246,74,35,60,33,145,98,247,34,183,7,101,250,170,252,168,202,34,176,177,29,180,239,44,56,236,170,50,34,27,194,206,56,11,15,189,98,110,160,29,196,239,223,52,122,137,96,254,224,195,169,55,26,116,234,47,219,208,192,189,247,177,169,82,117,134,211,160,34,221,89,251,72,206,35,137,193,56,224,24,18,35,43,207,210,44,148,92,237,135,104,179,69,251,220,138,146,192,163,76,209,161,236,242,195,147,121,85,130,192,19,240,57,106,108,34,97,28,51,213,115,30,103,163,110,208,226,232,250,212,69,148,237,228,1,151,30,106,184,142,63,34,107,50,153,121,147,205,53,112,82,140,219,31,190,77,113,214,33,239,214,210,151,217,254,215,105,13,231,21,25,107,145,190,203,95,102,168,215,180,191,100,90,237,107,68,151,96,196,46,207,23,235,133,35,169,210,2,0,0 };
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

