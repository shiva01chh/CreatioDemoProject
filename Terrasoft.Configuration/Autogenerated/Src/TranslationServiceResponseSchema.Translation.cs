namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationServiceResponseSchema

	/// <exclude/>
	public class TranslationServiceResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationServiceResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationServiceResponseSchema(TranslationServiceResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5fe50c86-213a-4ba1-9a12-4686b15dab3c");
			Name = "TranslationServiceResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("2c48a34f-0c95-44d9-a69e-4bfc769a17b3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,82,201,110,194,48,16,61,39,18,255,96,209,11,185,228,3,160,237,133,66,85,169,84,21,112,171,170,202,49,67,106,201,177,163,177,77,23,212,127,239,100,1,37,80,34,42,110,246,120,222,50,207,163,121,6,54,231,2,216,18,16,185,53,107,23,143,141,94,203,212,35,119,210,232,120,137,92,91,85,158,123,225,182,23,6,222,74,157,178,197,151,117,144,141,14,238,132,85,10,68,209,108,227,123,208,128,82,28,245,204,189,118,50,131,120,65,175,92,201,239,146,155,186,168,239,10,33,165,11,27,43,110,237,144,53,180,169,121,35,5,204,201,45,113,67,217,253,114,199,29,39,183,14,185,112,175,84,200,125,162,164,96,162,64,119,128,217,144,181,102,60,226,14,182,37,255,222,206,84,130,90,145,159,103,148,27,238,42,241,74,125,6,89,2,56,120,162,24,217,13,235,155,28,42,202,71,147,246,163,194,82,144,87,24,246,48,209,62,163,215,68,193,181,117,72,121,220,178,183,102,255,168,214,4,189,170,100,219,30,200,49,193,188,112,6,15,157,236,36,78,79,60,136,88,241,117,193,207,217,128,201,167,128,188,120,96,16,81,94,9,167,26,252,155,229,175,161,155,51,215,132,65,43,8,10,242,32,151,189,228,169,112,102,224,222,77,249,67,229,6,212,254,170,109,176,142,152,68,215,58,140,17,104,142,133,23,2,172,165,170,87,110,23,88,128,224,60,106,166,225,163,51,222,166,201,139,116,207,77,236,60,95,45,228,5,30,167,92,42,143,80,123,108,237,198,127,236,64,212,241,153,85,181,93,44,107,97,248,11,239,237,44,107,166,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5fe50c86-213a-4ba1-9a12-4686b15dab3c"));
		}

		#endregion

	}

	#endregion

}

