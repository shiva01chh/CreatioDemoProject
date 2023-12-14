namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationConstsSchema

	/// <exclude/>
	public class DeduplicationConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationConstsSchema(DeduplicationConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2f63d953-bd1e-490d-81f5-9a26e360c7c0");
			Name = "DeduplicationConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a2cb4b0a-72d7-4fbf-b57c-bc3bae7898e7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,189,78,195,48,20,133,103,42,245,29,174,202,2,131,155,159,166,77,66,1,137,154,8,49,32,134,242,2,78,124,19,44,53,78,100,59,66,21,226,221,177,221,22,10,136,1,188,88,247,231,156,243,13,87,178,22,117,207,42,132,39,84,138,233,174,54,83,218,201,90,52,131,98,70,116,18,94,199,163,147,65,11,217,192,122,171,13,182,203,241,200,118,78,21,54,110,74,55,76,235,11,184,69,62,148,27,81,121,137,213,107,163,253,90,16,4,112,169,135,182,101,106,123,189,175,237,216,48,33,53,84,110,143,73,163,161,86,93,235,202,163,88,46,42,247,51,37,80,79,15,78,193,145,85,239,3,193,58,24,251,85,142,195,99,244,95,49,28,191,221,254,65,226,27,159,251,8,93,143,251,104,2,107,100,170,122,158,126,232,142,115,191,5,43,100,188,147,155,45,220,13,130,239,133,143,7,171,123,14,87,32,241,197,15,207,38,69,148,206,210,144,82,66,23,69,70,146,40,137,201,77,177,202,73,182,138,139,104,190,162,97,70,179,201,249,210,133,252,25,249,1,85,131,255,32,246,186,223,128,147,156,135,139,60,142,201,60,100,72,18,158,115,82,114,94,146,40,89,240,89,204,234,168,76,83,15,108,83,222,118,119,129,146,239,78,195,149,190,231,222,59,71,17,131,89,103,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2f63d953-bd1e-490d-81f5-9a26e360c7c0"));
		}

		#endregion

	}

	#endregion

}

