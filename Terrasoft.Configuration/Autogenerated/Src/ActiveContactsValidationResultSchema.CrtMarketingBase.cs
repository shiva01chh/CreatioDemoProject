namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActiveContactsValidationResultSchema

	/// <exclude/>
	public class ActiveContactsValidationResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActiveContactsValidationResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActiveContactsValidationResultSchema(ActiveContactsValidationResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("45311f20-f594-44c6-8b97-79025c4a6695");
			Name = "ActiveContactsValidationResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,75,75,196,48,20,133,215,45,244,63,92,152,125,163,91,71,5,45,46,133,65,197,125,76,239,132,64,155,148,220,155,1,25,252,239,230,97,231,33,226,52,139,64,14,231,156,47,185,196,202,17,105,146,10,225,13,189,151,228,182,220,118,206,110,141,14,94,178,113,182,169,247,77,221,212,16,215,202,163,142,10,116,131,36,186,129,7,197,102,135,209,204,82,49,189,203,193,244,57,241,130,20,6,158,67,66,8,184,165,48,142,210,127,222,31,165,71,73,8,187,67,6,124,14,181,39,25,113,30,154,194,199,96,20,168,196,190,136,174,242,157,171,234,23,188,8,71,59,80,80,10,137,218,131,87,156,154,103,164,179,196,96,44,195,107,177,195,29,92,173,151,1,226,76,157,95,90,255,148,204,177,252,250,167,124,158,247,198,187,9,61,27,140,67,223,228,208,50,184,114,61,254,207,78,212,46,186,96,15,26,121,13,148,182,175,101,237,241,223,144,212,23,0,196,222,88,13,207,197,251,23,102,133,182,47,239,204,231,162,158,139,89,75,235,27,208,64,229,223,173,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("45311f20-f594-44c6-8b97-79025c4a6695"));
		}

		#endregion

	}

	#endregion

}

