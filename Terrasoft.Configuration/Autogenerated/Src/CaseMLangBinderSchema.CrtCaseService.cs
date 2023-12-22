namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CaseMLangBinderSchema

	/// <exclude/>
	public class CaseMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CaseMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CaseMLangBinderSchema(CaseMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e64afc31-7e45-4a5f-b9cc-d14c8c88f3f2");
			Name = "CaseMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("33bac096-c819-4c57-86af-fe71bbb0cb56");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,91,107,131,48,20,126,110,161,255,225,208,189,116,48,244,189,45,5,91,44,8,90,203,42,219,115,212,83,23,208,68,146,40,43,101,255,125,199,168,195,150,229,37,228,187,157,75,4,171,80,215,44,67,72,80,41,166,229,213,56,7,41,174,188,104,20,51,92,138,197,252,190,152,207,26,205,69,241,32,81,232,28,89,102,164,226,168,55,255,40,62,49,37,85,85,73,65,44,241,174,11,81,252,225,67,18,195,129,105,188,160,106,57,85,245,142,137,255,14,65,116,14,253,200,63,37,94,18,196,39,199,26,94,20,22,84,31,14,37,211,122,109,77,81,200,68,177,231,34,71,53,100,186,176,213,77,85,49,117,219,13,239,78,7,85,83,26,94,146,184,97,5,66,214,37,64,106,125,206,104,115,39,190,186,73,75,158,13,186,167,66,107,240,234,218,111,81,152,144,107,131,2,213,158,4,100,186,219,22,254,218,140,208,124,201,156,26,61,219,176,158,28,130,101,75,107,225,57,66,43,121,14,177,160,196,139,97,202,172,198,104,218,184,193,111,3,89,127,191,66,183,243,217,44,165,74,206,68,62,210,27,203,218,197,244,127,112,115,186,102,183,65,56,140,28,24,164,223,147,234,205,78,243,140,238,86,203,14,94,246,57,63,195,28,40,242,126,20,251,238,209,71,144,176,233,249,5,198,46,133,109,59,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e64afc31-7e45-4a5f-b9cc-d14c8c88f3f2"));
		}

		#endregion

	}

	#endregion

}

