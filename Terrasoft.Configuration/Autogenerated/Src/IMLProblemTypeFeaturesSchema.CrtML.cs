namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLProblemTypeFeaturesSchema

	/// <exclude/>
	public class IMLProblemTypeFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLProblemTypeFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLProblemTypeFeaturesSchema(IMLProblemTypeFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("af781143-48a0-4837-b191-06bc575a6ccb");
			Name = "IMLProblemTypeFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,142,65,106,3,49,12,69,215,9,228,14,90,182,155,153,3,52,100,19,40,13,36,180,139,92,64,227,202,83,131,109,25,89,94,132,144,187,87,51,73,195,64,13,50,216,252,255,244,50,38,170,5,29,193,153,68,176,178,215,110,207,217,135,177,9,106,224,220,157,142,155,245,117,179,94,245,125,15,219,218,82,66,185,236,30,239,67,86,18,63,181,61,11,20,20,13,174,69,20,240,132,218,132,42,176,7,253,33,168,133,92,240,193,65,17,30,34,37,208,75,161,238,143,218,47,176,165,13,209,114,225,73,62,156,142,95,247,210,217,58,239,15,176,37,77,202,238,127,94,243,199,7,218,234,166,165,41,188,40,202,72,250,10,142,99,75,121,54,77,252,77,17,84,48,228,144,199,238,137,89,138,172,6,230,56,129,62,103,206,254,222,190,130,177,222,224,102,1,155,219,164,176,60,191,237,171,137,151,79,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("af781143-48a0-4837-b191-06bc575a6ccb"));
		}

		#endregion

	}

	#endregion

}

