namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationCounterFactorySchema

	/// <exclude/>
	public class INotificationCounterFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationCounterFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationCounterFactorySchema(INotificationCounterFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("77f3b853-df5f-4ea2-af13-167cb7ffd1ed");
			Name = "INotificationCounterFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,193,78,195,48,12,61,175,82,255,193,26,23,184,52,119,40,189,76,48,237,130,16,236,7,178,204,237,34,53,73,101,59,72,21,226,223,73,83,198,38,152,16,57,37,239,61,63,191,200,246,218,33,15,218,32,108,145,72,115,104,165,90,5,223,218,46,146,22,27,124,89,188,151,197,34,178,245,29,188,142,44,232,18,223,247,104,38,146,171,53,122,36,107,238,202,34,169,174,8,187,132,194,198,11,82,155,76,111,97,243,20,196,182,214,100,175,85,136,19,243,168,141,4,26,115,137,82,10,106,142,206,105,26,155,175,247,51,133,55,187,71,6,13,14,229,16,246,32,1,180,49,200,12,114,64,48,189,102,78,116,27,8,58,20,153,162,101,124,182,231,234,232,171,206,140,135,184,235,173,1,123,140,246,119,178,197,244,233,95,225,50,240,130,18,201,115,114,98,209,62,133,130,208,38,21,166,254,132,237,253,242,146,239,82,53,176,27,207,85,231,162,53,133,56,36,201,119,75,245,179,103,61,104,210,14,124,26,214,253,178,203,242,102,155,126,156,175,25,174,106,149,53,167,18,154,115,54,167,105,253,47,104,173,142,149,147,213,230,193,71,135,164,119,61,214,151,10,26,88,163,92,192,249,154,133,166,193,228,136,55,105,63,22,31,243,142,160,223,207,107,82,22,9,73,231,19,50,188,234,160,131,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("77f3b853-df5f-4ea2-af13-167cb7ffd1ed"));
		}

		#endregion

	}

	#endregion

}

