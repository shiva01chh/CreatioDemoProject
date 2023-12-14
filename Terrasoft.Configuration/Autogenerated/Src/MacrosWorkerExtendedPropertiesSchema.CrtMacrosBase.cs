namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacrosWorkerExtendedPropertiesSchema

	/// <exclude/>
	public class MacrosWorkerExtendedPropertiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacrosWorkerExtendedPropertiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacrosWorkerExtendedPropertiesSchema(MacrosWorkerExtendedPropertiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("46e56cc0-b0c4-4b85-901f-98aac1edceeb");
			Name = "MacrosWorkerExtendedProperties";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,78,195,48,12,134,207,157,180,119,176,198,189,189,111,176,3,211,132,56,32,77,2,196,217,75,220,206,90,155,86,118,34,152,38,222,157,52,221,74,65,72,228,100,255,206,111,127,78,28,54,164,29,26,130,23,18,65,109,75,159,111,90,87,114,21,4,61,183,110,62,59,207,103,89,80,118,21,60,159,212,83,179,26,243,169,69,232,111,125,210,42,127,245,92,107,188,22,47,222,8,85,81,130,77,141,170,75,120,66,35,173,190,181,114,36,217,126,120,114,150,236,78,218,142,196,51,105,114,20,69,1,183,26,154,6,229,180,190,228,201,13,236,12,118,26,106,244,4,104,45,247,179,176,134,110,244,195,251,129,205,1,12,58,216,19,4,37,27,61,177,25,17,24,161,242,110,113,143,74,91,231,217,159,166,32,139,98,157,95,7,23,147,201,93,216,215,108,192,164,225,255,145,103,231,68,63,46,252,93,91,194,46,53,26,234,191,215,75,194,240,224,96,66,237,131,16,176,165,8,89,50,73,62,90,166,96,87,178,135,192,182,247,110,6,223,163,133,254,15,179,172,34,191,74,129,94,130,207,11,91,164,30,240,82,62,168,63,197,168,245,231,11,32,184,59,185,47,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("46e56cc0-b0c4-4b85-901f-98aac1edceeb"));
		}

		#endregion

	}

	#endregion

}

