namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ContactSgmSchema

	/// <exclude/>
	public class ContactSgmSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ContactSgmSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ContactSgmSchema(ContactSgmSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f27597f1-ef26-4cc5-8f2a-1e8aeb9e1ffc");
			Name = "ContactSgm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0bd8020-de17-4815-83cd-c2dac7bbc324");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,223,107,194,48,16,199,159,43,248,63,28,245,69,65,218,119,221,143,7,217,100,48,157,160,239,146,181,103,9,180,105,185,164,130,12,255,247,165,105,106,83,87,199,24,91,31,74,239,114,119,249,126,63,77,4,203,80,22,44,66,216,33,17,147,249,65,5,139,92,28,120,82,18,83,60,23,195,193,199,112,48,28,120,35,194,68,135,176,72,153,148,51,208,53,138,69,106,155,100,102,53,12,67,184,147,101,150,49,58,61,128,77,152,210,41,20,148,31,121,140,18,162,186,7,252,109,73,66,239,235,79,193,95,242,35,10,104,162,21,143,227,20,235,16,14,28,211,88,6,205,244,176,25,175,19,69,249,158,242,8,162,106,131,142,20,79,139,245,90,173,185,144,138,202,72,229,164,37,111,76,147,145,219,12,104,91,199,19,48,173,222,94,214,226,224,30,246,73,37,110,109,131,204,104,179,145,30,203,69,18,60,101,133,58,205,171,190,115,61,119,132,34,174,55,183,177,85,178,161,188,64,82,28,175,116,116,184,53,9,255,149,73,229,66,8,46,165,46,4,175,32,126,100,10,173,24,104,148,207,29,131,118,201,2,183,22,19,84,246,203,35,84,122,169,219,90,121,209,111,217,86,57,76,172,241,23,185,46,211,244,141,12,128,241,145,165,37,78,224,177,131,5,102,96,242,193,142,184,198,235,140,62,127,231,253,153,211,175,204,95,254,85,143,253,229,229,63,222,4,208,109,239,65,224,158,133,127,135,240,245,30,252,144,66,123,72,123,48,172,218,19,124,147,195,213,128,30,16,125,247,224,47,72,184,87,199,230,220,148,201,84,207,39,220,50,188,178,178,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f27597f1-ef26-4cc5-8f2a-1e8aeb9e1ffc"));
		}

		#endregion

	}

	#endregion

}

