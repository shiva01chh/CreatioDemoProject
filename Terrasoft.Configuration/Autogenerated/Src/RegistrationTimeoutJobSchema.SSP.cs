namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RegistrationTimeoutJobSchema

	/// <exclude/>
	public class RegistrationTimeoutJobSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RegistrationTimeoutJobSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RegistrationTimeoutJobSchema(RegistrationTimeoutJobSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("51199334-03d1-4755-a35a-4e27cf9831ed");
			Name = "RegistrationTimeoutJob";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7352345-17a4-46e8-b32e-306ac0453d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,79,227,48,16,61,23,137,255,48,202,94,18,9,57,119,160,61,108,203,162,34,86,66,187,172,56,187,201,180,152,77,236,104,108,23,170,138,255,190,19,59,45,73,216,146,139,51,31,126,126,243,222,104,89,163,109,100,129,240,136,68,210,154,181,19,115,163,215,106,227,73,58,101,244,249,217,254,252,108,226,173,210,27,248,189,179,14,235,171,81,204,253,85,133,69,219,108,197,45,106,36,85,124,244,244,97,9,79,229,197,226,59,151,184,248,141,112,195,64,48,175,164,181,151,240,139,35,235,34,147,71,85,163,241,238,206,172,32,180,230,121,14,215,214,215,181,164,221,172,139,23,88,161,67,11,248,214,40,194,18,168,119,31,12,65,195,168,175,134,218,66,97,182,72,59,168,148,254,107,197,1,46,239,225,53,126,85,169,2,138,150,201,41,34,151,176,228,227,230,13,11,239,12,241,165,125,160,118,28,227,39,186,103,83,242,32,15,164,182,210,97,172,54,49,128,173,81,101,71,249,38,18,190,111,217,164,127,44,18,155,160,163,168,224,7,97,6,173,33,147,201,130,17,90,38,80,120,34,212,238,24,79,71,23,196,60,54,180,168,236,143,155,15,251,211,236,42,224,109,37,65,25,184,192,52,36,38,26,95,59,118,233,136,66,172,139,31,100,234,52,225,45,232,171,195,184,50,57,116,60,61,35,97,154,180,99,197,9,219,87,147,76,44,237,61,90,155,242,230,248,90,139,7,73,188,134,14,41,29,205,146,117,220,34,47,17,117,62,48,126,239,164,70,93,70,181,79,73,31,124,140,197,96,178,210,204,74,185,210,176,185,132,235,105,210,247,240,248,200,208,132,11,88,46,84,248,227,237,216,243,172,188,195,23,96,86,47,92,126,207,146,124,22,124,141,27,19,108,253,63,204,200,154,1,234,245,16,117,198,203,218,201,98,143,158,127,222,149,145,51,95,40,19,179,195,36,231,250,223,63,121,241,188,157,14,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("51199334-03d1-4755-a35a-4e27cf9831ed"));
		}

		#endregion

	}

	#endregion

}

