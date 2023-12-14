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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,111,26,49,16,61,111,164,252,135,145,122,73,36,180,168,87,66,145,72,66,34,170,82,165,37,85,15,85,15,222,245,0,86,188,246,118,108,131,86,40,255,189,227,253,64,144,38,180,148,211,50,243,222,248,205,243,140,141,40,208,149,34,71,120,68,34,225,236,194,167,55,214,44,212,50,144,240,202,154,243,179,237,249,89,18,156,50,75,152,87,206,99,193,121,173,49,143,73,151,222,163,65,82,249,213,14,179,95,134,48,157,231,43,148,65,35,189,134,248,142,25,163,138,194,26,206,114,254,29,225,146,171,194,141,22,206,13,224,58,232,167,73,33,148,254,18,48,224,71,155,221,42,150,234,185,34,213,240,126,191,15,67,23,138,66,80,53,106,255,207,145,214,232,32,99,42,96,228,194,175,72,134,141,242,43,224,86,157,88,114,122,97,105,31,34,130,84,104,216,131,146,108,206,24,86,153,118,245,251,123,7,148,33,211,42,135,60,202,59,166,14,88,187,112,120,4,209,131,233,184,44,39,107,52,254,147,98,83,77,108,41,217,214,109,237,108,120,32,91,34,121,133,236,5,127,123,246,28,101,3,169,165,41,195,149,148,151,54,239,71,117,73,217,97,192,174,217,99,37,17,166,19,19,10,36,145,105,28,30,202,153,53,94,60,86,37,142,96,172,181,221,160,220,139,57,248,80,215,76,12,110,224,77,230,143,159,176,173,81,201,155,144,116,44,229,184,245,247,186,186,83,218,115,247,167,113,172,150,72,83,121,26,43,218,250,87,198,87,44,216,42,238,190,227,253,43,227,212,134,94,210,162,186,154,243,124,213,222,57,26,217,92,251,225,12,204,208,175,172,252,255,1,88,91,37,161,91,66,30,193,11,231,41,46,225,198,210,83,189,247,159,249,1,232,65,27,13,14,41,6,46,219,107,229,25,221,45,240,110,149,103,202,4,143,186,226,106,195,35,35,62,186,104,76,225,224,61,217,80,54,7,189,56,183,59,176,7,60,233,202,202,169,105,170,115,195,239,91,83,149,107,158,157,111,12,29,128,167,16,229,118,162,6,187,222,186,59,40,148,91,40,194,169,225,150,66,253,72,13,96,191,141,217,31,249,116,206,251,237,31,44,175,118,117,25,159,169,228,249,213,59,105,162,135,193,58,22,127,191,1,23,215,83,50,72,5,0,0 };
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

