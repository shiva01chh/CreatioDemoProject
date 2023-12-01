namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: INotificationCountHandlerSchema

	/// <exclude/>
	public class INotificationCountHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public INotificationCountHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public INotificationCountHandlerSchema(INotificationCountHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e44863be-4aaa-47e8-b8fa-552d50bcc3f3");
			Name = "INotificationCountHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,203,78,195,64,12,60,183,82,255,193,42,23,144,170,228,14,33,151,34,149,92,42,196,227,3,150,141,147,174,72,118,35,175,183,168,66,252,59,222,13,45,208,150,72,57,216,153,25,143,39,182,170,71,63,40,141,240,140,68,202,187,134,179,165,179,141,105,3,41,54,206,206,166,31,179,233,36,120,99,91,120,218,121,198,254,230,168,22,124,215,161,142,96,159,173,208,34,25,45,24,65,93,16,182,210,133,202,50,82,35,67,174,161,90,59,54,141,209,73,123,233,130,229,123,101,235,14,9,18,35,207,115,40,124,232,123,69,187,242,187,126,32,183,53,53,122,232,145,55,174,6,118,64,200,100,112,139,192,27,4,29,85,144,124,182,231,231,191,4,134,240,218,25,13,102,239,224,127,3,2,142,155,78,226,123,108,35,53,30,145,3,89,255,103,38,52,142,64,65,240,72,25,28,152,249,49,181,24,20,169,30,172,132,125,59,215,206,178,210,92,213,243,242,69,120,32,187,217,104,73,36,138,60,1,207,243,90,114,97,152,151,107,41,192,53,201,70,106,157,178,104,116,90,222,153,244,87,196,201,2,222,55,72,8,111,184,3,227,71,94,20,73,123,128,4,0,91,213,5,140,223,82,75,52,247,34,81,181,250,81,42,188,68,111,219,69,140,180,132,21,242,73,158,18,203,229,42,152,26,14,139,46,96,36,141,115,175,226,1,125,142,7,130,182,30,111,100,54,149,142,60,95,197,187,197,142,144,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e44863be-4aaa-47e8-b8fa-552d50bcc3f3"));
		}

		#endregion

	}

	#endregion

}

