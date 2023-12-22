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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,80,203,78,195,64,12,60,55,82,255,193,42,247,228,206,163,151,10,113,1,169,2,126,192,108,156,212,82,226,141,236,13,8,85,252,59,206,171,10,92,96,15,171,245,216,59,158,25,193,150,172,195,64,240,74,170,104,177,74,249,33,74,197,117,175,152,56,74,254,18,3,99,243,72,88,62,144,108,179,243,54,219,102,155,43,165,218,155,112,104,208,236,26,126,204,60,147,165,163,198,119,46,73,253,221,69,49,26,63,21,69,1,183,214,183,45,234,231,126,174,151,1,8,3,19,84,81,125,132,188,84,170,238,118,127,242,238,138,61,160,148,192,114,34,229,68,229,196,67,150,47,251,138,213,194,174,127,107,56,204,171,254,161,121,51,153,189,184,245,137,142,52,49,185,229,227,200,53,245,127,27,27,1,79,49,33,139,129,231,234,174,60,102,195,154,224,227,68,2,3,205,152,46,176,65,47,214,135,224,237,252,194,181,22,189,168,182,164,44,53,220,15,108,79,51,217,25,106,74,55,96,195,245,53,107,37,41,39,185,99,61,161,107,208,145,245,249,6,101,192,158,217,1,2,0,0 };
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

