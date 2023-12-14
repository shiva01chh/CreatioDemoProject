namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CommunicationConstantsSchema

	/// <exclude/>
	public class CommunicationConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CommunicationConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CommunicationConstantsSchema(CommunicationConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e9a5adfa-2804-4de4-87ad-c536b6ee39e7");
			Name = "CommunicationConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,143,207,78,132,48,16,135,207,144,240,14,205,158,244,80,183,93,40,176,49,30,248,187,241,96,98,194,250,0,181,45,216,4,90,66,75,12,49,251,238,22,244,178,198,24,231,56,243,205,239,155,153,141,84,29,104,22,99,197,112,31,248,129,175,232,32,204,72,153,0,103,49,77,212,232,214,222,21,90,181,178,155,39,106,165,86,129,255,17,248,222,56,191,246,146,1,99,93,143,1,214,83,99,64,161,135,97,86,146,109,152,219,49,214,56,114,165,189,253,254,106,8,236,50,10,0,193,73,235,174,23,43,112,157,55,9,202,181,234,23,112,154,37,255,166,206,110,229,229,145,131,7,160,196,251,54,184,217,137,86,16,158,208,3,36,109,152,66,129,49,134,41,193,2,34,132,9,225,40,98,8,243,221,237,246,215,223,138,231,55,173,54,195,15,65,133,194,164,62,144,12,150,73,94,192,178,118,130,28,161,122,21,148,49,170,142,97,90,196,255,18,52,79,205,47,241,25,58,18,140,243,8,226,176,70,176,66,46,62,75,227,252,235,254,18,69,133,211,108,241,222,37,240,47,171,101,173,79,75,217,197,205,180,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e9a5adfa-2804-4de4-87ad-c536b6ee39e7"));
		}

		#endregion

	}

	#endregion

}

