namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IActionLockerSchema

	/// <exclude/>
	public class IActionLockerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IActionLockerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IActionLockerSchema(IActionLockerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cb40de33-e3f6-43df-ac5e-ea49b9ed783e");
			Name = "IActionLocker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b5c46c08-cc76-4157-b24b-44267444e258");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,193,106,195,48,12,61,175,208,127,16,217,165,131,208,220,215,46,80,178,49,10,99,151,236,7,92,71,105,77,19,59,88,118,89,25,251,247,217,78,186,38,100,180,133,229,224,88,242,147,158,252,36,91,18,114,11,249,145,12,214,139,233,100,58,145,172,70,106,24,71,248,64,173,25,169,210,204,51,37,75,177,181,154,25,161,36,124,121,216,221,189,198,173,183,214,210,160,46,29,254,17,214,43,238,1,111,138,239,81,7,80,146,36,176,36,91,215,76,31,211,206,118,201,140,86,21,1,227,28,137,192,40,192,79,228,54,228,86,37,168,6,91,34,154,159,50,36,189,20,141,221,84,130,131,56,209,14,89,187,226,70,196,193,225,33,137,149,149,251,93,162,28,115,182,158,134,105,86,131,215,231,41,226,74,30,80,83,8,90,23,81,154,245,108,16,197,124,153,4,244,223,193,196,119,88,179,119,183,143,210,60,236,195,193,229,160,223,26,61,221,51,22,182,113,50,48,115,174,253,42,173,32,47,64,148,250,21,200,48,51,100,60,40,81,64,142,198,31,231,254,116,246,106,157,103,120,211,216,5,106,63,49,231,59,196,16,112,189,250,98,216,40,85,65,203,247,176,184,208,145,108,135,124,239,38,97,35,42,97,142,93,83,112,208,146,91,59,242,127,125,110,110,139,70,99,181,164,116,117,117,128,151,201,9,235,131,131,42,25,147,47,237,53,103,99,221,70,226,118,234,125,183,79,14,101,209,190,58,111,6,95,255,251,1,223,138,126,236,203,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cb40de33-e3f6-43df-ac5e-ea49b9ed783e"));
		}

		#endregion

	}

	#endregion

}

