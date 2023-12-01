namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AnniversaryRemindingsHelperSchema

	/// <exclude/>
	public class AnniversaryRemindingsHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AnniversaryRemindingsHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AnniversaryRemindingsHelperSchema(AnniversaryRemindingsHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f3683174-bd15-44f4-9f35-a742936c5d37");
			Name = "AnniversaryRemindingsHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7094e60e-83c9-4747-8d9c-40b7b1b1c58b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,209,106,194,64,16,69,159,35,248,15,67,158,34,149,205,7,104,3,173,45,212,62,180,160,254,192,26,71,221,146,76,210,217,221,22,41,254,123,39,27,171,17,82,3,155,13,119,230,92,230,238,134,116,137,182,214,57,194,10,153,181,173,182,78,205,42,218,154,157,103,237,76,69,195,193,207,112,16,121,107,104,119,213,194,168,158,30,39,195,129,20,107,191,46,76,14,214,9,144,67,94,104,107,225,129,200,124,33,91,205,135,5,150,134,54,194,219,23,44,106,100,33,26,203,168,89,105,154,194,212,250,178,148,190,236,79,88,160,243,76,22,44,22,152,59,248,54,110,15,31,149,33,168,53,203,184,78,108,213,25,14,26,144,232,247,113,11,196,217,50,236,106,154,134,98,214,223,155,239,177,212,111,242,29,103,51,207,140,228,160,213,66,195,109,88,95,210,45,59,62,157,208,183,189,210,110,228,235,227,107,103,135,87,201,187,210,235,2,147,147,208,102,27,75,27,55,87,113,25,255,44,245,14,53,130,112,214,81,139,171,198,54,9,222,135,26,213,156,8,121,252,15,24,176,72,189,83,210,91,31,67,60,223,196,35,53,183,207,159,94,23,73,119,160,94,0,238,90,98,18,140,57,220,241,41,85,144,142,242,146,117,108,126,41,121,126,1,133,236,89,156,153,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f3683174-bd15-44f4-9f35-a742936c5d37"));
		}

		#endregion

	}

	#endregion

}

