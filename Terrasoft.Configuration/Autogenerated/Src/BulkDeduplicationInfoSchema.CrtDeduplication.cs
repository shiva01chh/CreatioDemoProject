namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkDeduplicationInfoSchema

	/// <exclude/>
	public class BulkDeduplicationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkDeduplicationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkDeduplicationInfoSchema(BulkDeduplicationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2");
			Name = "BulkDeduplicationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3066e968-6ad0-45b5-bf2b-b9af469e0d31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,77,111,194,48,12,134,207,171,196,127,176,224,178,93,218,251,216,118,24,104,18,7,38,4,220,166,29,210,212,173,34,218,164,178,19,105,12,237,191,47,253,128,21,232,129,106,61,68,178,253,230,245,83,187,213,162,64,46,133,68,216,34,145,96,147,218,112,102,116,170,50,71,194,42,163,195,57,38,174,204,149,172,163,81,112,24,5,163,224,206,177,210,25,108,246,108,177,8,215,78,91,85,96,184,65,82,34,87,223,181,114,90,235,38,132,153,15,96,150,11,230,71,120,117,249,238,204,111,161,83,83,11,163,40,130,39,118,69,33,104,255,210,198,149,26,146,174,28,84,173,111,212,81,71,254,49,23,86,120,110,75,66,218,79,159,40,93,236,47,129,172,250,246,183,133,230,77,174,58,215,137,45,57,4,149,94,116,215,198,2,91,65,22,19,136,49,53,132,225,201,161,75,211,224,44,177,136,145,238,223,253,132,225,25,198,138,223,20,177,245,195,26,63,84,132,71,196,216,152,28,22,167,34,28,32,67,59,5,174,142,159,193,136,138,129,156,214,126,59,131,208,214,205,157,94,178,182,118,51,216,138,140,68,102,63,163,18,73,162,182,96,46,41,173,224,221,0,190,242,232,184,106,12,207,49,149,239,176,186,80,220,12,59,111,169,144,65,26,255,29,67,188,7,54,206,155,0,161,52,148,12,192,44,196,215,159,157,7,89,215,6,215,176,203,94,221,63,23,95,141,20,216,201,106,12,131,86,191,105,238,244,174,190,173,245,160,53,231,4,117,210,252,225,62,24,5,62,217,125,126,1,92,208,249,42,92,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e14ddd74-99f1-4f32-b2b4-b4a8b303f9e2"));
		}

		#endregion

	}

	#endregion

}

