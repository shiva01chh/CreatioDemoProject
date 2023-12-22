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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,193,10,194,48,16,68,207,45,244,31,22,188,40,136,31,160,120,18,4,111,34,226,61,198,181,4,210,108,217,36,42,136,255,110,186,13,182,162,185,101,223,206,100,38,78,53,232,91,165,17,142,200,172,60,93,195,98,67,238,106,234,200,42,24,114,139,173,177,184,107,90,226,80,149,207,170,44,218,120,182,70,131,182,202,123,56,41,27,241,72,123,38,141,222,39,218,109,20,19,198,58,73,33,25,249,192,81,7,226,37,236,69,215,225,236,240,173,157,70,227,2,48,221,119,238,130,143,57,36,161,113,53,104,178,177,113,223,179,91,39,156,129,60,85,28,178,2,214,31,241,74,192,102,80,38,54,242,233,177,188,158,128,152,201,232,85,149,18,30,221,165,207,159,239,185,76,202,217,34,7,131,126,232,50,106,147,179,245,182,79,168,49,172,224,245,203,199,169,254,108,201,39,124,42,13,11,127,130,165,169,128,209,121,3,185,32,31,248,205,1,0,0 };
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

