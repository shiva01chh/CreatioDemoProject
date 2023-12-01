namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOperationAgentTypedSchema

	/// <exclude/>
	public class IOperationAgentTypedSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOperationAgentTypedSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOperationAgentTypedSchema(IOperationAgentTypedSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5b084da8-1bf5-4242-9e04-24f04039b8b1");
			Name = "IOperationAgentTyped";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,107,194,64,16,134,207,10,254,135,193,94,44,148,228,174,105,64,68,36,7,91,209,208,251,154,76,226,194,102,55,221,15,169,136,255,189,187,27,19,84,26,105,46,97,103,223,103,230,157,217,225,164,66,85,147,12,33,69,41,137,18,133,14,22,130,23,180,52,146,104,42,56,140,134,231,209,112,96,20,229,37,236,78,74,99,53,123,56,91,128,49,204,156,90,5,43,228,40,105,102,53,86,245,34,177,116,57,18,174,81,22,182,202,20,146,207,26,155,204,243,18,185,246,178,48,12,33,82,166,170,136,60,197,215,115,122,170,49,7,218,130,32,10,208,7,251,107,105,32,14,15,90,58,188,193,107,179,103,52,187,97,31,106,70,233,23,97,6,223,32,221,162,50,76,199,112,246,54,58,187,27,233,202,104,138,106,10,155,38,89,35,120,52,234,3,91,212,70,114,5,90,26,4,90,64,37,36,2,57,18,202,200,158,97,208,113,183,22,7,123,33,24,172,173,114,126,36,140,58,33,156,161,68,61,131,139,187,246,110,144,231,141,161,123,119,107,212,7,145,119,214,254,225,140,227,143,134,172,123,164,118,150,18,51,33,115,213,227,208,71,100,147,33,94,244,194,81,216,106,28,148,44,185,169,236,172,109,63,81,55,221,21,234,15,235,32,177,171,162,38,175,179,39,134,119,168,85,191,81,208,194,31,191,13,154,190,185,250,72,77,36,169,128,219,213,126,31,95,217,241,211,22,60,224,249,163,160,57,44,185,47,49,185,235,198,239,76,124,133,146,92,185,70,254,124,168,75,179,250,119,65,31,27,13,237,247,11,231,43,232,104,113,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5b084da8-1bf5-4242-9e04-24f04039b8b1"));
		}

		#endregion

	}

	#endregion

}

