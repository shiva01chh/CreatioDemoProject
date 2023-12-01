namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: GlobalSearchFeaturesSchema

	/// <exclude/>
	public class GlobalSearchFeaturesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public GlobalSearchFeaturesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public GlobalSearchFeaturesSchema(GlobalSearchFeaturesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8ce6e5c0-35f8-4d5b-be9a-e16f527da2d1");
			Name = "GlobalSearchFeatures";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ca3090cb-7cbd-4956-acde-76442c58fa1e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,207,74,196,48,16,135,207,45,244,29,134,245,162,151,62,192,46,30,164,254,193,131,40,184,62,192,52,157,102,3,49,41,51,137,151,226,187,155,54,41,186,11,230,144,192,55,191,249,152,137,195,79,146,9,21,193,145,152,81,252,24,218,206,187,209,232,200,24,140,119,237,147,245,61,218,119,66,86,167,166,158,155,186,138,98,156,134,142,105,9,180,143,233,137,76,71,175,181,77,252,208,212,41,114,197,164,83,51,116,22,69,246,240,215,81,242,178,230,166,216,91,163,64,45,177,127,82,213,188,38,47,149,31,66,175,119,49,156,114,241,204,179,149,96,15,69,243,66,1,7,12,184,68,139,238,215,231,157,4,142,42,120,78,218,183,85,84,34,197,186,249,174,111,96,94,121,245,44,15,14,123,75,3,220,66,234,165,67,198,247,36,138,205,180,124,91,42,236,82,31,228,65,48,93,228,130,81,235,151,194,232,185,44,11,121,91,16,226,47,163,104,151,69,223,219,136,228,134,60,101,6,133,95,224,76,207,97,98,233,252,0,17,121,211,93,221,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8ce6e5c0-35f8-4d5b-be9a-e16f527da2d1"));
		}

		#endregion

	}

	#endregion

}

