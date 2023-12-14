namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialLeadGenRestProviderResponseSchema

	/// <exclude/>
	public class SocialLeadGenRestProviderResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialLeadGenRestProviderResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialLeadGenRestProviderResponseSchema(SocialLeadGenRestProviderResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("bb4700f9-fd00-5da9-06bb-a7b825d87bb3");
			Name = "SocialLeadGenRestProviderResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,80,203,78,195,64,12,60,55,82,254,193,42,247,228,206,163,151,10,113,1,169,2,126,192,108,156,212,82,226,141,236,13,8,85,252,59,206,171,42,92,96,15,171,245,216,59,158,25,193,142,172,199,64,240,74,170,104,177,78,197,62,74,205,205,160,152,56,74,241,18,3,99,251,72,88,61,144,228,217,41,207,242,108,115,165,212,120,19,246,45,154,93,195,143,153,103,178,116,208,248,206,21,169,191,251,40,70,211,167,178,44,225,214,134,174,67,253,220,45,245,58,0,97,100,130,58,170,143,144,151,74,245,221,246,79,222,109,185,3,148,10,88,142,164,156,168,154,121,200,138,117,95,121,177,176,31,222,90,14,203,170,127,104,222,204,102,207,110,125,162,39,77,76,110,249,48,113,205,253,223,198,38,192,83,76,200,98,224,185,186,43,143,217,176,33,248,56,146,192,72,51,165,11,108,48,136,13,33,120,187,56,115,93,138,94,85,91,82,150,6,238,71,182,167,133,236,4,13,165,27,176,241,250,90,180,146,84,179,220,169,158,209,75,208,145,241,124,3,68,180,133,177,249,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("bb4700f9-fd00-5da9-06bb-a7b825d87bb3"));
		}

		#endregion

	}

	#endregion

}

