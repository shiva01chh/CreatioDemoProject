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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,77,107,195,48,12,61,167,208,255,32,186,123,2,59,182,91,47,165,108,131,13,10,251,184,171,182,226,10,28,39,88,54,91,41,251,239,115,157,52,203,6,245,73,122,122,79,239,9,59,108,72,58,84,4,111,228,61,74,91,135,114,211,186,154,77,244,24,184,117,243,217,105,62,43,162,176,51,240,122,148,64,205,106,236,175,72,202,247,192,86,18,45,17,111,60,153,4,193,198,162,200,18,94,80,249,86,182,95,129,156,38,189,243,109,71,62,48,73,230,86,85,5,119,18,155,6,253,113,61,244,89,7,236,20,118,18,45,6,2,212,154,207,46,104,161,27,245,240,121,96,117,0,133,14,246,4,81,72,39,77,90,70,4,202,83,125,191,232,141,31,201,38,193,199,237,162,90,151,23,195,106,226,216,197,189,101,5,42,155,94,207,90,156,114,222,241,184,223,217,18,118,121,69,63,255,127,80,6,158,209,153,136,134,128,53,185,192,53,147,47,71,242,52,204,37,205,67,100,61,170,158,52,156,255,163,40,12,133,85,46,100,40,190,135,76,41,109,31,43,247,61,250,23,76,216,244,253,0,104,84,188,84,3,2,0,0 };
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

