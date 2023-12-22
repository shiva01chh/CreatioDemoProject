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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,143,203,78,196,48,12,69,215,173,212,127,176,58,27,216,52,123,232,116,51,2,169,11,164,46,248,129,144,186,197,82,243,144,157,140,64,35,254,157,180,5,132,106,197,11,63,238,137,175,211,22,37,104,131,240,138,204,90,252,20,155,139,119,19,205,137,117,36,239,154,103,90,176,183,193,115,172,202,91,81,84,101,17,210,219,66,6,200,69,228,105,149,246,3,178,144,68,116,241,226,151,100,221,192,222,160,72,222,189,229,44,78,140,115,70,193,11,198,119,63,202,3,12,27,161,42,215,161,82,10,90,73,214,106,254,236,126,27,79,31,104,82,68,184,234,37,161,64,216,121,228,230,6,254,52,234,40,106,131,102,109,193,101,75,231,154,182,147,135,181,131,249,78,169,187,252,11,34,24,198,233,92,247,199,169,234,90,181,201,55,218,213,211,8,63,38,238,142,187,112,68,223,63,238,78,78,232,198,221,105,174,190,170,50,191,255,241,13,236,112,36,116,107,1,0,0 };
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

