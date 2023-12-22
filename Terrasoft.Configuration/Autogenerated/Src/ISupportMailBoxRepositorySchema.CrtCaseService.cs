namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISupportMailBoxRepositorySchema

	/// <exclude/>
	public class ISupportMailBoxRepositorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISupportMailBoxRepositorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISupportMailBoxRepositorySchema(ISupportMailBoxRepositorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8b7ac775-ccba-4dbf-ac65-c1caf69c4152");
			Name = "ISupportMailBoxRepository";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,81,193,106,195,48,12,61,55,144,127,240,113,187,36,31,176,146,195,70,87,122,40,140,101,63,224,100,74,17,196,86,144,228,209,48,246,239,179,147,133,150,102,135,49,227,139,229,247,244,158,158,188,117,32,131,109,193,188,1,179,21,234,180,120,34,223,225,41,176,85,36,159,103,159,121,182,9,130,254,100,234,81,20,220,195,205,59,226,251,30,218,4,150,98,15,30,24,219,11,230,186,45,67,177,243,138,138,32,17,16,33,101,89,154,173,4,231,44,143,213,207,251,133,233,3,223,65,12,53,106,209,167,30,212,25,9,195,64,172,198,89,236,27,58,131,20,11,189,188,226,15,161,233,177,53,232,21,184,75,67,29,234,153,119,140,180,71,58,191,194,64,130,74,60,70,112,154,107,229,96,42,236,65,229,119,197,181,228,92,97,208,192,94,170,122,69,218,150,203,95,2,31,118,62,56,96,219,244,176,157,162,24,171,164,118,92,224,119,247,115,48,127,247,101,58,38,103,100,218,132,17,80,141,129,253,195,233,141,79,81,78,193,95,172,61,71,149,121,221,245,172,49,57,221,124,229,89,188,215,231,27,254,2,53,97,81,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8b7ac775-ccba-4dbf-ac65-c1caf69c4152"));
		}

		#endregion

	}

	#endregion

}

