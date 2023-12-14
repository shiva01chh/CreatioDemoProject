namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendMessageRequestSchema

	/// <exclude/>
	public class SendMessageRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendMessageRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendMessageRequestSchema(SendMessageRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("394b7098-d52a-4248-b5d6-5a4098ccf4ac");
			Name = "SendMessageRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,147,193,78,194,64,16,134,207,146,248,14,19,188,232,165,189,131,154,40,26,226,1,53,194,205,24,51,182,211,58,73,183,139,59,83,18,37,190,187,187,91,64,1,131,193,94,218,153,206,63,221,239,159,105,141,134,100,138,25,193,132,156,67,177,133,38,3,91,23,92,54,14,149,109,157,12,174,199,35,155,83,37,135,157,249,97,231,160,17,174,75,24,191,139,146,233,111,196,201,67,83,43,27,74,198,228,24,43,254,136,29,124,149,175,59,114,84,250,0,6,21,138,244,96,76,117,62,34,17,44,233,129,222,26,18,141,85,105,154,194,169,52,198,160,123,63,95,196,81,1,133,117,224,218,74,80,11,226,245,192,198,80,206,168,4,166,109,149,44,91,164,27,61,78,133,8,43,177,144,57,42,206,186,127,178,38,151,40,228,41,102,156,45,207,215,133,52,116,123,188,66,69,175,82,135,153,62,249,196,180,121,169,56,131,44,158,114,27,11,122,176,221,203,203,230,145,119,101,203,189,179,83,114,202,228,189,185,143,29,219,247,155,134,196,196,144,84,192,251,33,225,174,175,4,100,144,43,249,233,194,182,13,109,102,134,85,67,171,112,242,186,178,14,174,38,119,63,132,223,117,17,120,68,230,133,220,241,173,223,22,56,131,238,66,211,61,9,6,44,29,184,14,135,88,192,195,242,62,135,146,180,31,78,218,135,207,125,144,242,48,86,244,67,14,11,5,182,136,19,15,171,198,53,136,186,240,228,87,194,160,238,71,27,247,102,77,180,155,52,212,63,163,174,147,46,190,31,134,125,161,255,71,140,83,3,206,201,255,52,5,147,219,143,100,135,122,55,82,20,62,115,190,206,52,108,56,111,71,120,147,255,134,116,228,97,219,93,141,113,155,93,79,198,92,184,190,0,113,16,141,77,85,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("394b7098-d52a-4248-b5d6-5a4098ccf4ac"));
		}

		#endregion

	}

	#endregion

}

