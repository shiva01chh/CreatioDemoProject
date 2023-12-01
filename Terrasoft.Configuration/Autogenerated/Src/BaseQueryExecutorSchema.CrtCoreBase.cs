namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseQueryExecutorSchema

	/// <exclude/>
	public class BaseQueryExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseQueryExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseQueryExecutorSchema(BaseQueryExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7d0b9ea3-e9cd-412e-bbed-f37d017a5c6e");
			Name = "BaseQueryExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("84b09f59-6bd7-4f07-9626-7a5c32da980f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,147,203,78,235,48,16,134,215,65,226,29,70,98,83,164,42,15,64,213,131,104,213,34,22,32,142,202,97,139,166,206,180,88,114,236,224,11,34,66,231,221,25,59,165,228,82,146,149,199,254,103,230,243,252,142,198,146,92,133,130,224,137,172,69,103,118,62,191,169,170,53,161,15,150,220,249,217,231,249,89,22,156,212,123,216,212,206,83,57,59,198,63,9,75,99,233,183,253,124,165,189,244,146,28,11,88,114,97,105,47,141,134,165,66,231,174,96,129,142,254,6,178,245,234,131,68,240,198,38,81,21,182,74,10,192,173,243,22,133,7,17,197,167,180,217,103,210,31,171,174,37,169,130,203,62,90,249,142,158,154,195,170,9,192,18,22,70,171,26,18,81,189,17,175,84,34,188,80,43,154,157,212,255,115,100,151,70,107,18,62,54,121,9,157,120,118,64,32,93,52,20,93,36,22,242,45,130,96,222,4,102,60,167,81,241,141,118,8,135,151,155,244,186,118,155,78,129,139,198,97,183,233,31,216,203,75,136,134,101,89,15,18,230,48,160,142,170,118,58,107,186,61,243,246,160,238,81,227,158,108,126,75,254,142,111,132,90,208,162,142,29,39,3,132,84,251,255,248,88,120,16,21,217,248,46,70,134,210,27,65,47,156,255,249,197,138,159,2,29,167,59,65,76,238,57,63,134,123,79,254,213,20,99,172,91,99,20,196,225,56,126,124,37,218,122,105,84,40,245,51,170,64,107,169,60,217,73,242,183,89,223,233,157,129,221,113,57,5,19,60,220,6,89,64,53,200,254,182,116,120,194,142,21,180,195,160,124,99,167,37,254,105,117,171,238,117,178,203,109,248,165,40,106,37,174,222,2,42,119,192,106,207,37,239,192,231,209,206,105,42,157,69,192,83,108,243,57,240,243,166,17,207,155,221,238,102,218,227,239,11,20,164,109,116,127,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7d0b9ea3-e9cd-412e-bbed-f37d017a5c6e"));
		}

		#endregion

	}

	#endregion

}

