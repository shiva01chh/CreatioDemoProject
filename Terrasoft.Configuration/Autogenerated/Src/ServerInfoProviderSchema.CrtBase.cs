namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ServerInfoProviderSchema

	/// <exclude/>
	public class ServerInfoProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ServerInfoProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ServerInfoProviderSchema(ServerInfoProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2935beff-9218-4465-a00f-9cf4abce22f6");
			Name = "ServerInfoProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("3c624d29-361c-47f2-ac8f-7824eb3cde6f");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,107,227,64,12,61,59,144,255,160,109,47,237,197,190,167,155,30,250,5,134,46,13,100,183,45,148,101,153,218,154,116,96,60,99,52,154,108,77,186,255,125,103,108,39,117,83,151,82,131,193,146,158,159,222,147,4,96,68,133,174,22,5,194,79,36,18,206,74,78,207,173,145,106,229,73,176,178,102,58,217,76,39,137,119,202,172,96,217,56,198,234,100,23,15,127,33,76,175,68,193,150,20,186,136,128,240,30,18,174,2,5,228,134,145,100,104,50,131,124,137,180,70,202,141,180,11,178,107,85,34,77,39,1,154,101,25,124,119,190,170,4,53,167,125,220,3,28,120,86,90,113,3,21,242,147,45,29,176,133,21,50,184,150,10,84,224,74,183,20,217,128,163,246,143,90,21,161,222,119,31,111,158,108,90,1,59,177,161,82,35,113,176,1,51,88,180,20,29,224,209,90,13,185,187,86,198,63,195,38,42,56,129,127,111,74,119,202,148,246,175,219,43,30,162,41,59,238,54,238,178,195,100,59,171,225,188,206,181,112,110,6,95,24,85,94,213,26,43,52,220,238,12,172,12,8,68,40,8,229,252,96,196,246,65,118,58,58,178,135,11,148,194,107,62,11,78,194,134,143,184,169,209,202,163,17,134,227,227,223,175,35,46,162,224,17,189,240,193,194,247,103,126,165,80,151,193,241,130,212,90,48,118,197,186,11,192,69,83,5,16,138,210,26,221,192,66,11,150,150,170,252,2,254,20,158,40,184,222,166,96,14,151,102,173,200,154,56,139,244,102,121,139,228,66,131,116,11,136,151,153,140,44,101,100,251,175,203,239,254,232,173,190,189,130,88,72,226,45,118,95,9,33,123,50,35,186,230,3,217,233,47,163,158,225,229,229,51,216,15,81,220,44,239,91,201,241,106,146,254,116,246,148,236,142,238,3,45,223,122,177,239,121,62,61,204,233,36,228,226,243,31,166,140,212,15,40,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2935beff-9218-4465-a00f-9cf4abce22f6"));
		}

		#endregion

	}

	#endregion

}

