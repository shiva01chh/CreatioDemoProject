namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RequestTokenExceptionSchema

	/// <exclude/>
	public class RequestTokenExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RequestTokenExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RequestTokenExceptionSchema(RequestTokenExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7333162c-1720-409d-8f39-077934931a56");
			Name = "RequestTokenException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fc1a2769-1cc9-44d3-a1a6-003d1b8450f5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,207,74,195,64,16,198,207,41,244,29,134,246,210,66,201,3,52,212,131,33,7,15,66,177,189,137,135,109,50,13,139,155,217,56,179,81,107,233,187,187,155,196,90,109,14,98,32,129,249,247,251,230,27,66,170,66,169,85,142,176,69,102,37,118,239,226,212,210,94,151,13,43,167,45,197,183,117,101,201,104,194,212,216,166,184,35,135,101,87,25,143,142,227,81,212,136,166,18,54,7,113,88,37,227,145,207,76,25,75,95,134,212,40,145,37,60,224,75,131,226,182,246,25,41,123,207,177,238,102,125,227,227,6,89,43,163,63,212,206,224,108,254,228,83,117,179,51,58,135,60,140,14,79,194,18,46,40,81,88,33,10,239,89,213,146,56,110,114,103,217,139,175,91,94,171,246,197,30,164,206,230,208,146,78,127,104,245,248,96,217,223,77,84,137,115,191,208,78,9,206,206,241,63,65,139,111,95,160,137,144,207,225,111,137,197,85,253,24,117,71,232,85,167,72,69,119,142,62,238,111,179,102,91,35,59,141,195,151,177,175,254,23,208,5,66,191,216,125,39,7,171,27,152,164,70,35,57,112,193,1,112,103,7,222,148,0,43,45,88,128,34,240,195,150,227,73,242,131,217,163,178,80,75,173,103,31,161,68,151,128,132,207,9,86,125,67,156,85,181,59,36,215,235,7,75,193,218,101,206,167,46,159,79,46,98,32,127,195,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7333162c-1720-409d-8f39-077934931a56"));
		}

		#endregion

	}

	#endregion

}

