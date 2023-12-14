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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,146,207,78,195,48,12,198,207,155,180,119,48,227,192,38,161,246,14,91,37,52,118,4,38,216,11,100,169,187,69,106,146,146,56,136,105,226,221,201,159,182,235,38,36,122,104,155,207,254,185,159,237,42,38,209,54,140,35,108,209,24,102,117,69,217,74,171,74,236,157,97,36,180,154,140,79,147,241,200,89,161,246,240,113,180,132,242,113,50,246,202,173,193,189,15,195,170,102,214,62,192,234,192,132,122,171,86,194,112,39,45,49,197,209,174,191,9,149,245,73,54,18,121,158,195,194,58,41,153,57,22,237,57,98,160,43,224,67,16,176,39,179,14,204,7,100,227,118,181,224,224,179,201,63,120,112,240,175,129,209,41,154,232,125,191,32,29,116,233,157,111,98,177,20,188,182,24,133,39,224,90,74,143,52,218,18,215,170,20,97,46,254,36,20,133,169,208,129,145,191,33,24,180,174,38,144,206,146,186,35,216,33,116,37,24,148,88,177,16,252,98,181,195,208,240,162,97,134,73,131,21,40,191,130,229,116,251,30,233,105,94,100,61,118,209,116,82,232,216,96,36,175,176,98,235,3,161,110,50,145,45,242,62,243,12,15,65,30,230,229,49,239,59,190,122,226,42,219,32,57,163,108,177,25,182,237,211,58,61,36,94,110,98,99,176,20,156,17,46,90,91,5,188,106,122,78,173,247,218,140,14,226,239,125,157,177,104,105,14,225,215,27,141,210,7,187,241,46,11,184,89,127,58,86,219,89,82,238,187,225,206,90,124,62,127,12,220,79,187,112,84,101,218,121,60,39,245,82,244,90,184,126,1,155,72,253,110,12,3,0,0 };
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

