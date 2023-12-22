namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactConstsSchema

	/// <exclude/>
	public class ContactConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactConstsSchema(ContactConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("42db62ea-f92c-4df6-b6a2-c994e9708c0b");
			Name = "ContactConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("43a72267-b2f6-464f-af52-bc7506959e73");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,221,106,195,32,24,134,143,19,200,61,72,142,182,3,27,173,157,179,116,27,164,169,41,61,24,12,214,27,112,201,215,18,200,31,106,14,194,232,189,79,83,86,186,131,173,76,68,69,158,151,239,225,29,76,213,30,209,251,104,44,52,171,40,140,194,86,53,96,122,85,0,218,131,214,202,116,7,59,203,186,246,80,29,7,173,108,213,181,81,248,25,133,65,63,124,212,85,129,140,117,127,5,42,106,101,12,114,152,85,133,117,151,177,198,49,158,11,146,36,65,79,102,104,26,165,199,151,239,143,253,216,3,194,72,54,125,221,141,0,23,46,185,6,127,142,216,14,85,121,9,248,252,174,244,208,52,35,56,130,69,231,87,160,193,14,186,157,240,217,155,210,6,238,98,78,30,25,147,121,134,115,198,215,152,46,40,193,169,16,12,83,190,17,44,75,215,100,41,72,124,191,154,242,39,127,158,124,17,191,168,111,161,45,65,59,249,87,85,195,236,79,243,194,23,225,252,181,175,216,227,187,18,61,163,88,202,52,91,204,165,196,252,97,205,241,38,167,20,11,70,83,76,8,221,112,34,151,76,100,60,158,108,110,75,228,208,252,79,227,28,56,139,228,217,124,33,88,46,110,138,184,62,220,190,94,95,165,173,148,220,55,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("42db62ea-f92c-4df6-b6a2-c994e9708c0b"));
		}

		#endregion

	}

	#endregion

}

