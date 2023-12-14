namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IAfterDeduplicationActionSchema

	/// <exclude/>
	public class IAfterDeduplicationActionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IAfterDeduplicationActionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IAfterDeduplicationActionSchema(IAfterDeduplicationActionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("aec23552-782f-4407-a3bb-de7bbc336923");
			Name = "IAfterDeduplicationAction";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4b7fcaef-4d0d-4f1c-b466-136a63eb8599");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,77,107,2,49,16,134,207,46,236,127,24,236,165,189,36,119,221,10,162,30,60,8,165,244,15,164,155,217,53,176,249,32,31,165,34,253,239,141,19,87,86,41,205,41,243,102,222,135,119,38,70,104,12,78,180,8,31,232,189,8,182,139,108,99,77,167,250,228,69,84,214,176,45,202,228,6,213,82,85,87,231,186,154,165,160,76,127,103,240,200,118,38,170,168,48,44,235,42,183,60,121,236,115,63,236,77,68,223,101,254,2,246,235,46,223,239,112,235,182,64,179,129,115,14,77,72,90,11,127,90,93,235,119,116,30,3,154,24,64,192,81,24,57,160,7,252,198,54,69,148,32,46,56,144,83,30,180,86,187,1,35,178,145,200,39,72,151,62,115,35,168,49,210,127,137,102,103,74,117,155,227,128,241,104,101,88,192,27,65,202,227,99,102,18,182,127,6,26,227,179,155,143,63,26,27,39,188,208,96,242,143,188,206,53,250,30,37,237,244,52,95,29,168,130,188,140,52,68,64,82,89,195,201,64,254,47,171,36,236,202,102,158,139,11,166,136,151,229,117,28,52,178,76,68,245,79,249,171,137,72,202,229,252,2,168,2,111,38,25,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("aec23552-782f-4407-a3bb-de7bbc336923"));
		}

		#endregion

	}

	#endregion

}

