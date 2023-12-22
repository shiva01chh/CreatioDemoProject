namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HttpExceptionSchema

	/// <exclude/>
	public class HttpExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HttpExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HttpExceptionSchema(HttpExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9585662d-704a-4632-9f1a-d2348e8cadce");
			Name = "HttpException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4ec403af-02e3-46d1-9fa9-59ed1daa3619");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,142,193,10,131,48,16,68,207,6,242,15,11,94,44,136,31,224,77,170,208,94,60,168,208,115,140,171,13,232,26,76,44,150,226,191,55,150,42,237,30,6,118,152,121,140,175,90,200,179,170,172,146,60,77,138,148,51,18,3,26,45,36,66,249,52,22,135,232,134,53,103,47,206,56,243,244,92,247,74,130,236,133,49,112,177,86,103,139,68,109,213,72,16,239,241,98,38,171,6,140,174,100,113,26,117,137,211,67,73,52,81,182,184,159,68,127,84,28,207,81,189,29,250,135,11,20,89,184,59,231,60,54,24,130,177,147,162,14,220,48,35,58,60,109,45,207,139,161,22,6,131,175,25,30,241,19,124,176,171,147,117,91,237,196,71,106,84,203,217,239,189,1,78,141,34,210,249,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9585662d-704a-4632-9f1a-d2348e8cadce"));
		}

		#endregion

	}

	#endregion

}

