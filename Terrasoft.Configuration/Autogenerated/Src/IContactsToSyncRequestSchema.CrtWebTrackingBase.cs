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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,193,78,194,64,16,134,207,144,240,14,147,122,209,196,208,59,148,94,212,16,18,77,12,224,3,44,237,180,108,66,103,113,102,246,128,196,119,119,219,2,182,168,137,61,237,206,252,253,231,251,59,37,83,161,236,77,134,176,70,102,35,174,208,241,131,163,194,150,158,141,90,71,163,225,113,52,28,120,177,84,194,234,32,138,213,244,234,30,244,187,29,102,181,88,198,115,36,100,155,125,107,186,182,140,161,30,58,55,140,101,80,195,130,20,185,8,195,39,176,8,67,213,100,42,107,183,58,80,182,196,119,143,162,141,58,142,99,72,196,87,149,225,67,122,186,47,113,207,40,72,42,80,161,110,93,46,160,14,74,84,200,78,62,80,56,134,220,168,1,9,126,91,118,100,63,154,64,227,179,101,220,241,220,251,205,206,102,96,207,64,127,242,12,142,13,211,37,194,75,59,125,2,175,141,67,219,188,38,62,33,171,103,18,240,100,131,23,216,60,208,219,194,34,11,184,226,127,216,63,185,219,202,222,176,169,128,194,42,103,145,23,228,192,78,237,66,162,116,65,162,134,66,162,48,36,17,68,200,24,139,89,244,214,151,197,233,56,137,27,155,223,93,131,7,235,163,81,140,210,85,125,172,17,241,231,43,220,102,76,159,173,104,39,85,8,43,65,124,238,214,242,197,19,249,10,217,108,118,152,204,189,205,83,152,163,246,191,249,109,159,17,250,201,238,161,198,89,219,10,225,2,119,55,61,45,7,41,111,247,211,220,63,219,159,174,87,108,106,221,231,11,100,244,41,13,9,3,0,0 };
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

