namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValidationResponseSchema

	/// <exclude/>
	public class ValidationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValidationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValidationResponseSchema(ValidationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d");
			Name = "ValidationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,144,65,107,195,48,12,133,207,53,228,63,8,122,79,238,219,216,165,215,30,74,91,118,119,20,197,53,115,172,32,217,131,181,236,191,207,73,218,82,198,232,197,72,126,214,123,159,21,237,64,58,90,36,56,146,136,85,238,83,189,225,216,123,151,197,38,207,177,50,151,202,84,102,213,52,13,188,105,30,6,43,223,239,215,126,79,163,144,82,76,10,233,68,80,234,28,18,112,15,120,34,252,244,209,193,151,13,190,155,125,64,114,160,250,102,212,60,56,141,185,13,30,1,131,85,133,143,251,192,190,112,113,84,42,47,22,130,213,90,200,77,78,59,225,145,36,121,210,23,216,205,195,139,254,23,241,202,56,65,213,119,253,49,249,22,221,50,7,56,100,68,42,4,23,112,148,94,65,167,227,231,137,241,150,177,176,158,109,27,8,202,14,213,58,2,228,142,158,71,105,146,105,47,91,60,31,230,106,83,38,254,139,92,83,236,150,239,206,125,185,157,5,99,126,1,67,125,62,175,177,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("95fa2455-4082-4b76-99b1-0a45dbb30c9d"));
		}

		#endregion

	}

	#endregion

}

