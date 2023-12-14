namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationResponseSchema

	/// <exclude/>
	public class IntegrationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationResponseSchema(IntegrationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34726720-1e07-4f00-be95-bf2446ea34bc");
			Name = "IntegrationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,145,49,79,195,48,16,133,231,70,234,127,56,149,5,150,100,111,128,37,149,42,164,2,85,219,13,49,184,201,37,88,138,237,232,124,1,149,136,255,142,237,164,197,37,139,115,207,239,222,221,151,104,161,208,118,162,68,56,32,145,176,166,230,180,48,186,150,77,79,130,165,209,233,222,148,82,180,27,20,213,26,245,60,25,230,201,172,183,82,55,176,63,89,70,149,238,122,205,82,97,186,71,114,62,249,29,186,242,121,226,124,55,132,141,43,160,104,133,181,75,120,210,140,205,152,186,145,150,119,110,176,209,22,131,53,203,50,184,183,189,82,130,78,143,83,93,180,166,175,128,38,27,172,14,175,240,37,249,3,164,174,13,169,144,3,166,118,229,37,54,61,39,101,81,212,219,74,176,112,76,76,162,228,119,39,116,253,177,149,37,148,126,171,120,169,243,66,176,132,43,104,167,243,150,204,167,172,144,254,150,158,13,97,241,11,164,115,116,72,44,209,145,110,195,132,241,254,63,89,16,214,200,22,12,129,245,103,4,0,173,251,48,233,165,45,198,24,57,158,81,29,145,110,95,220,111,131,7,88,68,173,254,118,113,231,249,206,128,17,90,252,238,141,48,64,131,156,251,249,57,252,76,32,168,171,145,37,212,163,122,45,6,205,63,191,94,141,10,141,55,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34726720-1e07-4f00-be95-bf2446ea34bc"));
		}

		#endregion

	}

	#endregion

}

