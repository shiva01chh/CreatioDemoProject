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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,203,106,195,48,16,69,215,10,228,31,134,116,147,64,240,7,164,143,69,13,237,38,139,64,186,15,178,50,118,68,244,112,53,18,165,132,252,123,37,217,137,91,23,218,104,165,185,115,207,213,136,49,92,35,181,92,32,188,161,115,156,108,237,139,210,154,90,54,193,113,47,173,41,182,86,72,174,166,147,211,116,194,2,73,211,192,246,147,60,234,251,81,29,49,165,80,36,134,138,87,52,232,164,248,229,89,75,243,30,197,40,223,57,108,162,21,74,197,137,86,240,18,71,168,172,61,150,86,107,110,246,217,210,134,74,73,1,34,57,198,6,88,193,51,39,188,218,217,41,35,67,108,156,194,187,32,188,117,49,125,147,147,58,71,159,58,202,155,47,32,125,144,177,13,58,45,137,210,47,224,17,12,126,192,90,146,127,72,143,13,173,167,222,204,82,255,146,52,180,231,179,64,232,118,188,178,193,239,52,206,150,48,18,22,203,191,113,212,92,170,132,117,151,255,236,57,188,118,18,205,158,174,143,93,234,155,96,37,143,56,160,93,117,19,216,30,172,183,3,217,151,139,76,158,211,250,217,185,95,76,28,166,219,77,174,59,245,167,24,181,239,231,11,207,107,242,199,155,2,0,0 };
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

