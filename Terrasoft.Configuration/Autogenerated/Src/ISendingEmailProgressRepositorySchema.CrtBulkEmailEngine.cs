namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISendingEmailProgressRepositorySchema

	/// <exclude/>
	public class ISendingEmailProgressRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISendingEmailProgressRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISendingEmailProgressRepositorySchema(ISendingEmailProgressRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae");
			Name = "ISendingEmailProgressRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b39fd9cb-6840-4142-8022-7c9d0489d323");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,145,193,106,195,48,12,134,207,13,228,29,12,189,108,48,154,251,58,118,41,101,228,48,8,105,95,192,115,148,84,16,91,70,178,11,161,244,221,103,39,45,108,48,58,159,44,235,255,63,253,194,78,91,16,175,13,168,35,48,107,161,62,108,118,228,122,28,34,235,128,228,202,226,82,22,171,40,232,6,117,152,36,128,221,150,69,122,169,170,74,189,73,180,86,243,244,126,171,91,240,12,2,46,136,10,39,80,7,112,93,178,237,173,198,177,97,26,82,79,146,132,4,3,241,164,12,185,192,218,132,205,157,86,253,192,249,248,53,162,81,232,2,112,159,227,213,143,105,201,114,153,115,173,214,12,67,202,173,62,33,156,168,147,87,213,204,168,165,121,38,236,84,237,12,131,77,49,27,6,175,25,186,22,12,122,204,185,159,62,98,18,64,158,81,119,47,121,188,242,55,209,145,114,130,29,69,23,158,183,127,211,200,164,76,255,224,100,89,227,1,39,217,1,207,208,213,14,3,234,177,77,255,67,78,224,55,236,110,93,39,220,178,240,92,95,203,226,154,47,249,124,3,235,124,228,166,219,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cdd44c1d-52e0-461e-8016-96b4499746ae"));
		}

		#endregion

	}

	#endregion

}

