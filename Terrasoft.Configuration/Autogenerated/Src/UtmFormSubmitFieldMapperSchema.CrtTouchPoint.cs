namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: UtmFormSubmitFieldMapperSchema

	/// <exclude/>
	public class UtmFormSubmitFieldMapperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public UtmFormSubmitFieldMapperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public UtmFormSubmitFieldMapperSchema(UtmFormSubmitFieldMapperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6f3e820e-e5f7-490a-95fd-22e45f639cf5");
			Name = "UtmFormSubmitFieldMapper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,193,142,218,48,16,61,131,180,255,48,202,94,64,66,225,190,64,14,165,203,10,137,173,16,236,170,135,170,7,147,76,192,106,108,167,246,132,10,173,250,239,157,196,36,132,46,176,237,41,242,248,205,188,55,111,38,214,66,161,203,69,140,240,130,214,10,103,82,10,167,70,167,114,91,88,65,210,232,187,238,219,93,183,83,56,169,183,176,62,56,66,53,250,235,204,248,44,195,184,4,187,240,9,53,90,25,191,195,44,164,254,121,10,182,185,44,134,51,17,147,177,18,29,35,24,115,111,113,203,197,96,154,9,231,30,224,149,212,204,88,181,46,54,74,210,76,98,150,60,139,60,71,91,97,135,195,33,140,165,222,49,41,37,38,134,216,98,58,9,230,45,88,48,140,24,247,237,51,166,162,200,232,147,212,9,43,232,209,33,71,147,246,230,211,194,145,81,45,120,127,0,95,216,19,152,64,112,141,56,232,127,231,138,121,177,201,36,19,150,34,175,106,132,7,120,79,193,201,111,149,248,83,167,108,29,9,77,220,237,210,202,189,32,244,247,85,119,174,80,74,216,67,84,7,94,118,8,153,168,218,128,92,108,17,94,87,11,72,203,242,97,147,51,108,39,229,190,36,196,37,11,56,178,101,230,194,87,88,114,129,87,155,85,234,202,158,219,225,213,34,24,125,160,131,221,230,81,114,159,255,205,191,58,102,54,204,117,160,230,188,71,157,120,123,206,189,90,90,195,30,18,111,11,155,85,205,224,134,198,39,36,7,196,66,127,225,102,103,204,15,112,166,176,49,94,19,234,71,122,84,248,213,167,172,171,12,152,68,231,129,102,100,225,209,50,121,203,171,70,7,106,146,116,0,205,43,246,79,34,30,43,188,223,200,8,130,211,146,125,100,211,51,210,206,36,151,60,186,249,183,132,252,169,142,206,255,55,181,156,189,145,9,52,119,189,249,163,46,20,90,177,201,112,236,149,70,181,197,30,49,128,133,116,52,62,90,198,47,68,161,52,167,71,160,74,154,196,131,250,80,190,45,157,78,59,22,174,48,207,248,61,234,93,88,208,65,51,2,180,123,217,158,65,27,213,31,93,47,122,182,117,215,203,213,176,243,146,191,47,58,238,163,231,193,42,214,237,254,1,240,120,156,10,93,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6f3e820e-e5f7-490a-95fd-22e45f639cf5"));
		}

		#endregion

	}

	#endregion

}

