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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,83,219,110,219,48,12,125,78,129,254,3,145,189,180,64,97,191,103,89,128,44,233,138,20,205,208,173,205,7,200,10,227,168,144,37,87,162,178,181,197,254,125,180,156,198,151,38,245,139,69,242,240,240,144,162,140,40,208,151,66,34,60,162,115,194,219,13,37,51,107,54,42,15,78,144,178,230,252,236,237,252,108,16,188,50,57,60,188,120,194,226,107,207,102,188,214,40,43,176,79,110,208,160,83,242,3,102,46,72,124,112,222,41,243,220,56,115,109,51,161,71,163,153,45,10,107,146,59,155,231,236,110,226,63,241,15,113,137,74,225,173,183,166,9,252,10,194,209,107,223,78,22,69,169,147,165,32,185,69,231,155,104,187,207,170,208,241,136,195,83,254,238,120,78,162,230,223,79,134,174,13,41,82,120,66,19,3,126,8,73,214,125,134,120,224,166,214,65,163,59,134,88,162,247,162,154,93,211,33,163,190,56,204,89,48,204,180,240,30,70,48,67,71,106,163,164,32,244,83,73,65,104,245,26,91,186,181,89,76,72,211,20,198,62,20,133,112,47,147,189,61,5,25,211,105,43,8,28,150,14,61,26,242,32,91,100,32,218,108,240,100,179,228,157,45,109,209,149,33,211,74,238,249,62,19,195,90,23,252,187,254,139,50,240,88,56,245,45,234,59,116,180,68,218,218,117,213,211,125,228,172,163,125,249,209,241,59,152,190,190,141,117,32,180,238,182,160,76,133,82,59,132,146,119,137,87,218,111,85,233,147,3,111,218,39,30,51,78,20,96,248,57,125,27,6,143,142,183,196,212,143,98,56,89,177,13,242,224,72,198,105,68,31,79,142,103,36,46,57,156,220,31,206,157,156,253,232,118,202,85,141,192,206,170,53,212,227,193,139,85,167,54,116,165,92,193,98,174,226,137,181,143,61,57,94,146,43,176,217,19,135,39,208,84,190,132,234,209,15,6,173,107,89,145,210,62,121,191,27,156,106,125,209,229,190,172,86,113,240,111,127,53,104,214,245,237,68,187,246,118,157,236,227,239,63,20,75,77,139,128,4,0,0 };
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

