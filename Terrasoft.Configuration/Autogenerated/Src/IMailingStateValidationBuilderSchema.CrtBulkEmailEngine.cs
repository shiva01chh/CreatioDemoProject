namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingStateValidationBuilderSchema

	/// <exclude/>
	public class IMailingStateValidationBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingStateValidationBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingStateValidationBuilderSchema(IMailingStateValidationBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba");
			Name = "IMailingStateValidationBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("bbfdb6d8-67aa-4e5b-af46-39321e13789f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,59,107,195,48,16,128,231,24,252,31,142,116,105,23,107,111,92,15,41,37,100,8,132,166,116,87,236,179,45,208,35,156,78,41,33,228,191,87,178,147,226,6,10,213,116,15,221,119,159,100,165,65,127,144,53,194,7,18,73,239,90,46,94,157,109,85,23,72,178,114,54,207,206,121,54,11,94,217,14,118,39,207,104,98,95,107,172,83,211,23,43,180,72,170,94,228,89,188,37,132,128,210,7,99,36,157,170,107,190,37,119,84,13,122,48,200,189,107,128,29,116,200,64,65,199,90,235,8,60,75,70,56,74,173,26,201,142,138,27,71,76,64,135,176,215,170,6,101,25,169,77,178,235,141,84,58,42,237,210,240,231,56,27,125,150,65,233,6,41,78,156,7,161,217,3,97,23,235,176,25,150,251,103,216,14,164,177,121,175,59,20,86,200,30,184,199,137,161,25,119,253,54,141,212,226,7,34,238,41,37,33,7,178,190,42,61,34,212,132,237,203,124,253,102,131,65,146,123,141,229,31,254,239,113,103,53,23,21,124,41,238,71,131,162,20,55,86,130,255,23,146,222,145,2,255,248,180,184,126,5,218,102,252,141,33,191,228,217,37,5,211,243,13,31,79,9,194,13,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a8d7af86-6b55-4390-b894-80b48b52f7ba"));
		}

		#endregion

	}

	#endregion

}

