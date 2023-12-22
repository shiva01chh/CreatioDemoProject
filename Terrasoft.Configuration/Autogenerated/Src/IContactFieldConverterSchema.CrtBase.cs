namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContactFieldConverterSchema

	/// <exclude/>
	public class IContactFieldConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContactFieldConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContactFieldConverterSchema(IContactFieldConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e41c16cf-8b54-48e0-a08f-2fb93df528b9");
			Name = "IContactFieldConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,106,195,48,16,60,59,144,127,88,220,75,115,177,238,121,248,82,72,201,161,37,144,222,74,15,170,178,118,4,182,108,36,185,16,66,255,189,43,69,126,36,141,73,140,15,43,105,102,103,118,88,197,75,52,53,23,8,31,168,53,55,85,102,147,151,74,101,50,111,52,183,178,82,112,154,78,34,250,159,52,230,238,184,81,22,117,70,132,57,108,8,104,185,176,107,137,197,158,234,31,212,244,54,157,16,154,49,6,75,211,148,37,215,199,52,156,3,26,226,117,83,20,160,72,56,134,204,81,65,180,220,164,165,178,1,183,110,190,11,41,64,182,194,163,186,209,201,107,119,86,183,186,170,233,73,162,153,195,214,55,57,191,95,155,27,117,103,176,230,148,66,165,65,28,168,16,164,98,128,83,76,199,164,235,51,116,26,57,216,231,23,236,58,158,11,47,138,114,180,11,95,152,80,252,6,163,168,246,103,175,151,198,223,208,30,170,253,35,174,215,164,113,225,216,106,169,114,208,104,27,173,12,225,17,65,104,204,86,113,152,111,151,151,49,75,41,76,99,185,18,56,50,135,191,113,51,148,190,239,42,246,221,211,255,74,201,146,121,88,207,10,210,233,125,233,37,107,177,142,220,131,224,21,109,127,122,14,35,57,213,217,226,78,20,119,69,187,100,110,140,242,96,20,134,58,62,52,221,72,48,55,67,28,38,17,6,238,83,120,39,236,243,32,31,114,48,243,107,116,189,67,97,175,46,215,138,238,134,223,31,67,129,105,109,241,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e41c16cf-8b54-48e0-a08f-2fb93df528b9"));
		}

		#endregion

	}

	#endregion

}

