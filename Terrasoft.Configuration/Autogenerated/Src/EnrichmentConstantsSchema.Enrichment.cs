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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,65,10,194,48,16,69,215,45,244,14,67,221,247,0,21,23,82,92,43,232,94,98,156,182,129,118,18,50,147,149,120,119,211,166,90,5,179,9,249,239,231,13,67,106,68,118,74,35,92,208,123,197,182,149,170,177,212,154,46,120,37,198,82,117,32,111,116,63,34,73,145,63,138,188,200,179,141,199,46,18,104,6,197,92,195,90,136,31,89,20,9,207,53,23,110,131,209,16,19,137,151,158,202,255,187,89,210,174,222,55,170,225,52,59,18,94,124,122,162,209,234,13,117,95,190,227,62,72,127,214,214,33,236,160,12,140,87,252,176,114,187,12,64,186,167,25,243,251,153,182,249,9,99,54,157,23,125,199,33,202,23,1,0,0 };
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

