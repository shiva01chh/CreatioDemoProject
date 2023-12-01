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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,207,78,194,64,16,198,207,144,240,14,19,188,104,98,232,157,63,189,168,33,36,154,24,192,7,88,218,41,108,66,103,113,102,246,128,196,119,119,218,2,82,212,196,158,118,103,190,126,243,251,58,37,87,162,236,92,134,176,68,102,39,161,208,193,67,160,194,175,35,59,245,129,122,221,67,175,219,137,226,105,13,139,189,40,150,163,171,187,233,183,91,204,42,177,12,166,72,200,62,251,214,92,218,50,90,221,58,55,140,107,83,195,140,20,185,176,225,67,152,217,80,117,153,202,50,44,246,148,205,241,61,162,104,173,78,146,4,198,18,203,210,241,62,61,222,231,184,99,20,36,21,40,81,55,33,23,208,0,107,84,200,142,62,80,4,134,220,169,3,49,191,13,7,242,31,117,160,193,201,50,185,240,220,197,213,214,103,224,79,64,127,242,116,14,53,211,57,194,75,51,125,8,175,181,67,211,188,38,62,34,107,100,18,136,228,205,11,124,110,244,190,240,200,2,161,248,31,246,79,238,166,178,115,236,74,32,91,229,164,31,5,217,216,169,89,72,63,157,145,168,35,75,100,67,198,130,8,25,99,49,233,191,181,101,73,58,24,39,181,205,239,174,230,193,250,232,20,251,233,162,58,86,136,248,243,21,110,50,166,207,94,244,34,149,133,21,19,159,186,149,124,246,68,177,68,118,171,45,142,167,209,231,41,76,81,219,223,252,182,205,8,237,100,247,80,225,44,125,137,112,134,187,27,29,151,131,148,55,251,169,239,159,205,79,215,42,214,53,123,190,0,120,96,79,15,0,3,0,0 };
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

