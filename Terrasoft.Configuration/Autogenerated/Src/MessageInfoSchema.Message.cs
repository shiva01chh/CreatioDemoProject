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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,201,110,194,48,16,61,19,41,255,96,137,107,149,220,1,33,181,161,2,164,210,162,66,63,192,216,147,96,41,182,35,143,115,136,80,255,189,182,179,148,92,90,32,39,207,242,150,153,216,53,10,85,144,67,131,22,228,60,142,234,171,48,201,116,89,2,179,66,43,76,214,160,192,8,54,180,28,193,24,138,58,183,174,203,64,242,170,172,176,2,208,213,227,72,81,9,88,81,6,163,46,149,139,162,54,212,211,197,209,197,247,77,166,6,10,23,146,172,164,136,51,178,3,68,90,192,86,229,58,148,171,250,84,10,70,152,175,142,139,147,22,63,16,236,141,174,192,120,3,51,178,15,168,182,222,49,160,53,222,115,71,65,46,190,52,65,176,243,112,40,186,195,247,8,179,174,5,39,153,1,106,129,191,52,91,126,27,106,229,218,143,66,66,143,252,80,119,168,237,52,23,185,120,72,174,135,222,170,247,11,108,119,178,17,104,181,105,30,113,253,174,173,151,54,159,192,180,225,183,58,63,105,93,146,13,197,103,107,41,59,75,80,246,31,92,154,166,100,129,181,148,212,52,203,62,177,18,225,122,186,20,65,118,6,73,191,182,28,9,85,156,152,206,13,18,157,147,210,77,231,239,47,38,3,83,122,77,213,47,101,96,91,248,201,158,194,124,75,242,214,163,221,210,232,29,139,57,244,142,30,153,44,60,40,55,149,117,255,227,111,215,109,103,118,166,170,128,99,83,65,151,56,120,100,167,220,11,14,22,58,229,41,40,222,190,160,16,183,217,113,50,228,226,200,127,63,140,15,91,175,43,4,0,0 };
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

