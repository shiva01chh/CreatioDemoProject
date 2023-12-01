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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,207,74,196,64,12,198,207,45,244,29,194,158,86,144,246,1,172,11,34,21,246,226,69,95,32,157,166,53,210,249,67,38,45,20,241,221,157,109,221,69,69,15,14,115,153,228,203,47,223,55,14,45,197,128,134,224,153,68,48,250,94,203,123,239,122,30,38,65,101,239,202,7,30,233,104,131,23,45,242,183,34,47,242,44,76,237,200,6,216,41,73,127,26,61,110,253,71,175,220,51,73,146,36,97,150,85,85,5,117,156,172,69,89,14,231,194,167,40,130,25,153,156,130,190,160,2,175,243,144,222,172,11,112,132,150,216,13,16,113,166,174,188,160,170,159,172,58,160,160,5,151,50,220,238,34,185,142,100,119,168,171,181,250,187,136,230,180,227,78,134,248,93,55,123,238,54,103,203,222,183,175,100,20,54,220,53,108,209,154,213,217,19,206,201,86,115,102,192,133,118,117,179,126,204,255,19,167,168,198,219,48,146,254,25,244,139,183,198,117,251,211,170,236,189,200,211,77,231,3,203,130,253,105,191,1,0,0 };
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

