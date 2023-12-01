namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AsyncAcceptChatNotifierExecutorSchema

	/// <exclude/>
	public class AsyncAcceptChatNotifierExecutorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AsyncAcceptChatNotifierExecutorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AsyncAcceptChatNotifierExecutorSchema(AsyncAcceptChatNotifierExecutorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("de6fad3b-1ad3-c490-fb1b-04c758b887d2");
			Name = "AsyncAcceptChatNotifierExecutor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("08afff10-3d0c-4f3d-b6a0-28a42952a988");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,83,219,110,218,64,16,125,38,82,254,97,228,62,212,72,200,126,111,0,9,81,20,81,53,23,181,161,239,203,122,128,173,236,89,107,47,36,86,148,127,239,120,241,21,165,60,160,157,203,57,115,59,38,81,160,45,133,68,120,65,99,132,213,7,151,172,53,29,212,209,27,225,148,166,228,169,32,37,79,130,8,243,228,1,173,21,71,69,199,219,155,247,219,155,137,183,252,132,223,149,117,88,220,93,217,204,146,231,40,107,10,155,220,35,161,81,178,207,25,22,43,10,77,159,71,12,178,159,35,95,12,30,153,7,214,185,176,22,190,193,202,86,36,87,82,98,233,214,39,225,30,181,83,7,133,38,228,166,105,10,115,235,139,66,152,106,217,216,191,176,52,104,145,156,5,65,32,106,244,201,104,210,222,2,79,230,128,26,130,164,197,167,3,130,210,239,115,37,65,134,218,255,169,188,121,67,233,157,54,220,219,246,135,222,183,38,163,223,67,83,221,4,15,232,78,58,171,103,120,14,180,151,232,117,207,193,209,112,91,208,37,242,41,180,225,230,247,218,187,208,50,55,174,61,185,209,44,121,149,116,100,233,53,219,188,20,70,20,64,124,238,69,228,45,26,62,50,93,206,19,45,119,108,51,97,235,72,230,105,200,254,28,28,222,232,208,216,104,249,220,189,71,152,102,101,103,101,156,23,57,156,181,202,224,178,19,140,119,163,218,48,110,101,6,219,239,42,188,184,247,185,117,134,21,49,3,189,255,203,225,37,244,149,167,80,203,111,50,81,7,136,123,47,44,22,64,62,207,219,232,196,241,102,94,129,240,21,86,230,232,11,22,192,35,135,159,204,166,40,93,181,121,171,175,200,165,226,193,72,32,5,125,117,176,199,64,20,77,239,2,209,71,248,255,169,172,155,223,123,149,45,7,39,89,12,186,98,153,187,63,34,247,24,71,93,66,52,11,245,123,108,60,109,72,207,194,116,194,99,154,58,171,150,212,83,131,108,165,21,143,55,212,128,15,252,109,8,121,130,184,102,105,139,109,51,80,212,247,214,173,161,147,247,142,24,149,213,85,236,186,150,79,168,81,197,61,126,56,239,71,163,92,164,236,34,222,96,95,188,99,39,251,248,247,15,92,156,223,191,74,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("de6fad3b-1ad3-c490-fb1b-04c758b887d2"));
		}

		#endregion

	}

	#endregion

}

