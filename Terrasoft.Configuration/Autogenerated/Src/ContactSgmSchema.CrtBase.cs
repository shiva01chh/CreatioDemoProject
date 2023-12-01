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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,223,107,194,48,16,199,159,43,248,63,28,245,69,65,218,119,221,143,7,217,100,48,157,160,239,146,181,103,9,180,105,185,164,5,25,254,239,139,105,106,83,87,199,24,91,31,74,239,114,119,249,126,63,77,4,203,80,22,44,66,216,33,17,147,249,65,5,139,92,28,120,82,18,83,60,23,195,193,199,112,48,28,120,35,194,68,135,176,72,153,148,51,208,53,138,69,106,155,100,102,53,12,67,184,147,101,150,49,58,62,128,77,152,210,41,20,148,87,60,70,9,81,221,3,254,182,36,161,247,245,167,224,47,121,133,2,154,104,197,227,56,197,58,132,3,199,52,150,65,51,61,108,198,235,68,81,190,167,60,130,232,188,65,71,138,167,197,122,173,214,92,72,69,101,164,114,210,146,55,166,201,200,109,6,180,173,227,9,152,86,111,47,107,113,112,15,251,228,44,110,109,131,204,104,179,145,30,203,69,18,60,101,133,58,206,207,125,167,122,238,8,69,92,111,110,99,171,100,67,121,129,164,56,94,233,232,112,107,18,254,43,147,202,133,16,92,74,93,8,94,65,188,98,10,173,24,104,148,207,29,131,118,201,2,183,22,19,84,246,203,35,84,122,169,219,122,246,162,223,178,173,114,152,88,227,47,114,93,166,233,27,25,0,227,138,165,37,78,224,177,131,5,102,96,242,193,142,184,198,235,140,62,125,231,253,153,211,175,204,95,254,85,143,253,229,229,63,222,4,208,109,239,65,224,158,133,127,135,240,245,30,252,144,66,123,72,123,48,172,218,19,124,147,195,213,128,30,16,125,247,224,47,72,184,87,199,230,220,148,201,232,231,19,149,132,83,14,177,4,0,0 };
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

