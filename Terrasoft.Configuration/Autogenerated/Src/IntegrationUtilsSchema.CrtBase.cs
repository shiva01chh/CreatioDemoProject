namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationUtilsSchema

	/// <exclude/>
	public class IntegrationUtilsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationUtilsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationUtilsSchema(IntegrationUtilsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d4eda3c2-a9cc-455c-a6b6-3d2187c88a64");
			Name = "IntegrationUtils";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("912fb492-38c7-4dbe-88b2-46a261777d72");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,81,107,131,48,16,199,159,43,248,29,66,159,44,148,124,129,178,151,214,110,20,182,14,102,187,61,103,241,234,2,154,200,37,233,144,209,239,190,196,216,78,71,5,125,48,92,238,126,119,255,228,31,171,133,44,72,214,104,3,213,42,142,108,27,30,0,145,105,117,50,116,163,16,70,182,105,186,190,101,2,79,83,102,152,219,139,35,201,42,208,53,227,48,96,228,73,20,22,153,17,74,198,209,79,28,205,106,251,89,10,78,120,201,180,38,59,105,160,8,217,163,17,165,118,121,95,115,45,210,198,165,56,57,43,145,147,15,20,6,178,70,242,55,208,182,52,201,81,3,186,246,18,184,167,137,29,132,75,242,100,29,163,91,137,93,144,11,28,36,177,237,211,5,170,134,32,99,233,134,162,63,94,14,154,163,168,253,222,194,75,106,117,205,206,12,251,162,159,85,145,241,47,168,24,121,248,167,128,110,165,17,166,9,217,23,38,89,1,72,31,133,204,119,210,157,74,114,88,55,123,119,97,201,124,216,109,190,88,141,204,113,19,238,13,166,27,4,102,32,76,75,134,26,186,94,67,140,102,96,82,56,109,84,105,43,249,206,74,11,58,25,45,236,85,13,148,6,239,119,249,124,217,221,241,180,14,233,213,130,150,188,25,50,13,14,190,183,100,176,110,26,246,122,117,182,37,111,62,79,131,183,136,10,211,191,151,224,85,247,222,197,180,67,59,123,28,231,151,131,168,128,30,13,223,171,239,17,150,157,161,115,227,226,126,151,89,28,185,181,255,253,2,193,22,68,8,188,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d4eda3c2-a9cc-455c-a6b6-3d2187c88a64"));
		}

		#endregion

	}

	#endregion

}

