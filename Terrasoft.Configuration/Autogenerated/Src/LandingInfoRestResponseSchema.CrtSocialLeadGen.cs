namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingInfoRestResponseSchema

	/// <exclude/>
	public class LandingInfoRestResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingInfoRestResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingInfoRestResponseSchema(LandingInfoRestResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2");
			Name = "LandingInfoRestResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,81,107,131,48,20,133,159,43,248,31,46,244,93,223,219,177,23,199,74,161,108,178,246,15,68,115,117,1,77,36,55,217,40,178,255,190,36,90,103,199,70,173,16,33,39,135,147,239,112,35,89,139,212,177,18,225,132,90,51,82,149,73,50,37,43,81,91,205,140,80,50,57,170,82,176,230,128,140,239,80,198,81,31,71,43,75,66,214,112,60,147,193,118,27,71,78,89,107,172,157,25,178,134,17,109,224,192,36,119,150,189,172,212,27,146,113,171,83,146,48,88,211,52,133,7,178,109,203,244,249,113,220,103,141,178,28,244,104,131,167,211,43,124,10,243,14,194,5,232,54,112,0,43,148,53,208,12,201,64,182,160,82,139,34,32,94,82,211,89,108,103,139,70,148,80,122,160,255,120,96,3,87,237,252,89,174,213,135,224,168,127,152,87,125,224,158,58,58,71,135,218,8,116,69,243,112,203,112,254,187,88,16,158,29,63,8,158,76,134,57,227,5,146,140,246,157,188,119,207,161,135,26,205,22,200,255,190,110,69,75,55,191,197,225,47,206,188,56,62,103,53,46,37,247,222,59,200,67,244,98,114,239,190,139,124,156,246,77,248,157,21,124,122,26,127,210,175,81,242,97,234,97,63,168,215,98,208,230,223,55,54,87,158,120,82,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ff0d71e4-de6c-c97e-7e4b-bdc6aecbd4a2"));
		}

		#endregion

	}

	#endregion

}

