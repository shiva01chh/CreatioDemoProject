namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BulkEmailQueueJobDispatcherSchema

	/// <exclude/>
	public class BulkEmailQueueJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BulkEmailQueueJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BulkEmailQueueJobDispatcherSchema(BulkEmailQueueJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("36fbfa11-e34f-c606-1a25-604da3e18cd6");
			Name = "BulkEmailQueueJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,111,26,49,16,61,111,164,252,135,145,122,73,36,180,168,87,66,145,72,66,34,170,82,165,37,85,15,85,15,102,61,128,21,175,189,29,219,160,21,202,127,239,120,63,208,146,38,180,148,211,50,243,222,248,205,243,140,141,200,209,21,34,67,120,68,34,225,236,210,167,55,214,44,213,42,144,240,202,154,243,179,221,249,89,18,156,50,43,152,151,206,99,206,121,173,49,139,73,151,222,163,65,82,217,213,30,211,45,67,152,206,179,53,202,160,145,94,67,124,199,5,163,242,220,26,206,114,254,29,225,138,171,194,141,22,206,13,224,58,232,167,73,46,148,254,18,48,224,71,187,184,85,44,213,115,69,170,224,253,126,31,134,46,228,185,160,114,212,252,159,35,109,208,193,130,169,128,145,11,191,34,25,182,202,175,129,91,117,98,197,233,165,165,46,68,4,169,208,176,7,5,217,140,49,172,50,109,235,247,59,7,20,97,161,85,6,89,148,119,76,29,176,118,225,240,8,162,7,211,113,81,76,54,104,252,39,197,166,154,216,82,178,171,218,218,219,240,64,182,64,242,10,217,11,254,246,236,57,202,26,82,73,83,134,43,41,47,109,214,143,234,146,162,197,128,221,176,199,74,34,76,39,38,228,72,98,161,113,120,40,103,86,123,241,88,22,56,130,177,214,118,139,178,19,115,240,161,170,153,24,220,194,155,204,31,63,97,87,161,146,55,33,233,88,202,113,227,239,117,121,167,180,231,238,79,227,88,45,145,166,242,52,86,180,245,175,140,175,152,179,85,220,125,203,251,87,198,169,13,189,164,69,117,21,231,249,170,185,115,52,178,190,246,195,25,152,161,95,91,249,255,3,176,177,74,66,187,132,60,130,23,206,83,92,194,173,165,167,106,239,63,243,3,208,131,38,26,28,82,12,92,54,215,202,51,186,95,224,253,42,207,148,9,30,117,201,213,134,71,70,124,116,81,155,194,193,123,178,161,168,15,122,113,110,123,96,15,120,210,149,149,83,83,87,231,134,223,55,166,42,87,63,59,223,24,58,0,79,33,202,109,69,13,246,189,181,119,144,43,183,84,132,83,195,45,133,234,145,26,64,183,141,217,31,249,116,206,251,237,31,44,175,118,121,25,159,169,228,249,213,59,169,163,135,193,42,214,253,253,6,72,87,72,138,80,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("36fbfa11-e34f-c606-1a25-604da3e18cd6"));
		}

		#endregion

	}

	#endregion

}

