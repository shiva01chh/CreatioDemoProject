namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValueToProcessSchema

	/// <exclude/>
	public class ValueToProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValueToProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValueToProcessSchema(ValueToProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfa4da1a-566c-479e-a9dd-b9d6bfc7fa46");
			Name = "ValueToProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,139,194,48,16,133,207,45,244,63,12,120,89,97,241,7,172,120,18,4,111,34,178,247,108,28,75,32,205,148,73,178,10,226,127,223,233,52,216,202,154,91,230,155,247,242,94,130,233,48,246,198,34,156,144,217,68,186,164,213,150,194,197,181,153,77,114,20,86,59,231,113,223,245,196,169,169,239,77,93,245,249,199,59,11,214,155,24,225,219,248,140,39,58,48,89,140,81,232,176,81,45,24,91,145,130,24,197,196,217,38,226,47,56,168,110,192,197,225,85,251,145,93,72,192,116,221,135,51,222,62,65,132,46,180,96,201,231,46,188,206,126,7,225,18,244,169,234,88,20,176,121,138,215,10,182,147,82,216,204,103,196,250,186,0,53,211,209,163,169,53,60,134,243,152,191,220,75,25,201,217,35,39,135,113,234,50,107,83,178,141,182,119,104,49,173,225,241,159,207,83,189,217,210,79,120,86,154,22,222,4,147,169,2,57,127,156,147,10,124,197,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfa4da1a-566c-479e-a9dd-b9d6bfc7fa46"));
		}

		#endregion

	}

	#endregion

}

