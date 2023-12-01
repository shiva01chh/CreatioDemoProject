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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,203,78,195,48,16,69,215,169,212,127,24,42,22,137,64,145,216,2,173,84,65,84,21,1,155,242,3,174,51,109,71,114,38,193,227,244,161,42,255,142,243,232,19,36,188,178,199,103,238,92,95,179,202,80,10,165,17,190,208,90,37,249,194,197,47,57,47,104,89,90,229,40,231,126,111,223,239,5,165,16,47,97,182,19,135,217,211,213,217,243,198,160,174,97,137,39,200,104,73,255,98,222,137,191,125,209,151,139,114,110,72,131,56,47,175,65,27,37,2,201,86,99,81,11,36,91,135,44,181,146,39,235,193,65,97,105,173,28,30,248,105,194,101,134,86,205,13,62,31,187,70,240,138,162,145,83,197,78,198,156,206,208,44,66,183,162,51,97,192,195,46,130,70,55,72,243,110,19,236,8,77,10,22,93,105,207,184,167,246,242,120,134,225,233,46,158,178,127,102,114,137,86,176,89,145,65,8,111,194,83,147,247,192,165,49,81,212,48,85,147,192,85,4,226,108,29,212,4,221,216,152,15,20,81,75,148,127,237,175,149,61,21,229,194,220,31,97,180,227,155,166,172,155,112,222,34,177,167,252,23,134,33,222,3,69,48,28,193,237,96,79,112,7,15,213,35,236,49,238,108,85,131,78,168,11,171,181,30,191,229,196,97,194,107,178,57,103,200,46,254,196,141,255,112,175,117,24,118,124,126,27,65,5,253,158,95,63,26,240,171,105,125,2,0,0 };
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

