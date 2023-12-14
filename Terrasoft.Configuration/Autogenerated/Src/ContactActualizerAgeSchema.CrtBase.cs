namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactActualizerAgeSchema

	/// <exclude/>
	public class ContactActualizerAgeSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactActualizerAgeSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactActualizerAgeSchema(ContactActualizerAgeSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("b6997510-8ca5-4b43-92fb-c0f6cd54daae");
			Name = "ContactActualizerAge";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("79c177f7-ba6c-471b-a777-73cb1e762283");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,203,110,194,48,16,60,131,196,63,172,224,66,165,10,245,76,148,74,16,122,108,139,212,242,1,198,217,4,171,198,142,252,168,74,17,255,222,205,131,64,66,210,30,154,147,189,59,51,251,240,68,177,61,218,140,113,132,119,52,134,89,157,184,89,164,85,34,82,111,152,19,90,141,134,199,209,112,224,173,80,105,3,98,48,24,13,41,51,49,152,18,12,32,146,204,218,57,16,217,49,238,22,220,121,38,197,55,46,82,44,112,153,223,74,193,129,231,168,27,144,33,20,204,97,201,44,54,98,196,59,22,236,186,12,49,173,51,158,59,109,230,176,46,52,75,64,165,223,165,60,221,88,52,148,80,200,243,137,192,55,174,119,84,120,75,133,167,237,240,17,78,255,148,190,7,161,28,68,59,175,62,222,136,80,94,159,217,215,10,83,131,248,154,172,153,97,82,162,20,118,127,5,93,27,205,209,230,11,95,161,100,135,254,254,242,222,6,34,129,105,93,1,30,225,225,156,24,184,157,176,179,75,42,188,52,18,20,128,83,205,239,110,233,86,172,7,23,246,204,212,46,211,53,93,79,199,109,84,216,185,154,171,2,213,83,77,80,197,165,83,154,182,33,98,134,198,9,36,135,210,217,209,14,49,174,94,247,124,5,253,73,254,22,49,2,57,44,183,251,147,114,194,29,94,232,15,129,240,17,198,213,251,143,131,223,89,155,44,102,14,75,110,164,165,223,171,90,129,12,243,23,187,228,173,72,161,197,93,10,227,118,121,124,28,116,142,90,46,160,25,164,88,254,253,0,93,96,117,221,228,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("b6997510-8ca5-4b43-92fb-c0f6cd54daae"));
		}

		#endregion

	}

	#endregion

}

