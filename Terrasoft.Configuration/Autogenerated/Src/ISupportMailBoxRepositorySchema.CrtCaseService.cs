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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,81,193,106,195,48,12,61,55,208,127,240,113,187,36,31,176,144,195,70,87,122,40,140,101,63,224,100,74,17,196,86,144,228,209,48,246,239,179,147,133,150,102,135,49,227,139,229,247,244,158,158,188,117,32,131,109,193,188,1,179,21,234,52,127,34,223,225,41,176,85,36,191,205,62,183,217,38,8,250,147,169,71,81,112,15,55,239,136,239,123,104,19,88,242,61,120,96,108,47,152,235,182,12,249,206,43,42,130,68,64,132,20,69,97,74,9,206,89,30,171,159,247,11,211,7,190,131,24,106,212,162,79,61,168,51,18,134,129,88,141,179,216,55,116,6,201,23,122,113,197,31,66,211,99,107,208,43,112,151,134,58,212,51,239,24,105,143,116,126,133,129,4,149,120,140,224,52,215,202,193,84,216,131,202,239,138,107,201,185,194,160,129,189,84,245,138,84,22,203,95,2,31,118,62,56,96,219,244,80,78,81,140,85,82,59,46,240,187,251,57,152,191,251,50,29,147,51,50,109,194,8,168,198,192,254,225,244,198,167,40,167,224,47,214,158,163,202,188,238,122,214,152,156,110,190,182,89,188,241,124,3,116,85,125,212,72,2,0,0 };
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

