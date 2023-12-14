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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,77,79,227,48,16,61,23,137,255,48,202,94,18,9,37,119,160,61,108,203,162,34,86,66,187,172,56,187,201,180,152,77,236,104,108,23,170,138,255,190,99,59,45,73,216,146,139,51,31,126,126,243,222,40,209,160,105,69,137,240,136,68,194,232,181,205,231,90,173,229,198,145,176,82,171,243,179,253,249,217,196,25,169,54,240,123,103,44,54,87,163,152,251,235,26,75,223,108,242,91,84,72,178,252,232,233,195,18,158,202,231,139,239,92,226,226,55,194,13,3,193,188,22,198,92,194,47,142,140,141,76,30,101,131,218,217,59,189,130,208,90,20,5,92,27,215,52,130,118,179,46,94,96,141,22,13,224,91,43,9,43,160,222,125,208,4,45,163,190,106,242,133,82,111,145,118,80,75,245,215,228,7,184,162,135,215,186,85,45,75,40,61,147,83,68,46,97,201,199,205,27,150,206,106,226,75,251,64,237,56,198,79,180,207,186,226,65,30,72,110,133,197,88,109,99,0,91,45,171,142,242,77,36,124,239,217,164,127,12,18,155,160,162,168,224,6,97,6,222,144,201,100,193,8,158,9,148,142,8,149,61,198,211,209,133,124,30,27,60,42,251,99,231,195,254,52,187,10,120,91,65,80,5,46,48,13,137,137,194,215,142,93,58,162,16,235,249,15,210,77,154,240,22,244,213,97,92,145,28,58,158,158,145,48,77,252,88,113,66,255,106,146,229,75,115,143,198,164,188,57,174,81,249,131,32,94,67,139,148,142,102,201,58,110,145,87,30,117,62,48,126,239,164,70,85,69,181,79,73,31,124,140,197,96,178,84,204,74,218,74,179,185,132,235,105,210,247,240,248,200,208,132,11,88,46,100,248,227,237,216,243,172,188,195,23,160,87,47,92,126,207,146,98,22,124,141,27,19,108,253,63,204,200,154,1,234,245,16,117,198,203,218,201,98,142,158,127,222,149,145,51,95,40,19,179,195,36,231,252,247,15,241,242,206,172,6,4,0,0 };
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

