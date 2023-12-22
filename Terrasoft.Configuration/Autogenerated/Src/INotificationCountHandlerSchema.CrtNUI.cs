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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,82,203,78,195,64,12,60,183,82,255,193,42,23,144,170,228,14,33,151,34,149,92,42,196,227,3,150,141,147,174,72,188,145,119,183,168,66,252,59,222,13,45,165,133,72,57,216,153,25,143,39,38,213,163,27,148,70,120,70,102,229,108,227,179,165,165,198,180,129,149,55,150,102,211,143,217,116,18,156,161,22,158,118,206,99,127,115,82,11,190,235,80,71,176,203,86,72,200,70,11,70,80,23,140,173,116,161,34,143,220,200,144,107,168,214,214,155,198,232,164,189,180,129,252,189,162,186,67,134,196,200,243,28,10,23,250,94,241,174,252,174,31,216,110,77,141,14,122,244,27,91,131,183,192,232,217,224,22,193,111,16,116,84,65,118,217,158,159,31,9,12,225,181,51,26,204,222,193,255,6,4,28,55,157,196,247,212,70,106,60,162,15,76,238,215,76,104,44,131,130,224,144,51,56,48,243,83,106,49,40,86,61,144,132,125,59,215,150,188,210,190,170,231,229,139,240,64,118,163,104,73,36,138,60,1,255,230,181,108,195,48,47,215,82,128,109,146,141,212,58,103,241,232,180,188,51,233,175,136,147,5,188,111,144,17,222,112,7,198,141,188,40,146,246,0,9,0,182,170,11,24,191,165,150,104,238,69,162,106,245,163,84,56,137,158,218,69,140,180,132,21,250,179,60,37,150,203,85,48,53,28,22,93,192,72,26,231,94,197,3,250,28,15,4,169,30,111,100,54,149,206,241,243,5,37,203,255,22,153,2,0,0 };
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

