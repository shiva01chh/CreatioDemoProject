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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,81,205,106,195,48,12,62,55,144,119,16,221,101,187,36,247,182,235,165,108,172,131,65,15,221,3,56,137,146,120,196,86,144,157,176,81,250,238,83,156,52,52,155,193,6,253,124,63,146,173,50,232,90,149,35,156,145,89,57,42,125,114,32,91,234,170,99,229,53,217,56,186,196,209,170,115,218,86,139,22,198,109,28,73,229,129,177,146,54,56,90,143,92,10,209,6,142,175,74,55,212,35,191,41,91,52,200,161,47,77,83,216,185,206,24,197,63,251,41,62,49,245,186,64,7,6,125,77,133,3,79,96,200,106,79,12,2,133,58,224,161,20,58,151,220,56,210,59,146,182,203,26,157,131,190,105,255,147,6,113,243,78,217,203,55,230,157,176,10,228,18,220,204,182,63,70,229,13,156,2,213,88,252,235,53,36,14,140,202,139,215,47,202,238,125,206,230,70,84,171,88,25,176,178,213,231,117,231,144,101,151,22,243,97,145,235,253,185,70,24,114,144,207,201,100,151,6,196,172,178,24,111,213,147,46,38,97,153,226,241,115,65,8,75,254,167,237,52,25,218,98,28,46,196,87,185,195,55,45,178,215,225,185,63,191,233,170,232,220,7,2,0,0 };
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

