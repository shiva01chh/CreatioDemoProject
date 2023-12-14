namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookCommandParameterSchema

	/// <exclude/>
	public class FacebookCommandParameterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookCommandParameterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookCommandParameterSchema(FacebookCommandParameterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55eedac6-1832-49bb-ada6-3ce9df23cd0c");
			Name = "FacebookCommandParameter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,142,49,14,131,48,12,69,103,144,184,67,164,238,57,0,221,138,212,169,67,85,184,128,9,6,89,37,14,117,146,161,69,189,123,3,72,44,168,222,254,215,211,251,102,176,232,39,48,168,26,20,1,239,250,160,43,199,61,13,81,32,144,99,93,59,67,48,22,249,92,228,89,244,196,131,186,38,188,117,238,121,222,155,250,237,3,90,125,35,126,29,202,71,228,64,22,117,141,146,60,244,89,173,137,74,220,73,112,72,65,85,35,120,95,238,222,202,89,11,220,221,65,210,115,1,101,101,167,216,142,100,148,89,208,191,164,42,213,5,60,30,5,217,188,74,190,219,44,114,183,45,47,49,117,203,253,0,203,110,78,71,9,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55eedac6-1832-49bb-ada6-3ce9df23cd0c"));
		}

		#endregion

	}

	#endregion

}

