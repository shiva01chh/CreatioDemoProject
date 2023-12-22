namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMacrosInvokableSchema

	/// <exclude/>
	public class IMacrosInvokableSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMacrosInvokableSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMacrosInvokableSchema(IMacrosInvokableSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("18dfac77-86d7-4509-8aee-d9ad2c50cf9c");
			Name = "IMacrosInvokable";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,81,185,110,195,48,12,157,109,192,255,64,32,75,187,216,123,19,100,201,80,120,200,150,118,151,21,202,113,107,73,1,69,5,40,138,254,123,37,89,118,221,75,19,73,189,131,135,17,26,221,85,72,132,19,18,9,103,21,215,7,107,212,208,123,18,60,88,83,149,239,85,89,120,55,152,254,27,132,112,91,149,225,103,67,216,7,24,180,134,145,84,16,122,128,246,40,36,217,192,184,217,87,209,141,152,112,77,211,192,206,121,173,5,189,237,115,190,112,192,42,208,137,4,202,18,36,38,214,51,171,89,209,174,190,27,7,25,16,51,51,155,181,95,102,69,108,248,151,95,42,60,57,36,144,214,24,148,113,182,122,1,174,45,138,136,58,44,32,248,145,38,245,162,71,222,166,192,229,224,35,77,249,183,237,17,249,98,207,192,23,193,64,200,158,140,3,199,20,87,122,19,163,199,52,244,52,255,63,45,165,74,166,238,9,157,31,57,43,236,154,185,28,113,89,245,17,121,90,203,115,148,191,179,221,75,104,30,4,245,94,163,97,119,63,157,110,106,121,131,230,60,221,48,166,161,182,126,159,4,86,115,192,31,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("18dfac77-86d7-4509-8aee-d9ad2c50cf9c"));
		}

		#endregion

	}

	#endregion

}

