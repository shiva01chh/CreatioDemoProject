namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICategoryProviderWrapperSchema

	/// <exclude/>
	public class ICategoryProviderWrapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICategoryProviderWrapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICategoryProviderWrapperSchema(ICategoryProviderWrapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f178ef2e-9d2a-41d3-899c-ea2ef4382810");
			Name = "ICategoryProviderWrapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,145,219,74,196,48,16,134,175,183,208,119,24,246,74,65,154,7,176,238,133,5,23,47,4,113,5,175,179,109,90,70,154,3,147,68,182,136,239,238,100,123,90,215,16,194,36,204,247,255,51,19,35,181,242,78,214,10,222,21,145,244,182,13,69,101,77,139,93,36,25,208,154,60,251,206,179,77,244,104,58,56,12,62,40,125,159,103,252,34,132,128,210,71,173,37,13,187,233,254,74,246,11,27,5,181,244,233,8,170,179,52,64,75,86,131,150,216,195,209,158,138,25,21,23,172,139,199,30,107,64,19,20,181,169,150,231,106,130,39,69,250,32,233,156,34,206,77,213,252,51,63,63,236,85,88,77,73,245,28,54,163,185,143,206,89,10,75,17,224,122,118,105,192,26,206,171,209,161,50,193,23,139,176,184,86,46,157,36,169,193,240,172,30,182,43,177,221,189,45,241,29,124,90,52,172,137,6,124,32,158,86,81,138,51,182,170,144,10,145,140,223,85,127,38,115,93,28,115,115,98,34,247,17,155,212,218,12,61,49,115,24,145,23,38,30,237,233,102,244,187,104,229,150,191,104,243,147,103,188,211,250,5,102,253,150,5,228,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f178ef2e-9d2a-41d3-899c-ea2ef4382810"));
		}

		#endregion

	}

	#endregion

}

