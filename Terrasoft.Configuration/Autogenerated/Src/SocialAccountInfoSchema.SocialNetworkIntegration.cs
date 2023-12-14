namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SocialAccountInfoSchema

	/// <exclude/>
	public class SocialAccountInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SocialAccountInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SocialAccountInfoSchema(SocialAccountInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1f043ea0-5608-4609-9088-37f2047f71ad");
			Name = "SocialAccountInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4e5fe717-963e-416c-b3c1-b2bb720a6449");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,203,106,195,48,16,60,59,144,127,16,233,37,185,248,3,26,122,40,41,148,64,91,66,157,158,74,14,178,188,54,2,91,107,244,56,164,33,255,94,89,171,182,177,227,18,236,147,119,52,51,187,154,149,226,13,152,150,11,96,123,208,154,27,44,109,186,65,85,202,202,105,110,37,170,52,67,33,121,61,159,157,230,179,196,25,169,42,150,29,141,133,102,61,168,211,119,167,172,108,32,205,64,123,129,252,10,114,207,242,188,59,13,149,47,216,166,230,198,220,51,178,124,20,2,189,100,171,74,12,164,207,39,110,185,239,109,53,23,246,224,129,214,229,181,20,76,116,162,49,77,114,10,186,63,119,84,198,106,39,44,106,223,100,23,212,196,136,78,87,30,203,30,194,204,101,181,98,221,141,147,228,5,43,169,216,67,255,48,13,232,58,16,168,209,21,131,96,162,80,155,109,113,69,250,57,32,218,254,216,194,8,137,96,162,124,24,208,35,20,130,3,229,28,67,1,85,80,46,253,144,118,26,91,208,86,194,32,162,144,254,43,52,57,232,229,155,127,20,190,197,194,5,215,197,234,112,145,225,179,147,5,139,83,80,64,21,88,154,205,196,159,243,255,142,117,23,91,223,208,175,172,123,68,20,243,116,71,27,194,25,153,49,134,57,221,209,196,157,140,142,249,187,201,233,190,210,80,222,125,223,28,177,142,139,184,225,57,216,40,161,125,208,99,221,247,13,96,194,169,200,213,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1f043ea0-5608-4609-9088-37f2047f71ad"));
		}

		#endregion

	}

	#endregion

}

