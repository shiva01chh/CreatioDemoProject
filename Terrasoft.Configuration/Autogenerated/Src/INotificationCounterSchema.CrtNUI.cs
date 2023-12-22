namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationCounterSchema

	/// <exclude/>
	public class INotificationCounterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationCounterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationCounterSchema(INotificationCounterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b7d7230-b757-4090-bbb0-2b97d1bc90cb");
			Name = "INotificationCounter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,203,78,195,48,16,69,215,173,212,127,24,149,13,72,85,178,135,144,77,145,170,108,16,2,126,192,117,38,137,69,108,71,227,113,81,132,248,119,108,167,143,168,21,94,217,227,235,115,231,97,35,52,186,65,72,132,79,36,18,206,54,156,109,173,105,84,235,73,176,178,102,181,252,89,45,23,222,41,211,194,199,232,24,245,211,213,57,232,251,30,101,20,187,108,135,6,73,201,160,9,170,59,194,54,68,161,50,140,212,4,147,71,168,94,45,171,70,201,196,222,90,31,111,146,54,207,115,40,156,215,90,208,88,30,207,111,100,15,170,70,7,2,52,114,103,107,96,11,45,50,112,135,96,188,222,35,129,109,192,204,144,14,246,35,180,100,253,144,157,160,249,140,58,248,125,175,36,168,83,66,255,228,179,136,53,223,164,148,2,239,200,158,130,205,220,20,228,244,48,153,75,107,88,72,206,206,132,252,26,81,12,130,132,6,19,90,255,188,62,202,171,122,93,110,167,45,132,146,77,132,35,101,69,158,180,151,167,52,217,151,47,42,53,60,96,55,240,221,33,33,124,225,8,202,77,181,199,174,164,156,64,152,26,14,162,247,24,239,82,40,48,79,144,72,173,46,164,194,49,133,177,110,98,123,74,216,33,223,244,230,126,231,85,13,231,148,31,226,87,248,157,70,141,166,158,166,189,90,134,200,124,253,1,222,158,74,112,99,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b7d7230-b757-4090-bbb0-2b97d1bc90cb"));
		}

		#endregion

	}

	#endregion

}

