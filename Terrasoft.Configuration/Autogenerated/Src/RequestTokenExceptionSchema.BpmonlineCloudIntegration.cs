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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,207,74,195,64,16,198,207,9,244,29,134,246,210,66,201,3,52,212,131,33,7,15,66,177,189,137,135,109,50,13,139,155,217,184,179,81,107,233,187,59,219,196,90,109,14,98,32,129,249,247,251,230,27,66,170,70,110,84,129,176,65,231,20,219,157,79,50,75,59,93,181,78,121,109,41,185,109,106,75,70,19,102,198,182,229,29,121,172,186,202,40,62,140,226,168,101,77,21,172,247,236,177,78,71,177,100,38,14,43,41,67,102,20,243,2,30,240,165,69,246,27,251,140,148,191,23,216,116,179,210,248,184,70,167,149,209,31,106,107,112,58,123,146,84,211,110,141,46,160,8,163,195,147,176,128,11,74,20,86,136,194,123,86,181,196,222,181,133,183,78,196,87,39,222,73,237,139,61,72,157,206,224,68,58,254,161,85,240,193,178,220,141,85,133,51,89,104,171,24,167,231,248,159,160,249,183,47,208,68,232,206,225,111,137,249,85,253,16,117,71,232,85,39,72,101,119,142,62,238,111,179,114,182,65,231,53,14,95,198,190,202,47,160,75,132,126,177,251,78,14,150,55,48,206,140,70,242,224,131,3,112,157,29,120,83,12,78,105,198,18,20,129,12,91,151,140,211,31,204,30,149,135,90,102,133,125,128,10,125,10,28,62,71,88,246,13,73,94,55,126,159,94,175,31,44,5,107,151,57,73,201,243,9,245,171,14,38,186,2,0,0 };
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

