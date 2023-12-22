namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExceptionExtenstionsSchema

	/// <exclude/>
	public class ExceptionExtenstionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExceptionExtenstionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExceptionExtenstionsSchema(ExceptionExtenstionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("faf2dccd-bc35-40d3-96eb-76d934e9f741");
			Name = "ExceptionExtenstions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("98782977-14c0-4cb2-aa85-be92ba3c008e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,203,106,195,48,16,69,215,14,228,31,166,161,11,155,22,65,183,205,3,66,107,66,74,219,77,250,3,138,60,73,4,242,216,213,200,121,16,252,239,149,31,73,156,180,80,173,164,209,153,59,87,87,36,83,228,92,42,132,47,180,86,114,182,114,226,37,163,149,94,23,86,58,157,81,191,119,236,247,130,130,53,173,97,113,96,135,233,240,230,236,121,99,80,85,48,139,25,18,90,173,126,49,239,154,190,125,209,151,243,98,105,180,2,118,94,94,129,50,146,25,226,189,194,188,18,136,247,14,137,43,37,79,86,131,131,220,234,173,116,120,226,231,49,21,41,90,185,52,56,58,119,77,224,21,89,33,37,146,28,79,41,89,160,89,133,110,163,59,194,128,167,93,4,181,110,144,100,237,38,56,104,52,9,88,116,133,237,112,195,230,242,124,134,241,229,78,204,201,63,51,190,70,75,216,109,180,65,8,239,194,75,147,247,64,133,49,81,84,51,101,157,192,77,4,236,108,21,212,12,221,212,152,15,100,150,107,228,127,237,111,165,189,20,249,202,220,31,97,52,227,235,166,180,157,208,109,97,225,41,255,133,97,136,143,160,35,24,79,224,126,112,212,240,0,79,229,51,28,81,180,182,202,65,43,212,134,213,88,23,111,153,166,48,166,173,182,25,165,72,78,124,226,206,127,184,215,58,13,59,63,191,137,160,132,126,175,187,126,0,244,135,126,121,134,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("faf2dccd-bc35-40d3-96eb-76d934e9f741"));
		}

		#endregion

	}

	#endregion

}

