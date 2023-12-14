namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CertificatesActualizationJobSchema

	/// <exclude/>
	public class CertificatesActualizationJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CertificatesActualizationJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CertificatesActualizationJobSchema(CertificatesActualizationJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb1f524d-141f-4a2f-b908-d3aa1a3dcdde");
			Name = "CertificatesActualizationJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("867b9a25-86bf-4a3e-8ecd-b6e40f57be82");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,219,110,219,48,12,125,78,129,254,3,145,189,180,64,97,191,103,89,128,44,233,138,20,205,208,173,205,7,200,10,227,168,144,37,87,162,178,181,197,254,125,148,157,198,151,38,245,139,69,242,240,240,144,162,140,40,208,151,66,34,60,162,115,194,219,13,37,51,107,54,42,15,78,144,178,230,252,236,237,252,108,16,188,50,57,60,188,120,194,226,107,207,102,188,214,40,35,216,39,55,104,208,41,249,1,51,23,36,62,56,239,148,121,110,156,185,182,153,208,163,209,204,22,133,53,201,157,205,115,118,55,241,159,248,135,184,68,84,120,235,173,105,2,191,130,112,244,218,183,147,69,81,234,100,41,72,110,209,249,38,218,238,51,22,58,30,113,120,202,223,29,207,73,212,252,251,201,208,181,33,69,10,79,104,98,192,15,33,201,186,207,16,15,220,212,58,104,116,199,16,75,244,94,196,217,53,29,50,234,139,195,156,5,195,76,11,239,97,4,51,116,164,54,74,10,66,63,149,20,132,86,175,85,75,183,54,171,18,210,52,133,177,15,69,33,220,203,100,111,79,65,86,233,180,21,4,14,75,135,30,13,121,144,45,50,16,109,54,120,178,89,242,206,150,182,232,202,144,105,37,247,124,159,137,97,173,11,254,93,255,69,25,120,44,156,250,86,233,59,116,180,68,218,218,117,236,233,190,226,172,163,125,249,149,227,119,48,125,125,27,235,64,104,221,109,65,153,136,82,59,132,146,119,137,87,218,111,85,233,147,3,111,218,39,30,51,78,20,96,248,57,125,27,6,143,142,183,196,212,143,98,56,89,177,13,242,224,72,198,105,133,62,158,92,157,145,184,228,112,114,127,56,119,114,246,163,219,41,23,27,129,157,85,107,168,199,131,23,171,78,109,232,74,185,130,197,92,85,39,214,62,246,228,120,73,174,192,102,79,28,158,64,83,249,18,226,163,31,12,90,215,178,34,165,125,242,126,55,56,213,250,162,203,125,25,87,113,240,111,127,53,104,214,245,237,84,118,237,237,58,217,23,191,255,165,159,134,40,129,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb1f524d-141f-4a2f-b908-d3aa1a3dcdde"));
		}

		#endregion

	}

	#endregion

}

