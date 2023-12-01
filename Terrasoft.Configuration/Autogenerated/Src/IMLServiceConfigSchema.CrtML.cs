namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMLServiceConfigSchema

	/// <exclude/>
	public class IMLServiceConfigSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMLServiceConfigSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMLServiceConfigSchema(IMLServiceConfigSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a29f714-7093-46e2-bff1-7dfd2aecc270");
			Name = "IMLServiceConfig";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b54cb82a-9c72-40e4-855f-14a0ef44684e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,81,75,106,195,48,16,93,199,224,59,12,222,52,133,98,29,160,142,55,89,180,6,27,10,241,5,20,101,148,136,218,146,25,73,1,83,114,247,74,182,219,226,208,86,27,161,209,188,207,188,209,188,71,59,112,129,208,34,17,183,70,186,124,111,180,84,103,79,220,41,163,243,166,78,147,143,52,217,120,171,244,25,14,163,117,216,63,167,73,168,12,254,216,41,1,74,59,36,25,41,170,166,62,32,93,149,192,153,34,244,68,228,134,49,6,133,245,125,207,105,44,191,10,251,11,138,119,80,18,236,12,1,177,200,226,9,164,33,176,166,187,70,69,119,65,56,171,43,234,64,129,161,139,80,238,178,166,126,35,115,236,176,111,199,1,51,86,230,223,50,236,94,167,24,56,241,30,116,24,116,151,13,63,168,234,148,149,11,9,184,240,206,11,54,117,254,14,20,209,109,75,92,233,224,41,43,43,9,133,40,29,121,44,152,40,97,250,181,113,24,229,30,236,253,36,110,129,173,20,142,198,116,80,217,85,94,17,177,125,241,234,4,43,159,79,48,53,175,44,192,14,36,239,44,62,206,171,248,39,226,201,86,8,145,48,56,11,251,66,109,17,156,1,31,174,166,134,197,192,31,1,78,194,175,220,214,51,110,27,229,54,183,52,185,65,154,132,243,9,15,29,99,185,62,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a29f714-7093-46e2-bff1-7dfd2aecc270"));
		}

		#endregion

	}

	#endregion

}

