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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,193,78,195,48,12,61,175,82,255,193,26,23,184,52,119,232,122,153,198,180,11,66,176,31,200,50,183,139,212,38,149,237,32,85,136,127,39,77,25,171,96,66,228,148,188,247,252,252,34,219,233,14,185,215,6,97,143,68,154,125,45,197,218,187,218,54,129,180,88,239,242,236,61,207,22,129,173,107,224,117,96,193,46,242,109,139,102,36,185,216,162,67,178,230,33,207,162,234,134,176,137,40,236,156,32,213,209,244,30,118,79,94,108,109,77,242,90,251,48,50,143,218,136,167,33,149,40,165,160,228,208,117,154,134,234,235,253,76,254,205,30,145,65,67,135,114,242,71,16,15,218,24,100,6,57,33,152,86,51,71,186,246,4,13,138,140,209,18,62,217,115,113,246,85,51,227,62,28,90,107,192,158,163,253,157,108,49,126,250,87,184,4,188,160,4,114,28,157,88,180,139,161,192,215,81,133,177,63,97,189,90,94,243,93,170,10,14,195,92,53,23,109,201,135,62,74,190,91,170,159,61,203,94,147,238,192,197,97,173,150,77,146,87,251,248,227,116,77,112,81,170,164,185,148,208,148,179,186,76,235,127,65,75,117,174,28,173,118,27,23,58,36,125,104,177,188,86,80,193,22,229,10,206,183,44,52,14,38,69,188,139,251,177,248,152,118,4,221,113,90,147,60,139,200,252,124,2,92,65,254,234,140,2,0,0 };
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

