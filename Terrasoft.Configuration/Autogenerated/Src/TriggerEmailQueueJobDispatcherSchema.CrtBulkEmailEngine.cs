namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TriggerEmailQueueJobDispatcherSchema

	/// <exclude/>
	public class TriggerEmailQueueJobDispatcherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TriggerEmailQueueJobDispatcherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TriggerEmailQueueJobDispatcherSchema(TriggerEmailQueueJobDispatcherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a0d4e234-cd3d-0785-1103-1944273b2e8b");
			Name = "TriggerEmailQueueJobDispatcher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("8ded9bc0-26e3-4d8b-ab12-46857e761bcf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,77,107,219,64,16,61,43,144,255,48,208,75,2,70,162,87,197,53,36,169,9,46,117,73,145,67,15,165,7,125,140,229,37,171,93,117,118,215,70,152,252,247,142,180,146,144,155,56,133,250,36,207,188,121,51,111,230,173,74,43,52,117,154,35,108,144,40,53,122,107,195,123,173,182,162,116,148,90,161,213,229,197,241,242,34,112,70,168,18,146,198,88,172,56,47,37,230,109,210,132,15,168,144,68,126,51,98,166,52,132,97,146,239,176,112,18,233,45,196,15,204,24,85,85,90,113,150,243,31,8,75,102,133,123,153,26,19,195,134,68,89,34,45,171,84,200,239,14,29,126,209,217,103,193,211,90,38,165,174,34,138,34,152,27,87,85,41,53,139,254,127,130,180,71,3,153,147,207,128,109,45,252,110,139,225,32,236,14,88,173,73,75,78,111,53,129,245,13,176,240,56,19,14,140,209,132,178,118,153,20,57,228,237,76,255,24,9,98,184,75,13,222,113,231,51,136,25,172,110,235,122,185,71,101,191,10,94,166,106,117,4,199,78,203,40,255,145,116,141,100,5,242,14,248,219,242,174,177,240,144,110,58,161,152,73,216,66,231,81,59,96,80,15,24,208,123,222,173,40,16,86,75,229,42,164,52,147,56,63,29,103,237,23,176,105,106,92,192,173,148,250,128,197,36,102,224,83,199,25,40,60,192,217,202,159,191,224,216,161,130,179,144,48,65,85,76,215,213,225,95,110,122,169,156,244,106,79,165,175,209,238,116,241,255,186,247,90,20,48,120,142,55,127,101,248,198,236,185,131,166,231,206,230,223,216,239,51,232,163,206,32,181,129,235,94,13,159,102,244,235,232,220,181,80,206,162,108,152,109,254,254,249,23,87,126,39,28,124,32,237,106,223,235,175,214,67,207,25,240,141,133,46,86,202,55,96,205,31,103,190,94,24,255,208,158,24,26,179,73,93,59,241,48,87,60,202,163,30,94,9,179,21,132,43,197,170,92,247,44,99,152,42,89,191,202,135,9,155,219,62,106,246,117,115,221,62,204,224,229,205,179,248,232,105,176,139,241,239,15,156,186,55,157,57,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a0d4e234-cd3d-0785-1103-1944273b2e8b"));
		}

		#endregion

	}

	#endregion

}

