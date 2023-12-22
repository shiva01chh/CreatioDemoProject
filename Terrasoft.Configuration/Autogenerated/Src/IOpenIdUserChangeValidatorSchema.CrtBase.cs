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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,75,195,64,16,61,183,224,127,24,234,69,161,52,119,173,129,18,122,232,65,4,177,222,39,217,217,100,48,153,13,251,161,22,241,191,187,219,24,109,181,26,8,153,12,243,222,188,247,24,193,142,92,143,21,193,3,89,139,206,104,191,40,140,104,174,131,69,207,70,22,119,61,201,70,173,130,111,206,166,111,103,211,73,112,44,245,209,180,165,235,63,250,139,181,120,246,76,46,14,196,145,115,75,117,164,132,141,120,178,58,46,189,130,205,64,191,117,100,139,6,165,166,71,108,89,161,55,118,143,232,67,217,114,5,60,2,254,157,159,36,121,147,44,203,96,233,66,215,161,221,229,99,163,104,168,122,114,192,26,232,149,157,79,74,67,164,128,10,5,74,130,206,40,214,76,234,11,159,253,36,88,246,104,177,3,137,113,221,204,18,52,134,36,84,165,132,102,249,119,13,222,64,84,131,37,58,90,102,123,204,105,10,183,115,43,213,177,108,133,253,237,231,246,89,62,86,64,41,183,29,24,13,201,233,47,38,75,62,88,113,249,253,240,5,111,3,37,115,167,60,1,138,2,135,207,177,58,16,55,7,227,27,178,47,236,8,6,54,208,216,38,209,35,119,90,86,26,211,66,129,50,68,157,164,92,108,143,188,195,113,20,115,88,15,194,79,217,187,76,87,242,30,223,116,9,36,106,56,134,253,127,236,30,62,31,63,75,188,120,149,2,0,0 };
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

