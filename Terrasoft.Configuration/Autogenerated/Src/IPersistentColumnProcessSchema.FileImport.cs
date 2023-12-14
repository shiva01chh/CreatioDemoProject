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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,143,191,110,132,48,12,198,103,144,120,7,139,91,218,133,236,45,199,114,186,74,12,149,24,250,2,105,48,52,18,113,34,59,57,181,58,245,221,27,160,237,128,21,15,254,243,253,226,143,180,67,9,218,32,188,33,179,22,63,197,230,226,105,178,115,98,29,173,167,230,197,46,216,187,224,57,86,229,189,40,170,178,8,233,125,177,6,44,69,228,105,149,246,3,178,88,137,72,241,226,151,228,104,96,111,80,36,239,222,115,22,39,198,57,163,224,21,227,135,31,229,9,134,141,80,149,235,80,41,5,173,36,231,52,127,117,127,141,235,39,154,20,17,110,122,73,40,16,118,158,165,185,129,127,141,58,138,218,160,89,59,160,108,233,92,219,237,228,97,237,96,190,83,234,46,255,130,8,134,113,58,215,253,113,170,186,86,109,242,141,118,243,118,132,95,19,15,199,93,56,162,31,159,119,39,39,164,113,119,154,171,239,170,204,111,141,31,71,144,18,89,99,1,0,0 };
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

