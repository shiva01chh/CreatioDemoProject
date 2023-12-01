namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportFactorySchema

	/// <exclude/>
	public class IFileImportFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportFactorySchema(IFileImportFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("40607472-ce99-41c0-a6b6-c3ff07be295d");
			Name = "IFileImportFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,81,77,107,132,48,16,61,43,248,31,6,123,105,161,232,189,181,194,178,212,226,109,15,237,15,200,234,40,1,147,200,36,41,72,233,127,239,68,183,110,221,154,91,30,243,62,230,141,22,10,237,40,26,132,119,36,18,214,116,46,59,26,221,201,222,147,112,210,232,172,146,3,214,106,52,228,146,248,43,137,129,159,183,82,247,27,2,225,115,18,39,113,116,71,216,51,9,106,237,144,58,150,125,130,250,42,80,137,198,25,154,194,36,207,230,121,14,133,245,74,9,154,202,203,127,229,65,103,8,206,94,14,109,176,66,237,164,147,104,193,25,184,202,101,191,34,249,31,149,209,159,7,217,128,92,133,246,252,35,94,36,250,23,96,6,222,208,193,72,50,96,139,237,4,157,212,45,82,182,82,242,91,78,49,10,18,10,52,119,249,146,122,139,196,13,106,108,66,125,105,185,88,67,128,193,162,115,188,143,205,138,124,166,236,43,52,102,240,74,219,19,153,6,173,53,148,150,199,5,129,79,49,120,180,217,134,94,159,150,180,175,115,216,106,206,26,182,216,129,239,63,54,217,96,27,245,17,234,139,207,161,239,249,142,130,187,58,180,98,228,34,225,54,210,3,159,59,250,94,78,142,186,93,174,30,190,140,241,251,1,177,51,125,169,86,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("40607472-ce99-41c0-a6b6-c3ff07be295d"));
		}

		#endregion

	}

	#endregion

}

