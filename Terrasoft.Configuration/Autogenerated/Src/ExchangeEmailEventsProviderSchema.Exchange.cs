namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ExchangeEmailEventsProviderSchema

	/// <exclude/>
	public class ExchangeEmailEventsProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ExchangeEmailEventsProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ExchangeEmailEventsProviderSchema(ExchangeEmailEventsProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a2eb6a61-1c72-4cbf-9db4-831b77de2c84");
			Name = "ExchangeEmailEventsProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77ff850a-3558-415d-9b34-1a36190e74f6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,84,77,111,226,48,16,61,83,169,255,97,148,94,64,170,146,123,129,84,43,196,1,105,43,85,27,246,178,151,149,235,12,196,82,98,35,219,161,133,106,255,251,142,243,1,49,13,81,123,40,167,240,50,243,230,205,155,201,128,100,5,154,29,227,8,107,212,154,25,181,177,97,114,144,60,92,190,241,140,201,45,222,222,188,223,222,140,74,35,228,22,146,131,177,88,76,79,255,207,41,11,165,145,112,122,115,167,113,43,148,132,69,206,140,121,128,150,102,89,48,145,47,247,40,173,121,214,106,47,82,212,85,248,174,124,201,5,7,238,162,135,130,225,130,202,105,60,19,141,222,43,178,115,113,37,141,213,37,183,74,147,134,231,170,70,29,17,69,17,204,76,89,20,76,31,226,22,88,73,97,5,203,197,17,65,226,43,8,74,102,146,44,81,27,138,69,4,174,113,51,15,6,212,5,16,197,240,42,108,6,59,234,3,83,48,36,47,211,74,138,35,179,78,144,65,107,201,49,19,158,52,68,151,34,102,59,166,89,1,110,32,243,160,52,168,169,9,137,220,165,7,113,71,198,111,255,21,21,110,245,134,179,168,226,232,167,52,40,73,105,37,254,71,154,106,52,38,136,147,10,3,116,32,176,26,29,102,113,194,146,166,25,79,86,237,74,99,209,41,226,154,186,102,236,3,150,142,253,62,193,119,228,30,104,190,110,5,63,118,117,15,189,82,160,171,28,230,32,203,60,159,56,41,163,7,120,97,6,199,31,10,244,48,119,57,38,208,44,221,191,239,222,172,207,46,141,21,5,254,81,18,87,114,163,130,120,81,106,77,76,224,208,35,161,95,223,142,117,134,224,0,231,115,179,28,78,184,37,248,98,191,191,58,219,129,225,173,59,77,64,183,35,111,88,125,153,94,240,197,112,238,40,190,190,13,254,161,120,66,155,169,244,51,55,226,218,184,186,135,40,252,169,88,234,128,21,157,201,113,251,144,240,140,62,176,118,99,39,244,77,244,207,179,241,77,237,233,170,18,27,172,126,97,161,44,58,10,24,32,6,227,241,131,72,171,230,201,171,4,245,94,208,178,205,161,125,122,124,236,108,100,3,142,255,250,155,63,153,86,201,26,109,169,101,229,182,223,86,91,142,234,76,175,59,92,163,62,72,88,247,247,31,98,174,21,189,124,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a2eb6a61-1c72-4cbf-9db4-831b77de2c84"));
		}

		#endregion

	}

	#endregion

}

