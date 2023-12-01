namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFailoverHandlerSchema

	/// <exclude/>
	public class IFailoverHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFailoverHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFailoverHandlerSchema(IFailoverHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("99cf0342-6c2a-4b19-8aa0-db2b06c2b200");
			Name = "IFailoverHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0feb11c-442a-4bb5-a527-aa32bcda81de");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,81,205,106,195,48,12,62,55,144,119,16,221,101,187,36,247,182,235,165,108,172,131,65,15,221,3,56,137,146,120,36,86,144,237,176,81,250,238,83,156,52,52,155,193,6,253,124,63,146,141,106,209,118,42,71,56,35,179,178,84,186,228,64,166,212,149,103,229,52,153,56,186,196,209,202,91,109,170,69,11,227,54,142,164,242,192,88,73,27,28,141,67,46,133,104,3,199,87,165,27,234,145,223,148,41,26,228,208,151,166,41,236,172,111,91,197,63,251,41,62,49,245,186,64,11,45,186,154,10,11,142,160,37,163,29,49,8,20,234,128,135,82,232,108,114,227,72,239,72,58,159,53,58,7,125,211,254,39,13,226,230,157,178,151,111,204,189,176,10,228,18,220,204,182,63,70,229,13,156,2,213,88,252,235,53,36,14,140,202,137,215,47,202,238,125,206,230,70,84,167,88,181,96,100,171,207,107,111,145,101,151,6,243,97,145,235,253,185,70,24,114,144,207,201,100,151,6,196,172,178,24,111,213,147,46,38,97,153,226,241,115,65,8,75,254,167,237,52,25,154,98,28,46,196,87,185,195,55,45,178,215,225,145,243,11,212,184,2,54,254,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("99cf0342-6c2a-4b19-8aa0-db2b06c2b200"));
		}

		#endregion

	}

	#endregion

}

