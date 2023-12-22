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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,189,78,195,48,20,133,103,42,245,29,172,178,192,224,230,167,105,147,80,64,34,38,66,12,136,161,188,128,19,223,4,75,137,19,217,142,80,133,120,119,108,55,133,0,98,0,47,214,253,57,231,124,195,21,180,5,213,211,18,208,19,72,73,85,87,233,37,233,68,197,235,65,82,205,59,129,94,231,179,147,65,113,81,163,221,94,105,104,183,243,153,233,156,74,168,237,148,52,84,169,11,116,11,108,40,26,94,58,137,209,43,173,220,154,231,121,232,82,13,109,75,229,254,122,172,205,88,83,46,20,42,237,30,21,90,161,74,118,173,45,39,177,140,151,246,167,146,131,90,30,157,188,137,85,239,2,145,113,208,230,43,45,135,195,232,191,98,88,126,179,253,131,196,53,62,247,1,117,61,140,209,24,237,128,202,242,121,249,161,155,230,126,11,150,64,89,39,154,61,186,27,56,27,133,143,71,171,123,134,174,144,128,23,55,60,91,228,65,188,138,125,66,48,217,228,9,142,130,40,196,55,121,150,226,36,11,243,96,157,17,63,33,201,226,124,107,67,254,140,252,0,178,134,127,16,59,221,111,192,81,202,252,77,26,134,120,237,83,192,17,75,25,46,24,43,112,16,109,216,42,164,85,80,196,177,3,54,41,111,135,187,0,193,14,167,97,75,215,155,190,119,76,84,127,140,111,2,0,0 };
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

