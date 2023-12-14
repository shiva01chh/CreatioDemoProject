namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosExtendedPropertiesSchema

	/// <exclude/>
	public class MacrosExtendedPropertiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosExtendedPropertiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosExtendedPropertiesSchema(MacrosExtendedPropertiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("002c9b1f-92d2-46e4-bb93-2ab334090c0f");
			Name = "MacrosExtendedProperties";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,77,107,195,48,12,61,167,208,255,32,186,123,2,59,182,91,47,165,108,131,13,10,251,184,171,182,226,10,28,39,88,54,91,41,251,239,115,156,52,235,6,245,73,122,122,79,239,9,59,108,72,58,84,4,111,228,61,74,91,135,114,211,186,154,77,244,24,184,117,243,217,105,62,43,162,176,51,240,122,148,64,205,106,234,175,72,202,247,192,86,18,45,17,111,60,153,4,193,198,162,200,18,94,80,249,86,182,95,129,156,38,189,243,109,71,62,48,73,230,86,85,5,119,18,155,6,253,113,61,246,89,7,236,20,118,18,45,6,2,212,154,123,23,180,208,77,122,248,60,176,58,128,66,7,123,130,40,164,147,38,45,35,2,229,169,190,95,12,198,143,100,147,224,227,118,81,173,203,179,97,117,225,216,197,189,101,5,42,155,94,207,90,156,114,222,233,184,223,217,18,118,121,197,48,255,127,80,6,158,209,153,136,134,128,53,185,192,53,147,47,39,242,101,152,115,154,135,200,122,82,61,105,232,255,163,40,12,133,85,46,100,44,190,199,76,41,237,16,43,247,3,250,23,76,88,255,126,0,132,71,134,37,251,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("002c9b1f-92d2-46e4-bb93-2ab334090c0f"));
		}

		#endregion

	}

	#endregion

}

