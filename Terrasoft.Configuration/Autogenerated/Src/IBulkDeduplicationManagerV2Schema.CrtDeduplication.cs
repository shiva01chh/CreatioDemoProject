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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,75,79,220,48,16,62,131,196,127,24,109,47,32,85,137,212,35,164,57,0,203,106,15,180,136,22,238,222,100,146,186,77,236,224,177,15,17,234,127,239,216,217,60,118,151,70,128,68,164,72,158,199,55,243,205,231,135,18,53,82,35,50,132,159,104,140,32,93,216,232,74,171,66,150,206,8,43,181,138,174,49,119,77,37,179,96,157,28,63,159,28,31,57,146,170,132,31,45,89,172,47,246,108,70,87,21,102,62,153,162,21,42,52,50,227,28,206,250,100,176,100,47,172,149,69,83,112,203,115,88,95,186,234,207,78,131,91,161,68,137,230,241,75,128,196,113,12,9,185,186,22,166,77,183,182,135,64,62,197,64,221,129,64,246,149,163,30,27,79,192,141,219,48,98,76,154,235,14,51,220,184,212,115,96,55,76,116,139,246,151,206,233,28,238,66,139,46,184,207,61,56,86,104,9,74,163,93,67,160,11,232,139,35,160,178,210,74,164,104,128,198,251,216,164,17,70,212,160,120,199,190,46,194,26,121,18,90,164,119,195,26,244,230,55,107,31,37,113,136,143,80,131,214,25,69,233,106,174,117,18,247,105,30,23,198,239,147,40,0,239,249,168,240,182,162,31,163,171,244,189,24,83,78,95,244,6,114,4,35,223,51,127,98,142,230,21,26,200,17,108,218,78,175,15,22,230,250,133,142,135,122,44,189,84,237,85,37,89,179,61,109,60,241,193,181,220,74,122,217,134,216,233,76,236,93,250,56,37,159,28,130,193,76,155,156,64,242,95,24,93,3,53,152,201,66,98,62,85,144,163,175,21,47,28,133,246,27,175,23,105,55,107,8,28,202,54,5,141,173,214,57,139,254,48,229,6,130,31,149,246,255,178,63,188,117,144,221,61,89,47,149,171,209,136,77,133,201,202,201,60,245,242,116,53,239,187,146,76,233,134,11,78,78,41,89,227,95,171,113,212,207,112,88,102,103,166,179,139,237,117,71,149,119,55,62,216,127,187,87,109,199,201,62,255,253,3,118,254,167,30,86,5,0,0 };
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

