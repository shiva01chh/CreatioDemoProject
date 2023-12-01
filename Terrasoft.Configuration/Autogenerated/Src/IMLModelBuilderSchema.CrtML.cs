namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLModelBuilderSchema

	/// <exclude/>
	public class IMLModelBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLModelBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLModelBuilderSchema(IMLModelBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("98854813-1873-4ab4-b4e2-030112343a5f");
			Name = "IMLModelBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("55b53857-a033-4921-8f47-13b5471dd33e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,197,148,91,110,219,48,16,69,191,99,192,123,24,232,167,41,16,88,11,168,43,160,113,31,8,96,161,45,146,46,96,34,141,109,2,34,169,12,135,105,131,34,123,47,31,178,99,37,78,235,62,128,250,75,36,103,238,220,123,44,10,12,106,114,61,54,4,87,196,140,206,174,100,182,176,102,165,214,158,81,148,53,179,122,57,157,124,159,78,78,188,83,102,61,170,98,122,245,204,254,236,237,121,56,10,135,101,89,194,220,121,173,145,239,170,97,125,161,251,142,52,25,113,32,27,130,107,218,224,173,178,12,118,149,214,245,178,182,45,117,219,230,114,175,187,247,215,157,106,64,25,33,94,69,207,23,67,241,185,87,93,75,28,74,162,211,39,83,211,198,210,98,155,39,50,221,120,197,212,66,99,59,175,77,216,180,32,140,202,128,142,98,179,157,68,249,88,99,222,35,163,134,8,237,117,145,138,51,171,162,170,151,185,57,104,238,195,155,151,169,227,176,128,119,196,161,223,80,19,107,139,234,203,104,29,98,58,65,211,208,72,228,214,170,54,69,25,146,47,114,132,211,71,189,99,233,51,216,85,71,115,176,231,252,101,254,159,14,35,123,247,173,71,51,64,179,172,214,202,96,7,55,158,248,14,190,42,217,0,26,176,94,122,47,3,201,99,201,37,137,162,186,10,178,233,241,231,152,254,31,231,55,109,251,57,250,251,152,66,102,212,191,34,125,73,93,120,204,185,254,148,123,77,188,38,7,43,37,144,28,81,120,223,221,209,175,37,9,182,40,152,249,110,87,255,22,113,162,147,92,190,87,242,41,110,187,211,20,244,178,217,144,198,122,24,186,155,254,151,32,26,239,196,234,193,79,186,173,233,22,59,223,73,252,246,36,181,23,238,33,235,239,92,224,177,227,162,250,64,134,66,226,240,117,56,14,93,246,246,208,191,200,94,159,111,102,18,207,198,85,41,219,104,202,246,36,150,58,225,24,45,21,45,70,35,14,131,126,186,119,6,131,198,216,97,228,125,114,63,157,220,71,236,225,247,3,71,53,185,165,2,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("98854813-1873-4ab4-b4e2-030112343a5f"));
		}

		#endregion

	}

	#endregion

}

