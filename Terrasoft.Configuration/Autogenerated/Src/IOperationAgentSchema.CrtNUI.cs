namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IOperationAgentSchema

	/// <exclude/>
	public class IOperationAgentSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IOperationAgentSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IOperationAgentSchema(IOperationAgentSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("125ee0b8-83aa-4709-82ef-794af080f041");
			Name = "IOperationAgent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,84,203,78,195,48,16,60,83,169,255,176,42,151,34,161,230,78,75,36,132,170,42,7,30,226,241,1,110,178,9,150,18,59,172,237,10,84,241,239,172,29,98,181,129,150,230,146,120,61,179,51,251,80,148,104,208,180,34,71,120,65,34,97,116,105,103,183,90,149,178,114,36,172,212,10,198,163,237,120,116,230,140,84,21,60,127,26,139,205,124,112,102,66,93,99,238,209,102,182,66,133,36,115,198,48,234,156,176,242,57,50,101,145,74,86,185,130,236,161,197,46,243,77,133,202,6,88,146,36,176,48,174,105,4,125,166,63,231,72,1,93,130,125,227,87,207,3,225,137,179,158,151,236,16,91,183,174,101,14,50,114,7,106,176,13,122,209,215,35,249,172,86,162,185,130,199,142,219,1,134,142,66,224,9,173,35,101,192,146,67,144,37,52,154,16,196,70,200,90,172,107,156,69,222,174,163,179,181,214,53,220,49,242,102,35,106,233,129,176,133,10,237,28,190,252,117,112,131,170,232,12,237,187,187,67,251,166,139,104,237,4,103,10,63,44,228,113,26,125,235,156,146,239,222,114,193,45,144,165,68,50,7,204,134,8,117,201,210,219,83,242,44,146,30,238,249,217,82,185,134,27,206,85,46,86,78,22,41,172,208,222,179,169,140,215,196,76,47,230,71,106,120,109,11,97,209,240,240,74,77,141,216,213,37,204,53,21,199,60,183,130,68,3,138,151,249,122,210,161,179,98,146,190,14,253,178,221,128,252,155,136,31,57,182,94,119,146,46,251,207,61,198,70,203,226,199,231,83,39,194,94,167,190,80,232,69,47,33,82,33,230,59,90,247,51,90,243,255,204,114,97,53,241,234,233,112,201,55,238,208,194,29,236,135,153,156,58,210,65,197,75,21,244,166,191,167,27,83,251,10,255,92,230,175,238,63,176,23,12,177,241,104,247,249,6,108,106,187,104,135,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("125ee0b8-83aa-4709-82ef-794af080f041"));
		}

		#endregion

	}

	#endregion

}

