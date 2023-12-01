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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,142,203,106,195,48,16,69,215,49,248,31,6,186,183,247,77,233,38,133,80,8,36,196,249,129,177,52,118,7,44,201,213,131,16,76,255,189,178,100,7,211,69,181,16,204,157,203,153,163,81,145,27,81,16,220,200,90,116,166,243,213,193,232,142,251,96,209,179,209,85,99,4,227,112,34,148,71,210,101,49,149,197,46,56,214,61,52,15,231,73,237,203,34,38,47,150,250,88,134,195,128,206,189,194,9,181,140,149,38,180,78,88,30,103,206,149,190,3,57,159,218,117,93,195,155,11,74,161,125,188,47,243,199,237,12,54,119,224,206,254,11,88,119,198,170,228,0,216,154,224,97,200,212,106,37,212,27,196,24,218,129,5,136,249,254,191,231,119,83,82,120,26,95,172,25,201,122,166,168,125,73,144,188,255,235,152,130,5,12,44,171,103,103,107,177,106,28,3,203,181,252,41,97,130,158,252,30,220,252,253,44,231,73,203,108,144,230,156,110,195,152,196,247,11,181,135,217,42,159,1,0,0 };
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

