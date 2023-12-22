namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IImportNotifierSchema

	/// <exclude/>
	public class IImportNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IImportNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IImportNotifierSchema(IImportNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3fe64f7-9465-476a-b7e1-7f9edad4dc1e");
			Name = "IImportNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,77,106,195,48,16,133,215,54,248,14,67,86,41,20,235,0,117,3,165,184,144,77,55,233,5,198,242,216,157,96,253,32,141,13,38,244,238,85,236,38,164,165,93,84,104,163,153,55,223,188,39,139,134,162,71,77,240,70,33,96,116,157,148,207,206,118,220,143,1,133,157,45,95,120,160,189,241,46,72,145,159,138,188,200,51,63,54,3,107,96,43,20,186,243,232,126,237,191,58,225,142,41,36,73,18,102,153,82,10,170,56,26,131,97,222,93,10,95,162,8,122,96,178,2,242,142,2,188,204,67,122,179,204,192,17,26,98,219,67,196,137,218,242,138,82,63,89,149,199,128,6,108,202,240,184,137,100,91,10,155,93,165,150,234,239,34,154,210,142,167,208,199,239,186,201,113,187,58,155,183,174,57,146,22,88,113,247,176,70,171,23,103,7,156,146,173,250,194,128,43,237,238,97,249,152,255,39,78,81,181,51,126,32,249,51,232,141,183,218,182,219,243,170,236,163,200,211,189,61,159,238,152,114,212,200,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3fe64f7-9465-476a-b7e1-7f9edad4dc1e"));
		}

		#endregion

	}

	#endregion

}

