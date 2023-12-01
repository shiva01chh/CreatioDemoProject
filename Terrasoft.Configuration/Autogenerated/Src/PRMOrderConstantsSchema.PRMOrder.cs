namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PRMOrderConstantsSchema

	/// <exclude/>
	public class PRMOrderConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PRMOrderConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PRMOrderConstantsSchema(PRMOrderConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ee3a9e6e-8558-427d-9613-797cab16dcc3");
			Name = "PRMOrderConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d0cf4ca6-907d-4eba-86db-4399f9ff6801");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,203,78,195,48,16,69,215,141,148,127,176,202,6,22,105,164,16,250,160,192,34,137,203,10,17,1,63,48,36,147,200,82,236,84,99,91,40,170,248,119,92,155,87,165,122,51,242,189,119,142,102,70,129,68,189,135,6,217,27,18,129,30,59,179,40,71,213,137,222,18,24,49,170,56,58,196,209,204,106,161,122,246,58,105,131,114,27,71,78,185,32,236,157,205,202,1,180,190,101,245,203,211,51,181,72,174,87,27,80,70,251,208,222,190,15,162,97,78,49,174,52,199,232,185,228,236,224,211,127,204,31,203,113,61,33,216,105,154,178,59,109,165,4,154,30,130,192,106,18,110,246,65,104,195,106,32,163,144,92,1,89,130,193,126,164,137,137,22,149,17,157,64,90,252,34,210,255,140,211,17,31,173,104,3,243,136,60,75,188,103,10,63,124,240,114,94,84,213,174,224,89,150,100,155,42,79,242,29,231,201,154,87,171,132,223,20,89,190,89,174,150,107,126,61,191,218,126,111,135,170,13,11,250,255,103,56,227,137,232,52,247,190,0,55,189,244,24,148,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ee3a9e6e-8558-427d-9613-797cab16dcc3"));
		}

		#endregion

	}

	#endregion

}

