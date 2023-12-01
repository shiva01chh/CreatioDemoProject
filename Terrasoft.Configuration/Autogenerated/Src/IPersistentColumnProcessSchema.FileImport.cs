namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IPersistentColumnProcessSchema

	/// <exclude/>
	public class IPersistentColumnProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IPersistentColumnProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IPersistentColumnProcessSchema(IPersistentColumnProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8195325f-d746-484e-902f-eef26fde2768");
			Name = "IPersistentColumnProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,143,61,111,132,48,12,134,103,144,248,15,22,183,180,11,217,91,142,229,116,149,24,42,49,244,15,164,193,80,75,228,67,118,114,106,117,234,127,111,128,182,3,86,60,248,227,125,226,215,105,139,18,180,65,120,67,102,45,126,138,205,197,187,137,230,196,58,146,119,205,11,45,216,219,224,57,86,229,189,40,170,178,8,233,125,33,3,228,34,242,180,74,251,1,89,72,34,186,120,241,75,178,110,96,111,80,36,239,222,115,22,39,198,57,163,224,21,227,135,31,229,9,134,141,80,149,235,80,41,5,173,36,107,53,127,117,127,141,235,39,154,20,17,110,122,73,40,16,118,30,185,185,129,127,141,58,138,218,160,89,91,112,217,210,185,166,237,228,97,237,96,190,83,234,46,255,130,8,134,113,58,215,253,113,170,186,86,109,242,141,118,243,52,194,175,137,135,227,46,28,209,143,207,187,147,19,186,113,119,154,171,239,170,204,47,199,15,80,32,199,174,98,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8195325f-d746-484e-902f-eef26fde2768"));
		}

		#endregion

	}

	#endregion

}

