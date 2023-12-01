namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ChainOfCircumstancesExtensionsSchema

	/// <exclude/>
	public class ChainOfCircumstancesExtensionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ChainOfCircumstancesExtensionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ChainOfCircumstancesExtensionsSchema(ChainOfCircumstancesExtensionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7c54472f-f2a2-4576-973d-73866d39766e");
			Name = "ChainOfCircumstancesExtensions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,219,78,195,48,12,134,175,55,105,239,96,198,5,155,132,214,123,216,42,161,177,75,96,130,189,64,150,186,91,164,38,41,137,131,152,38,222,29,39,61,236,32,36,122,209,54,191,253,185,191,237,26,161,209,215,66,34,108,208,57,225,109,73,179,165,53,165,218,5,39,72,89,51,26,30,71,195,65,240,202,236,224,227,224,9,245,227,104,200,202,173,195,29,135,97,89,9,239,31,96,185,23,202,188,149,75,229,100,208,158,132,145,232,87,223,132,198,115,146,79,68,150,101,48,247,65,107,225,14,121,123,78,24,216,18,228,57,8,216,147,179,14,204,206,200,58,108,43,37,129,179,137,31,50,58,248,215,192,224,152,76,244,190,95,144,246,182,96,231,235,84,172,9,94,91,76,194,19,72,171,53,35,181,245,36,173,41,84,156,11,159,148,161,56,21,218,11,226,27,130,67,31,42,2,29,60,153,59,130,45,66,87,66,64,129,165,136,193,47,81,5,140,13,207,107,225,132,118,88,130,225,21,44,198,155,247,68,143,179,124,214,99,23,77,55,10,29,106,76,228,21,150,111,56,16,235,54,38,102,243,172,207,60,193,231,160,140,243,98,140,125,167,87,38,174,178,29,82,112,198,231,235,243,182,57,173,211,99,226,229,38,214,14,11,37,5,225,188,181,149,195,171,165,231,166,245,94,155,208,94,253,189,175,19,150,44,77,33,254,122,131,65,243,193,110,188,139,28,110,86,159,65,84,126,210,40,247,221,112,39,45,62,157,62,70,238,167,93,56,154,162,217,121,58,55,234,165,200,26,95,191,187,12,36,153,11,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7c54472f-f2a2-4576-973d-73866d39766e"));
		}

		#endregion

	}

	#endregion

}

