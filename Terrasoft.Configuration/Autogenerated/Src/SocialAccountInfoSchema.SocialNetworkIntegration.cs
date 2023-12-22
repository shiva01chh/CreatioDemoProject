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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,203,106,195,48,16,60,59,144,127,16,233,37,185,248,3,26,122,40,41,148,64,91,66,157,158,74,14,178,188,54,2,91,50,122,28,210,144,127,175,172,85,91,203,118,9,246,201,59,154,153,93,205,74,208,6,116,75,25,144,35,40,69,181,44,77,186,147,162,228,149,85,212,112,41,210,76,50,78,235,229,226,178,92,36,86,115,81,145,236,172,13,52,219,65,157,190,91,97,120,3,105,6,202,9,248,151,151,59,150,227,221,41,168,92,65,118,53,213,250,158,160,229,35,99,210,73,246,162,148,158,244,249,68,13,117,189,141,162,204,156,28,208,218,188,230,140,176,78,52,165,73,46,94,247,231,46,133,54,202,50,35,149,107,114,240,106,100,4,167,145,199,58,66,136,238,87,27,210,221,56,73,94,100,197,5,121,136,15,83,143,110,61,1,27,141,24,8,35,5,219,236,139,17,233,231,0,105,199,115,11,19,36,132,145,242,161,65,77,80,16,246,148,107,8,5,68,129,185,196,33,29,148,108,65,25,14,131,136,124,250,175,208,228,160,214,111,238,81,184,22,43,235,93,87,155,83,47,195,103,203,11,18,166,192,128,42,48,56,155,14,63,215,255,29,235,46,182,216,208,173,172,123,68,24,243,124,71,227,195,153,152,49,132,57,223,81,135,157,76,142,249,187,201,249,190,92,99,222,177,111,46,101,29,22,113,195,115,176,81,68,99,208,97,253,239,27,43,14,182,175,221,3,0,0 };
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

