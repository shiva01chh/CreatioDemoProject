namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCommandResultSchema

	/// <exclude/>
	public class BaseCommandResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCommandResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCommandResultSchema(BaseCommandResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d2b8d1ca-42bf-4559-aeb0-b421b90c0d74");
			Name = "BaseCommandResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,205,110,194,48,12,62,183,18,239,16,193,5,46,125,0,42,46,235,174,76,136,246,54,77,147,105,77,21,169,73,42,199,129,49,180,119,159,155,210,1,90,79,206,231,239,207,181,96,208,247,80,163,170,144,8,188,59,114,86,56,123,212,109,32,96,237,108,86,186,90,67,55,75,175,179,52,9,94,219,86,149,23,207,104,178,125,176,172,13,102,37,146,16,244,119,164,231,179,84,120,11,194,86,30,170,232,192,251,181,122,1,143,133,51,6,108,179,71,31,58,142,164,247,87,96,144,44,38,168,249,67,128,62,28,58,93,171,122,16,253,215,168,181,122,42,38,177,39,93,163,44,123,103,61,138,254,26,109,255,194,119,228,122,36,214,40,13,118,209,122,220,199,220,45,154,3,210,242,77,206,87,27,53,103,252,226,249,106,40,49,181,240,76,195,173,149,44,212,112,122,146,180,200,121,28,252,109,248,25,253,122,210,39,96,84,205,197,130,17,229,39,193,57,127,112,154,240,61,156,239,78,183,41,33,228,64,246,174,25,76,199,136,137,49,172,164,226,9,186,128,35,37,137,165,54,81,148,85,174,140,77,151,171,7,253,173,217,2,109,51,254,140,248,30,209,103,80,48,249,126,1,170,142,42,133,6,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2b8d1ca-42bf-4559-aeb0-b421b90c0d74"));
		}

		#endregion

	}

	#endregion

}

