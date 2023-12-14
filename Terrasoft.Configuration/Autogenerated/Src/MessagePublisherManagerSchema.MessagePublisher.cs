namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessagePublisherManagerSchema

	/// <exclude/>
	public class MessagePublisherManagerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessagePublisherManagerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessagePublisherManagerSchema(MessagePublisherManagerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9");
			Name = "MessagePublisherManager";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7c74fc90-4a57-4e68-9eda-fe0982d1250d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,193,78,2,49,16,61,215,196,127,24,195,101,73,200,126,128,138,198,64,48,28,48,36,106,60,154,186,59,64,117,105,201,180,139,217,16,255,221,105,187,32,187,128,137,137,28,32,51,188,190,55,239,205,104,185,68,187,146,25,194,19,18,73,107,102,46,29,24,61,83,243,146,164,83,70,159,159,109,206,207,68,105,149,158,195,99,101,29,46,175,90,53,227,139,2,51,15,182,233,61,106,36,149,253,96,246,105,9,79,245,211,145,204,156,33,133,150,17,140,233,16,206,153,15,6,133,180,246,18,38,104,173,156,227,180,124,43,148,93,32,77,164,230,146,2,116,229,155,25,100,30,121,26,40,54,1,188,35,30,41,44,152,120,74,106,45,29,70,81,177,138,21,16,202,220,232,162,130,103,139,196,105,232,232,14,94,203,70,93,191,234,160,206,35,107,83,130,129,214,81,233,125,177,80,152,178,150,137,19,159,152,53,105,137,54,53,187,224,215,33,68,107,20,232,195,193,108,66,124,253,62,224,4,221,194,228,63,41,52,67,48,111,239,76,5,247,232,198,236,67,234,12,19,182,227,87,23,162,126,224,195,233,193,80,5,53,73,213,117,252,179,7,241,247,6,102,156,112,110,135,210,201,237,204,107,73,240,105,232,35,220,219,83,181,194,41,153,181,202,145,120,250,176,232,120,4,21,31,145,187,30,191,28,67,222,36,221,224,76,248,38,56,255,213,63,206,233,73,124,157,236,166,173,95,18,186,146,116,124,123,209,7,93,22,5,220,194,29,251,96,219,134,210,1,111,223,225,206,179,199,245,218,155,239,53,220,93,6,146,191,37,126,120,14,107,163,114,168,143,225,63,146,94,182,206,139,131,74,198,237,155,235,238,175,119,79,109,143,50,166,166,102,144,28,48,214,241,109,85,69,27,144,110,237,212,36,95,167,35,138,221,102,51,244,252,231,27,16,126,145,47,165,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f427a0bd-0b35-4b26-946c-3c6a5598a4f9"));
		}

		#endregion

	}

	#endregion

}

