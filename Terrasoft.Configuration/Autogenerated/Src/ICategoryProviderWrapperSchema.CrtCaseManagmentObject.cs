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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,145,219,106,195,48,12,134,175,27,200,59,136,94,109,48,146,7,88,214,139,5,86,118,49,24,235,96,215,110,162,4,141,248,128,108,143,134,177,119,159,210,156,186,206,24,35,27,125,255,47,201,70,105,244,78,85,8,239,200,172,188,109,66,86,90,211,80,27,89,5,178,38,77,190,211,100,19,61,153,22,14,189,15,168,239,211,68,94,242,60,135,194,71,173,21,247,187,233,254,202,246,139,106,132,74,249,225,8,216,90,238,161,97,171,65,43,234,224,104,79,217,140,230,23,172,139,199,142,42,32,19,144,155,161,150,231,114,130,39,69,254,96,229,28,178,228,14,213,252,51,63,63,236,49,172,166,140,157,132,245,104,238,163,115,150,195,82,4,184,78,92,106,176,70,242,42,114,132,38,248,108,17,206,175,149,11,167,88,105,48,50,171,135,237,74,108,119,111,75,124,7,159,150,140,104,146,1,31,88,166,149,21,249,25,91,85,24,67,100,227,119,229,159,201,92,23,39,220,156,56,144,251,72,245,208,218,12,61,9,115,24,145,23,33,30,237,233,102,244,187,104,229,86,190,104,243,147,38,178,101,253,2,235,5,192,153,227,1,0,0 };
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

