namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LandingSubscriptionRequestSchema

	/// <exclude/>
	public class LandingSubscriptionRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LandingSubscriptionRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LandingSubscriptionRequestSchema(LandingSubscriptionRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0ca51e0-3be3-3d77-16f1-134361882e48");
			Name = "LandingSubscriptionRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,142,65,106,195,48,16,69,215,49,248,14,3,221,219,251,166,116,147,66,40,4,18,226,92,64,150,198,238,128,37,185,26,137,16,76,239,94,89,178,131,233,162,90,8,230,207,231,205,51,66,35,143,66,34,220,208,57,193,182,243,213,193,154,142,250,224,132,39,107,170,198,74,18,195,9,133,58,162,41,139,169,44,118,129,201,244,208,60,216,163,222,151,69,76,94,28,246,177,12,135,65,48,191,194,73,24,21,43,77,104,89,58,26,103,206,21,191,3,178,79,237,186,174,225,141,131,214,194,61,222,151,249,227,118,6,151,59,112,39,255,5,100,58,235,116,114,0,209,218,224,97,200,212,106,37,212,27,196,24,218,129,36,200,249,254,191,231,119,83,82,120,26,95,156,29,209,121,194,168,125,73,144,188,255,235,152,130,5,12,164,170,103,103,107,177,106,28,3,169,181,252,169,96,130,30,253,30,120,254,126,150,243,104,84,54,72,115,78,183,97,76,182,239,23,128,235,205,22,168,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0ca51e0-3be3-3d77-16f1-134361882e48"));
		}

		#endregion

	}

	#endregion

}

