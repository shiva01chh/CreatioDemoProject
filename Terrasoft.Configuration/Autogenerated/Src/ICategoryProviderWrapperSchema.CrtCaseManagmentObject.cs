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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,145,219,74,196,48,16,134,175,183,208,119,24,246,74,65,154,7,176,246,194,130,139,23,130,184,130,215,217,118,90,34,205,129,73,34,91,196,119,119,186,61,186,134,16,38,97,190,255,159,153,24,169,209,59,89,33,188,35,145,244,182,9,89,105,77,163,218,72,50,40,107,210,228,59,77,118,209,43,211,194,177,247,1,245,125,154,240,139,16,2,114,31,181,150,212,23,211,253,149,236,151,170,17,42,233,135,35,96,107,169,135,134,172,6,45,85,7,39,123,206,102,84,108,88,23,79,157,170,64,153,128,212,12,181,60,151,19,60,41,210,7,73,231,144,56,119,168,230,159,249,229,225,128,97,53,37,236,56,172,71,115,31,157,179,20,150,34,192,117,236,82,131,53,156,87,41,167,208,4,159,45,194,226,90,57,119,146,164,6,195,179,122,216,175,196,190,120,91,226,59,248,180,202,176,166,50,224,3,241,180,178,92,92,176,85,133,48,68,50,190,40,255,76,230,186,56,230,230,196,129,60,68,85,15,173,205,208,19,51,199,17,121,97,226,209,158,111,70,191,77,43,183,252,69,187,159,52,225,189,93,191,5,75,91,211,236,1,0,0 };
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

