namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IProcessedValuesProviderSchema

	/// <exclude/>
	public class IProcessedValuesProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IProcessedValuesProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IProcessedValuesProviderSchema(IProcessedValuesProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d35a2012-d756-4c04-a033-754a28ca5950");
			Name = "IProcessedValuesProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,193,106,195,48,12,134,207,13,228,29,68,79,27,140,248,1,154,229,210,18,232,173,176,178,187,235,40,195,35,150,141,108,7,198,232,187,207,113,72,23,178,25,95,44,125,191,244,153,164,65,239,164,66,184,34,179,244,182,15,213,209,82,175,63,34,203,160,45,85,173,30,240,108,156,229,80,22,223,101,177,115,241,54,104,5,154,2,114,63,5,207,23,182,10,189,199,238,93,14,17,125,122,142,186,67,78,236,196,239,132,16,80,251,104,140,228,175,102,41,180,154,58,15,110,73,194,56,69,171,7,46,182,124,237,36,75,3,148,116,95,247,29,250,160,41,235,237,155,217,13,148,29,162,33,88,181,170,90,228,208,255,51,102,62,27,111,103,204,46,127,210,140,33,50,249,230,178,145,174,197,210,153,80,123,251,68,21,242,255,242,240,214,242,155,28,241,105,94,113,204,27,78,191,146,107,225,23,88,67,57,13,43,205,231,67,89,164,13,247,178,72,55,157,31,14,222,174,142,187,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d35a2012-d756-4c04-a033-754a28ca5950"));
		}

		#endregion

	}

	#endregion

}

