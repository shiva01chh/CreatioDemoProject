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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,85,142,193,10,131,48,16,68,207,6,242,15,11,94,20,196,15,240,38,85,104,47,30,84,232,57,198,213,6,116,13,38,22,75,241,223,27,75,21,186,135,129,29,102,30,227,171,14,138,188,174,234,180,200,210,50,227,140,196,136,70,11,137,80,189,140,197,49,190,99,195,217,155,51,206,60,189,52,131,146,32,7,97,12,92,173,213,249,42,81,91,53,17,36,71,188,92,200,170,17,227,27,89,156,39,93,225,252,84,18,77,156,175,238,39,49,156,21,199,115,84,239,128,254,225,2,69,22,30,206,185,76,45,70,96,236,172,168,7,55,204,136,30,195,189,229,121,9,52,194,96,240,51,163,51,30,194,23,187,57,217,246,213,78,124,164,86,117,156,185,251,0,226,81,114,152,240,0,0,0 };
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

