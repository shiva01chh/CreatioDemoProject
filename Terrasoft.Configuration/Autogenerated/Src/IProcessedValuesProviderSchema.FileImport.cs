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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,193,74,196,48,16,134,207,91,232,59,12,123,82,144,230,1,172,189,236,82,216,219,130,226,61,155,78,37,210,76,194,36,41,136,248,238,38,41,213,82,13,185,100,230,251,103,190,144,52,232,157,84,8,47,200,44,189,29,67,115,178,52,234,183,200,50,104,75,77,175,39,188,24,103,57,212,213,103,93,29,92,188,77,90,129,166,128,60,230,224,229,202,86,161,247,56,188,202,41,162,79,207,89,15,200,137,205,252,65,8,1,173,143,198,72,254,232,214,66,175,105,240,224,214,36,204,57,218,252,224,98,207,183,78,178,52,64,73,247,233,56,160,15,154,138,222,177,91,220,64,217,41,26,130,77,171,105,69,9,253,63,99,225,139,241,126,198,226,242,39,205,24,34,147,239,174,59,233,86,172,157,140,218,219,59,170,80,254,87,134,247,150,159,229,140,119,203,138,83,217,112,254,149,220,10,63,192,22,42,105,216,104,222,63,214,85,218,240,85,87,233,230,243,13,74,133,225,213,188,1,0,0 };
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

