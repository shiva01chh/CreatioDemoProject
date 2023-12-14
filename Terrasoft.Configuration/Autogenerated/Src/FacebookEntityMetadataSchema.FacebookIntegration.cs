namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookEntityMetadataSchema

	/// <exclude/>
	public class FacebookEntityMetadataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookEntityMetadataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookEntityMetadataSchema(FacebookEntityMetadataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e3e1645a-bfb9-4c64-806f-498f877105d0");
			Name = "FacebookEntityMetadata";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("eff9ab8e-fb1d-46f5-bbeb-f2b4e8220404");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,193,106,195,48,12,61,167,208,127,48,237,165,131,145,15,88,217,97,180,235,97,144,17,150,222,70,15,74,162,4,179,196,54,178,114,200,202,254,125,138,147,118,172,16,234,147,252,158,222,211,179,108,160,69,239,160,64,117,68,34,240,182,226,120,103,77,165,235,142,128,181,53,113,102,11,13,205,114,113,94,46,162,206,107,83,171,172,247,140,237,246,230,30,127,116,134,117,139,113,134,36,2,253,29,228,127,93,7,25,146,91,251,37,136,96,107,194,90,104,181,107,192,251,167,43,249,42,22,220,39,200,80,2,67,232,252,220,75,37,145,152,160,224,147,0,174,203,27,93,168,98,80,206,8,213,173,163,200,206,193,237,58,56,37,235,144,88,163,76,79,131,227,200,135,113,9,182,57,210,230,93,150,163,158,213,170,210,216,148,126,245,112,10,13,23,231,4,156,147,135,109,46,244,163,74,129,208,240,160,104,167,32,147,102,138,252,230,173,121,145,45,247,234,16,36,106,216,105,20,213,200,219,80,248,169,248,153,143,194,189,195,217,32,129,188,31,195,51,13,31,114,148,238,59,9,214,104,202,113,95,225,62,162,255,65,193,134,243,11,37,147,28,239,72,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e3e1645a-bfb9-4c64-806f-498f877105d0"));
		}

		#endregion

	}

	#endregion

}

