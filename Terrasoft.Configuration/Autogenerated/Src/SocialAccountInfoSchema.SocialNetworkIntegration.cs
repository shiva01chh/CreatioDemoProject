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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,203,106,195,48,16,60,59,144,127,16,233,37,185,248,3,26,122,40,41,148,64,91,66,157,158,74,14,178,188,54,2,91,50,122,28,210,144,127,239,90,171,182,177,227,18,236,147,119,52,51,187,154,149,226,13,216,150,11,96,123,48,134,91,93,186,116,163,85,41,43,111,184,147,90,165,153,22,146,215,243,217,105,62,75,188,149,170,98,217,209,58,104,214,131,58,125,247,202,201,6,210,12,12,10,228,87,144,35,11,121,119,6,42,44,216,166,230,214,222,51,178,124,20,66,163,100,171,74,29,72,159,79,220,113,236,237,12,23,238,128,64,235,243,90,10,38,58,209,152,38,57,5,221,159,187,86,214,25,47,156,54,216,100,23,212,196,136,78,87,30,203,30,194,236,101,181,98,221,141,147,228,69,87,82,177,135,254,97,26,208,117,32,80,163,43,6,193,68,161,54,219,226,138,244,115,64,180,253,177,133,17,18,193,68,249,176,96,70,40,4,7,202,57,134,2,170,160,92,250,33,237,140,110,193,56,9,131,136,66,250,175,208,228,96,150,111,248,40,176,197,194,7,215,197,234,112,145,225,179,151,5,139,83,80,64,21,56,154,205,198,159,243,255,142,117,23,91,223,16,87,214,61,34,138,121,186,163,11,225,140,204,24,195,156,238,104,227,78,70,199,252,221,228,116,95,105,41,239,190,111,174,117,29,23,113,195,115,176,81,66,251,32,98,248,125,3,30,144,249,113,212,3,0,0 };
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

