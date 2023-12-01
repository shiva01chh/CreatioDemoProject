namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: FacebookCommandSchema

	/// <exclude/>
	public class FacebookCommandSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public FacebookCommandSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public FacebookCommandSchema(FacebookCommandSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eaf15c5a-de82-46d3-9492-d1bed2d4d5e1");
			Name = "FacebookCommand";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,203,106,195,48,16,69,215,10,228,31,134,116,19,67,240,7,164,143,69,13,237,38,139,64,186,15,178,50,118,69,244,112,53,18,165,132,252,123,37,217,137,169,11,109,180,210,220,185,231,106,196,24,174,145,58,46,16,222,208,57,78,182,241,101,101,77,35,219,224,184,151,214,148,59,43,36,87,243,217,105,62,99,129,164,105,97,247,69,30,245,253,164,142,152,82,40,18,67,229,43,26,116,82,252,242,108,164,249,136,98,148,239,28,182,209,10,149,226,68,107,120,137,35,212,214,30,43,171,53,55,135,108,233,66,173,164,0,145,28,83,3,172,225,153,19,94,237,236,148,145,49,54,78,225,93,16,222,186,152,190,205,73,189,99,72,157,228,45,11,72,31,100,108,139,78,75,162,244,11,120,4,131,159,176,145,228,31,210,99,99,235,105,48,179,212,191,36,141,237,229,34,16,186,61,175,109,240,123,141,139,21,76,132,98,245,55,142,154,75,149,176,254,242,159,61,135,55,78,162,57,208,245,177,75,125,19,172,228,17,71,180,175,110,2,187,119,235,237,72,14,101,145,201,115,90,63,59,15,139,137,195,244,187,201,117,175,254,20,163,22,207,55,151,156,167,229,146,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eaf15c5a-de82-46d3-9492-d1bed2d4d5e1"));
		}

		#endregion

	}

	#endregion

}

