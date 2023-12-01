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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,65,10,194,48,16,69,215,45,244,14,67,221,247,0,21,23,82,92,43,232,94,98,156,182,129,118,18,146,201,74,188,187,211,166,90,5,179,9,249,239,231,13,67,106,196,224,148,70,184,160,247,42,216,150,171,198,82,107,186,232,21,27,75,213,129,188,209,253,136,196,69,254,40,242,34,207,54,30,59,33,208,12,42,132,26,214,130,124,12,172,136,195,92,115,241,54,24,13,146,176,92,122,42,255,239,102,73,187,122,223,168,134,211,236,72,120,241,233,137,138,213,27,234,190,124,199,125,228,254,172,173,67,216,65,25,3,94,241,195,202,237,50,0,233,158,102,204,239,103,218,230,39,148,76,206,11,221,135,111,148,22,1,0,0 };
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

