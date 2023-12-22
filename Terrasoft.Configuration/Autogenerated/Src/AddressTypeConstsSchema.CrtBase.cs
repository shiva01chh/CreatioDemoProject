namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AddressTypeConstsSchema

	/// <exclude/>
	public class AddressTypeConstsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AddressTypeConstsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AddressTypeConstsSchema(AddressTypeConstsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e7b21208-c42d-4094-802d-89e094c04cb6");
			Name = "AddressTypeConsts";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("45b7d114-643d-4217-a8b2-b9950d3eddb7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,79,75,195,48,24,135,207,45,244,59,132,157,244,16,151,172,105,146,34,30,212,131,10,130,135,13,60,231,207,155,173,216,181,165,105,145,33,251,238,166,149,129,150,97,15,203,45,239,239,73,30,126,36,189,47,170,45,90,31,124,7,251,219,36,78,226,74,237,193,55,202,0,218,64,219,42,95,187,238,230,177,174,92,177,237,91,213,21,117,149,196,95,73,28,53,189,46,11,131,124,23,102,6,153,82,121,143,238,173,109,193,251,205,161,129,112,194,119,62,112,3,27,45,151,167,12,117,33,68,24,189,215,237,199,144,252,189,166,5,101,235,170,60,160,167,190,176,35,243,98,209,29,170,224,115,156,92,45,132,36,218,113,105,48,211,28,176,117,148,98,157,75,137,9,161,150,19,200,83,105,248,226,122,236,113,206,186,171,247,48,103,125,14,204,196,202,156,212,43,203,5,22,212,18,204,50,167,177,204,5,96,99,153,74,137,84,185,48,228,31,235,43,108,85,57,167,29,161,105,91,113,81,219,245,174,104,154,240,186,115,234,19,55,181,243,139,236,15,125,248,89,97,63,103,63,113,19,187,211,66,165,142,43,236,82,174,49,101,148,96,238,36,197,212,112,199,51,200,72,202,210,209,30,69,231,253,111,221,14,218,57,249,8,77,204,6,104,38,134,182,142,173,50,204,228,208,91,17,192,144,74,202,65,130,1,155,253,152,143,73,124,28,234,255,94,223,128,192,105,213,80,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e7b21208-c42d-4094-802d-89e094c04cb6"));
		}

		#endregion

	}

	#endregion

}

