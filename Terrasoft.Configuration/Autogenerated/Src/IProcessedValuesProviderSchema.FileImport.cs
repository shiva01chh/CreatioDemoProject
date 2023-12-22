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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,207,74,196,48,16,135,207,91,232,59,12,123,82,144,230,1,172,189,236,82,216,219,130,226,125,54,157,74,164,249,195,36,41,136,248,238,166,41,213,80,13,185,100,230,251,205,124,49,168,201,59,148,4,47,196,140,222,142,161,57,89,51,170,183,200,24,148,53,77,175,38,186,104,103,57,212,213,103,93,29,92,188,77,74,130,50,129,120,92,130,151,43,91,73,222,211,240,138,83,36,159,158,179,26,136,19,187,240,7,33,4,180,62,106,141,252,209,109,133,94,153,193,131,219,146,48,47,209,230,7,23,123,190,117,200,168,193,36,221,167,227,64,62,40,147,245,142,221,234,6,210,78,81,27,40,90,77,43,114,232,255,25,43,159,141,247,51,86,151,63,105,166,16,217,248,238,186,147,110,197,214,89,80,123,123,39,25,242,255,242,240,222,242,51,206,116,183,174,56,229,13,231,95,201,82,248,1,74,40,167,161,208,188,127,172,171,180,225,171,174,210,45,207,55,112,224,215,61,196,1,0,0 };
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

