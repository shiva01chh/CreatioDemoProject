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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,91,107,131,48,20,126,110,161,255,225,208,189,116,48,244,189,45,5,43,22,4,173,101,149,237,57,234,169,11,104,34,73,148,149,178,255,190,99,212,209,150,229,37,228,187,157,75,4,171,81,55,44,71,72,81,41,166,229,197,56,190,20,23,94,182,138,25,46,197,98,126,91,204,103,173,230,162,124,144,40,116,14,44,55,82,113,212,155,127,20,159,152,145,170,174,165,32,150,120,215,133,56,249,8,32,77,192,103,26,207,168,58,78,85,189,67,26,188,67,24,159,162,32,14,142,169,151,134,201,209,177,134,23,133,37,213,7,191,98,90,175,173,41,142,152,40,247,92,20,168,198,76,23,182,186,173,107,166,174,187,241,221,235,160,110,43,195,43,18,183,172,68,200,251,4,200,172,207,153,108,238,157,175,105,179,138,231,163,238,169,208,26,188,166,9,58,20,38,226,218,160,64,181,39,1,153,110,182,133,191,54,99,52,95,178,160,70,79,54,108,32,199,96,217,209,90,120,129,208,73,94,64,34,40,241,108,152,50,171,41,154,54,110,240,219,64,62,220,175,208,239,124,54,203,168,146,115,39,159,232,141,101,237,98,134,63,184,58,125,179,219,48,26,71,14,13,210,239,73,245,102,167,121,70,119,171,101,15,47,135,156,159,113,14,20,197,48,138,125,15,232,35,72,24,157,95,162,40,15,221,50,2,0,0 };
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

