namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MLDefaultProblemTypeFeaturesSchema

	/// <exclude/>
	public class MLDefaultProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MLDefaultProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MLDefaultProblemTypeFeaturesSchema(MLDefaultProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d30cac6-8bd4-4ed6-a823-a8838e7983e0");
			Name = "MLDefaultProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,208,61,107,195,48,16,6,224,57,6,255,135,27,157,197,222,155,182,67,83,66,11,54,237,144,173,116,56,59,39,35,144,117,70,210,5,130,241,127,175,252,145,146,210,104,147,120,239,225,61,89,236,200,247,216,16,28,201,57,244,172,66,190,103,171,116,43,14,131,102,155,87,101,154,12,105,178,17,175,109,251,39,229,40,63,96,19,216,105,242,187,52,137,153,162,40,224,209,75,215,161,187,60,175,247,87,82,40,38,128,34,12,226,8,206,104,132,60,40,118,128,198,64,239,184,54,212,65,184,244,228,243,171,81,220,32,95,171,240,162,237,41,86,200,166,36,171,236,189,42,63,151,217,99,124,56,44,186,223,110,191,227,72,47,181,209,13,52,6,189,135,170,92,129,59,113,120,128,251,78,68,134,121,165,127,59,205,15,111,232,129,37,244,18,32,11,232,90,10,91,104,216,72,103,231,197,58,62,145,129,224,80,219,216,56,255,101,110,215,186,150,60,107,23,4,13,212,204,102,114,63,102,118,191,96,3,68,122,7,35,60,69,77,40,254,242,102,76,147,113,106,54,157,31,104,122,106,23,190,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d30cac6-8bd4-4ed6-a823-a8838e7983e0"));
		}

		#endregion

	}

	#endregion

}

