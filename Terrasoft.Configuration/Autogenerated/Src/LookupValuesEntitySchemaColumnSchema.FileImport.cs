namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesEntitySchemaColumnSchema

	/// <exclude/>
	public class LookupValuesEntitySchemaColumnSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesEntitySchemaColumnSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesEntitySchemaColumnSchema(LookupValuesEntitySchemaColumnSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("76ad8774-b047-419f-b521-b9a051bdfc9f");
			Name = "LookupValuesEntitySchemaColumn";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,75,75,3,49,16,62,111,161,255,97,160,23,5,217,189,91,21,100,177,82,40,34,84,189,199,236,108,27,76,38,107,30,135,82,250,223,77,210,172,110,91,168,186,183,124,153,249,94,89,98,10,109,199,56,194,11,26,195,172,110,93,89,107,106,197,202,27,230,132,166,114,38,36,206,85,167,141,27,143,182,227,81,225,173,160,21,44,55,214,161,154,142,71,1,153,24,92,133,73,128,90,50,107,175,97,161,245,135,239,222,152,244,104,31,200,9,183,89,242,53,42,86,107,233,21,165,149,170,170,224,198,122,165,152,217,220,229,243,61,129,32,235,24,5,51,186,5,183,22,22,120,100,4,174,201,177,112,7,20,220,2,163,6,48,209,130,77,188,224,73,124,122,4,209,68,184,21,104,226,190,76,46,250,73,158,180,203,94,186,26,104,119,254,93,10,158,165,126,243,94,196,10,126,18,207,4,202,38,68,126,78,28,41,218,73,182,4,44,14,220,156,24,46,191,23,135,206,122,107,143,94,52,48,116,243,58,111,166,127,22,219,71,79,221,157,151,177,206,196,167,125,10,131,153,125,130,212,236,163,230,115,206,29,254,144,48,236,185,211,230,40,124,166,58,95,227,197,37,108,97,247,159,133,212,0,30,54,112,213,27,142,201,2,99,100,43,142,90,130,219,227,173,105,26,139,25,195,29,237,163,22,197,238,52,111,198,134,80,66,226,247,5,156,90,9,106,54,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("76ad8774-b047-419f-b521-b9a051bdfc9f"));
		}

		#endregion

	}

	#endregion

}

