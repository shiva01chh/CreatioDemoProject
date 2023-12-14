namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IConversationProviderSchema

	/// <exclude/>
	public class IConversationProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IConversationProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IConversationProviderSchema(IConversationProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae9b308e-924f-4ea5-bac1-90760e48d38f");
			Name = "IConversationProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5c46c08-cc76-4157-b24b-44267444e258");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,147,193,106,2,49,16,134,207,10,190,195,176,189,180,32,238,189,90,15,21,41,11,109,17,90,232,57,110,102,215,128,73,150,73,34,149,210,119,111,146,117,117,197,149,86,155,219,36,255,204,124,255,36,113,70,168,18,222,182,198,162,28,15,250,131,190,98,18,77,197,114,132,119,36,98,70,23,118,52,211,170,16,165,35,102,133,86,240,21,100,189,27,194,50,68,153,178,72,133,215,223,67,230,117,27,36,19,101,11,210,27,193,145,162,56,77,83,152,24,39,37,163,237,116,23,103,178,90,163,68,101,13,172,117,89,6,12,93,0,126,98,238,98,27,31,84,164,115,228,142,112,212,212,72,91,69,42,183,92,139,28,68,3,208,221,127,135,123,130,16,55,158,125,99,228,190,68,161,73,214,238,216,82,59,11,75,111,78,169,192,116,30,232,148,168,222,169,24,49,9,97,142,15,201,62,225,213,135,201,116,209,132,241,120,52,73,163,246,144,74,104,29,41,51,109,27,1,193,189,176,57,9,210,39,39,56,60,6,194,182,238,214,88,10,192,71,45,239,198,215,184,207,117,184,155,198,180,93,225,229,198,243,22,89,198,147,14,71,7,235,27,237,253,204,21,63,114,19,77,30,87,185,206,140,127,197,154,192,179,255,255,54,47,49,117,146,28,57,102,154,251,103,48,143,72,127,74,120,65,99,88,185,207,145,117,248,235,248,62,132,93,213,25,93,131,28,134,79,3,123,160,33,236,158,78,187,99,24,118,239,187,254,234,168,120,253,219,7,253,184,19,214,15,235,53,15,171,57,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae9b308e-924f-4ea5-bac1-90760e48d38f"));
		}

		#endregion

	}

	#endregion

}

