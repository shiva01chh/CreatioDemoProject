namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessageFileCleanerSchema

	/// <exclude/>
	public class PortalMessageFileCleanerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessageFileCleanerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessageFileCleanerSchema(PortalMessageFileCleanerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("58b34129-eda1-43f6-b441-329cc91b3415");
			Name = "PortalMessageFileCleaner";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c85d2d65-6230-4aeb-9934-bfac9785d42f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,77,111,219,48,12,61,187,64,255,3,225,93,28,160,179,119,110,83,15,171,219,12,57,20,40,176,22,59,14,138,77,167,2,100,201,163,164,102,89,177,255,62,202,78,178,196,249,88,124,19,249,244,248,248,72,89,139,6,109,43,74,132,103,36,18,214,212,46,45,140,174,229,220,147,112,210,232,203,139,247,203,139,200,91,169,231,240,109,105,29,54,55,155,243,246,21,194,99,241,244,254,142,83,156,252,64,56,103,70,40,148,176,246,26,158,12,57,161,30,209,90,49,199,137,84,88,40,20,26,169,195,182,126,166,100,9,101,128,158,64,70,239,29,122,67,61,145,168,170,192,77,242,77,56,236,147,109,127,0,66,81,25,173,150,240,98,145,184,73,141,101,232,16,126,248,157,243,205,138,18,117,213,179,238,150,96,160,117,228,75,103,40,20,234,116,246,136,44,203,96,108,125,211,8,90,230,235,192,84,75,39,133,146,191,209,130,198,5,72,190,45,52,251,109,106,6,35,66,73,88,223,198,199,90,140,179,60,221,112,103,67,242,113,43,72,52,160,121,136,183,241,110,23,113,30,186,132,114,19,72,199,89,135,238,46,175,236,61,86,53,25,56,180,75,61,130,176,18,81,52,240,13,110,97,207,200,40,250,115,218,205,71,116,175,166,58,199,200,123,84,232,216,196,182,211,12,77,47,26,106,86,13,179,37,204,229,27,106,144,21,106,39,107,201,157,179,191,7,160,231,154,217,14,157,153,86,113,62,253,47,251,182,199,29,39,161,243,164,109,254,76,30,175,64,214,189,222,133,176,80,117,253,84,87,96,220,43,210,66,90,132,143,80,11,101,3,203,250,218,214,172,102,198,168,149,9,123,99,75,190,122,89,193,1,205,235,81,245,124,221,2,246,20,201,96,120,163,14,22,165,19,50,77,178,191,141,241,42,31,165,223,89,44,38,49,219,177,14,69,233,212,62,252,244,66,37,133,81,190,209,233,83,176,128,107,80,114,72,209,134,233,139,174,146,184,224,71,201,46,220,45,207,35,28,168,78,11,79,196,51,9,235,26,126,91,78,148,238,95,137,244,225,23,150,158,123,29,65,14,159,224,51,240,179,69,184,238,77,62,177,156,125,116,55,200,177,240,253,5,51,20,21,162,47,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("58b34129-eda1-43f6-b441-329cc91b3415"));
		}

		#endregion

	}

	#endregion

}

