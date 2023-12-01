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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,79,75,195,48,24,135,207,45,244,59,132,157,244,16,151,172,105,146,34,30,212,131,10,130,135,13,60,231,207,155,173,216,181,165,105,145,33,251,238,166,149,29,44,99,61,44,183,188,191,39,121,248,145,244,190,168,182,104,125,240,29,236,239,147,56,137,43,181,7,223,40,3,104,3,109,171,124,237,186,187,231,186,114,197,182,111,85,87,212,85,18,255,36,113,212,244,186,44,12,242,93,152,25,100,74,229,61,122,180,182,5,239,55,135,6,194,9,223,249,192,13,108,180,92,158,50,212,133,16,97,244,89,183,95,67,242,255,154,22,148,173,171,242,128,94,250,194,142,204,155,69,15,168,130,239,113,114,179,16,146,104,199,165,193,76,115,192,214,81,138,117,46,37,38,132,90,78,32,79,165,225,139,219,177,199,57,235,174,222,195,156,245,53,48,19,43,115,82,175,44,23,88,80,75,48,203,156,198,50,23,128,141,101,42,37,82,229,194,144,11,214,119,216,170,114,78,59,66,211,182,226,170,182,235,93,209,52,225,117,231,212,39,110,106,231,87,217,159,250,240,179,194,126,206,126,226,38,118,167,133,74,29,87,216,165,92,99,202,40,193,220,73,138,169,225,142,103,144,145,148,165,163,61,138,206,251,63,186,29,180,115,242,17,154,152,13,208,76,12,109,29,91,101,152,201,161,183,34,128,33,149,148,131,4,3,54,251,51,31,147,248,56,212,15,235,23,177,120,55,149,71,3,0,0 };
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

