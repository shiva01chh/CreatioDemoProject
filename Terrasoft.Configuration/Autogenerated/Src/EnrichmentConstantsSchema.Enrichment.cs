namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichmentConstantsSchema

	/// <exclude/>
	public class EnrichmentConstantsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichmentConstantsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichmentConstantsSchema(EnrichmentConstantsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("518edb9f-91be-476f-ad2f-ca02cfcabc1e");
			Name = "EnrichmentConstants";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("523e180e-845f-4752-bb0d-120bebcd70d6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,65,14,130,48,16,69,215,144,112,135,9,238,57,0,198,133,33,174,53,193,189,169,117,128,38,48,37,157,233,202,120,119,11,69,193,196,110,154,254,247,251,38,67,106,64,30,149,70,184,162,115,138,109,35,69,101,169,49,173,119,74,140,165,226,68,206,232,110,64,146,44,125,102,105,150,38,59,135,109,32,80,245,138,185,132,181,16,62,178,40,18,158,107,163,191,247,70,67,72,36,92,122,42,255,239,38,81,187,122,63,168,132,203,236,136,120,241,233,137,6,171,51,212,110,124,231,163,151,174,214,118,68,56,64,238,25,111,248,101,249,126,25,128,244,136,51,230,247,43,110,243,19,134,108,123,222,163,192,19,146,31,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("518edb9f-91be-476f-ad2f-ca02cfcabc1e"));
		}

		#endregion

	}

	#endregion

}

