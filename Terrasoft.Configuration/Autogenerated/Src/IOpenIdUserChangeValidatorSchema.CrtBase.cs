namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOpenIdUserChangeValidatorSchema

	/// <exclude/>
	public class IOpenIdUserChangeValidatorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOpenIdUserChangeValidatorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOpenIdUserChangeValidatorSchema(IOpenIdUserChangeValidatorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb3ab0c1-6714-4491-9345-efbe56bcf524");
			Name = "IOpenIdUserChangeValidator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,75,195,64,16,61,183,208,255,48,212,139,66,105,238,90,3,37,244,208,131,8,98,189,79,178,179,201,96,50,27,246,67,45,226,127,119,183,49,106,181,26,8,153,12,243,222,188,247,24,193,142,92,143,21,193,61,89,139,206,104,191,44,140,104,174,131,69,207,70,150,183,61,201,86,173,131,111,102,211,215,217,116,18,28,75,125,52,109,233,234,143,254,114,35,158,61,147,139,3,113,228,204,82,29,41,97,43,158,172,142,75,47,97,59,208,239,28,217,162,65,169,233,1,91,86,232,141,61,32,250,80,182,92,1,143,128,127,231,39,73,222,36,203,50,88,185,208,117,104,247,249,216,40,26,170,30,29,176,6,122,97,231,147,210,16,41,160,66,129,146,160,51,138,53,147,250,196,103,63,9,86,61,90,236,64,98,92,215,243,4,141,33,9,85,41,161,121,254,85,131,55,16,213,96,137,142,86,217,1,115,154,194,237,221,90,117,44,59,97,127,243,177,125,158,143,21,80,202,109,15,70,67,114,250,139,201,146,15,86,92,126,55,124,193,219,64,201,220,41,79,128,162,192,225,83,172,190,137,91,128,241,13,217,103,118,4,3,27,104,108,147,232,145,59,45,43,141,105,161,64,25,162,78,82,206,119,71,222,225,56,138,5,108,6,225,167,236,93,164,43,121,139,111,186,4,18,53,28,195,225,63,118,227,243,14,247,37,67,147,140,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb3ab0c1-6714-4491-9345-efbe56bcf524"));
		}

		#endregion

	}

	#endregion

}

