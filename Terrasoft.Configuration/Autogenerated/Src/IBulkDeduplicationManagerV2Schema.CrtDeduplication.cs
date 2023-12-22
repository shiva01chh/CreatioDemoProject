namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IBulkDeduplicationManagerV2Schema

	/// <exclude/>
	public class IBulkDeduplicationManagerV2Schema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IBulkDeduplicationManagerV2Schema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IBulkDeduplicationManagerV2Schema(IBulkDeduplicationManagerV2Schema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3b690585-6925-4a7e-949f-0578a80311b8");
			Name = "IBulkDeduplicationManagerV2";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,75,79,220,48,16,62,131,196,127,24,109,47,32,85,137,212,35,164,57,0,203,106,15,180,136,22,238,222,100,146,186,77,156,224,177,15,17,234,127,239,216,222,60,118,151,70,128,68,164,72,158,199,55,243,205,231,135,18,53,82,43,50,132,159,168,181,160,166,48,209,85,163,10,89,90,45,140,108,84,116,141,185,109,43,153,121,235,228,248,249,228,248,200,146,84,37,252,232,200,96,125,177,103,51,186,170,48,115,201,20,173,80,161,150,25,231,112,214,39,141,37,123,97,173,12,234,130,91,158,195,250,210,86,127,118,26,220,10,37,74,212,143,95,60,36,142,99,72,200,214,181,208,93,186,181,29,4,242,41,6,234,0,2,217,87,142,122,108,60,1,183,118,195,136,49,105,174,59,204,112,227,82,207,158,221,48,209,45,154,95,77,78,231,112,231,91,132,224,62,119,239,88,161,33,40,117,99,91,130,166,128,190,56,2,42,35,141,68,138,6,104,188,143,77,90,161,69,13,138,119,236,235,194,175,145,39,161,69,122,55,172,161,217,252,102,237,163,36,246,241,17,170,209,88,173,40,93,205,181,78,226,62,205,225,252,248,125,18,121,224,61,31,21,222,86,116,99,132,74,223,139,49,229,244,69,175,39,71,48,242,61,115,39,230,104,94,161,129,28,193,166,11,122,125,176,48,215,47,116,60,212,99,233,164,234,174,42,201,154,237,105,227,136,15,174,229,86,210,203,206,199,78,103,98,239,210,199,42,249,100,17,52,102,141,206,9,36,255,133,110,106,160,22,51,89,72,204,167,10,114,244,181,226,249,163,208,125,227,245,34,13,179,250,192,161,108,83,208,216,106,157,179,232,15,83,110,32,248,81,233,254,47,251,195,91,7,217,221,147,245,82,217,26,181,216,84,152,172,172,204,83,39,79,168,121,31,74,50,165,27,46,56,57,165,100,180,123,173,198,81,63,195,97,153,157,153,206,46,182,215,29,85,30,110,188,183,255,134,87,109,199,201,190,233,247,15,40,18,30,70,94,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3b690585-6925-4a7e-949f-0578a80311b8"));
		}

		#endregion

	}

	#endregion

}

