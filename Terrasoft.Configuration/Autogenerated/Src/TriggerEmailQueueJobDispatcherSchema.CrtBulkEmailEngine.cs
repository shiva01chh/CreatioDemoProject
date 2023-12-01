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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,77,107,219,64,16,61,203,144,255,48,208,75,2,70,162,87,197,53,36,169,9,46,117,73,145,67,15,165,7,125,140,229,37,171,93,117,118,215,70,152,252,247,142,180,146,144,219,184,133,222,164,153,55,111,230,205,188,85,105,133,166,78,115,132,45,18,165,70,239,108,248,160,213,78,148,142,82,43,180,186,154,157,174,102,129,51,66,149,144,52,198,98,197,121,41,49,111,147,38,124,68,133,36,242,219,17,51,165,33,12,147,124,143,133,147,72,111,33,190,97,198,168,170,210,138,179,156,127,71,88,50,43,60,200,212,152,24,182,36,202,18,105,85,165,66,126,117,232,240,147,206,62,10,158,214,50,41,117,21,81,20,193,194,184,170,74,169,89,246,255,9,210,1,13,100,78,190,0,182,181,240,179,45,134,163,176,123,96,181,38,45,57,189,211,4,214,55,192,194,227,76,56,48,70,19,202,218,101,82,228,144,183,51,253,99,36,136,225,62,53,120,207,157,47,32,230,176,190,171,235,213,1,149,253,44,120,153,170,213,17,156,58,45,163,252,39,210,53,146,21,200,59,224,111,203,187,198,194,67,186,233,132,98,38,97,11,157,71,237,128,65,61,96,64,31,120,183,162,64,88,175,148,171,144,210,76,226,226,124,156,141,95,192,182,169,113,9,119,82,234,35,22,147,152,129,15,29,103,160,240,8,23,43,191,255,128,83,135,10,46,66,194,4,85,49,93,87,135,127,189,237,165,114,210,171,61,151,190,65,187,215,197,255,235,62,104,81,192,224,57,222,252,181,225,27,179,231,142,154,94,58,155,127,97,191,207,161,143,58,131,212,6,110,122,53,124,154,209,175,163,115,55,66,57,139,178,97,182,197,223,207,191,188,246,59,225,224,35,105,87,251,94,191,181,30,122,206,129,111,44,116,177,86,190,1,107,126,63,247,245,194,248,135,246,204,208,152,77,234,218,137,135,185,226,81,30,245,240,74,152,157,32,92,43,86,229,186,103,25,195,84,201,230,143,124,152,176,185,237,147,102,95,55,55,237,195,12,94,223,60,139,143,158,7,187,216,108,246,11,169,67,167,234,56,4,0,0 };
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

