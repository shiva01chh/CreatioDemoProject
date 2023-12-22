namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MessageInfoSchema

	/// <exclude/>
	public class MessageInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MessageInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MessageInfoSchema(MessageInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9feca6c1-1d38-4545-9bd8-624db176b74f");
			Name = "MessageInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,221,110,130,48,20,190,150,132,119,104,226,237,2,247,106,76,54,92,212,100,110,102,186,7,168,237,1,155,64,75,122,202,5,49,123,247,181,165,48,185,217,84,174,122,126,190,159,115,104,27,20,178,32,135,22,13,84,243,56,106,174,194,36,83,101,9,204,8,37,49,89,131,4,45,216,208,114,4,173,41,170,220,216,46,13,201,171,52,194,8,64,91,143,35,73,43,192,154,50,24,117,201,92,20,141,166,142,46,142,46,174,111,50,213,80,216,144,100,37,69,156,145,29,32,210,2,182,50,87,190,92,55,167,82,48,194,92,117,92,156,116,248,129,96,175,85,13,218,25,152,145,189,71,117,245,192,128,70,59,207,129,130,92,92,105,130,96,230,254,80,132,195,247,8,179,110,4,39,153,6,106,128,191,180,91,126,27,106,101,219,143,162,130,30,249,33,239,80,219,41,46,114,241,144,92,15,189,85,239,23,216,237,100,35,208,40,221,62,226,250,93,25,39,173,63,129,41,205,111,117,126,82,170,36,27,138,207,198,80,118,174,64,154,127,112,105,154,146,5,54,85,69,117,187,236,19,43,225,175,167,77,17,100,103,168,232,215,150,35,161,146,19,29,220,32,81,57,41,237,116,238,254,98,50,48,165,215,84,253,82,6,182,133,155,236,201,207,183,36,111,61,218,46,141,222,177,152,67,239,232,145,201,252,131,178,83,25,251,63,254,118,221,117,102,103,42,11,56,182,53,132,196,193,33,131,114,47,56,88,8,202,83,144,188,123,65,62,238,178,227,164,207,197,209,245,247,3,1,211,75,165,51,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9feca6c1-1d38-4545-9bd8-624db176b74f"));
		}

		#endregion

	}

	#endregion

}

