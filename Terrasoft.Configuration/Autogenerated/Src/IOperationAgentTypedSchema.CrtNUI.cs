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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,77,107,194,64,16,134,207,10,254,135,193,94,44,148,228,174,105,64,68,36,7,91,81,233,125,77,38,113,97,179,155,238,135,84,196,255,222,221,141,9,81,26,105,46,97,103,223,103,230,157,217,225,164,68,85,145,20,97,143,82,18,37,114,29,44,4,207,105,97,36,209,84,112,24,13,47,163,225,192,40,202,11,216,157,149,198,114,246,112,182,0,99,152,58,181,10,86,200,81,210,212,106,172,234,69,98,225,114,36,92,163,204,109,149,41,36,159,21,214,153,231,5,114,237,101,97,24,66,164,76,89,18,121,142,111,231,253,185,194,12,104,3,130,200,65,31,237,175,161,129,56,60,104,232,176,131,87,230,192,104,218,97,31,106,70,251,47,194,12,190,193,126,139,202,48,29,195,197,219,104,237,110,164,43,163,41,170,41,108,234,100,181,224,209,168,15,108,81,27,201,21,104,105,16,104,14,165,144,8,228,68,40,35,7,134,65,203,117,45,14,14,66,48,88,91,229,252,68,24,117,66,184,64,129,122,6,87,119,237,221,32,207,106,67,247,238,214,168,143,34,107,173,253,195,25,199,31,13,105,251,72,205,44,37,166,66,102,170,199,161,143,200,58,67,188,232,133,163,176,209,56,40,89,114,83,218,89,219,126,162,118,186,43,212,31,214,65,98,87,69,77,94,103,79,12,239,80,171,126,163,160,133,63,126,27,52,125,115,245,145,138,72,82,2,183,171,253,62,190,177,227,167,45,120,192,243,39,65,51,88,114,95,98,114,215,141,223,153,248,6,37,153,114,141,252,249,80,215,122,245,239,130,62,54,26,118,191,95,50,117,15,251,122,3,0,0 };
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

