namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContactsToSyncRequestSchema

	/// <exclude/>
	public class IContactsToSyncRequestSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContactsToSyncRequestSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContactsToSyncRequestSchema(IContactsToSyncRequestSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fe2401fc-4445-4ccb-8923-5d73436003de");
			Name = "IContactsToSyncRequest";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,207,78,194,64,16,198,207,144,240,14,147,122,209,196,180,119,254,244,162,134,144,104,98,0,31,96,105,167,101,147,118,22,103,102,15,72,124,119,183,45,32,69,77,236,105,119,230,235,55,191,175,83,50,53,202,206,100,8,107,100,54,226,10,141,31,28,21,182,244,108,212,58,26,13,15,163,225,192,139,165,18,86,123,81,172,39,87,247,160,175,42,204,26,177,196,115,36,100,155,125,107,46,109,25,67,61,116,110,24,203,160,134,5,41,114,17,134,143,97,17,134,170,201,84,214,110,181,167,108,137,239,30,69,91,117,146,36,48,21,95,215,134,247,233,241,190,196,29,163,32,169,64,141,186,117,185,128,58,40,81,33,59,250,64,225,24,114,163,6,36,248,109,217,145,253,104,3,197,39,203,228,194,115,231,55,149,205,192,158,128,254,228,25,28,90,166,115,132,151,110,250,24,94,91,135,174,121,77,124,68,86,207,36,224,201,6,47,176,121,160,183,133,69,22,112,197,255,176,127,114,119,149,157,97,83,3,133,85,206,34,47,200,129,157,186,133,68,233,130,68,13,133,68,97,200,84,16,33,99,44,102,209,91,95,150,164,241,52,105,109,126,119,13,30,172,143,70,49,74,87,205,177,65,196,159,175,112,151,49,125,182,162,23,169,66,88,9,226,83,183,145,47,158,200,215,200,102,83,225,116,238,109,158,194,28,181,255,205,111,251,140,208,79,118,15,13,206,218,214,8,103,184,187,201,113,57,72,121,183,159,246,254,217,253,116,189,98,91,107,158,47,253,176,6,108,1,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fe2401fc-4445-4ccb-8923-5d73436003de"));
		}

		#endregion

	}

	#endregion

}

