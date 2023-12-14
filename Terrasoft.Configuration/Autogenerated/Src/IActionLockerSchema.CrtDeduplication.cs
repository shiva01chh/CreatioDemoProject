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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,77,107,195,48,12,61,175,208,255,32,178,75,7,165,190,175,93,160,100,99,20,198,46,217,31,112,29,165,53,77,236,224,143,178,50,246,223,103,57,233,218,144,209,22,150,131,99,201,79,122,242,147,236,173,84,27,200,15,214,97,61,31,143,198,35,197,107,180,13,23,8,31,104,12,183,186,116,179,76,171,82,110,188,225,78,106,5,95,4,187,187,55,184,33,107,165,28,154,50,224,31,97,181,20,4,120,211,98,135,38,130,24,99,176,176,190,174,185,57,164,157,29,146,57,163,43,11,92,8,180,22,156,6,252,68,225,99,110,93,130,110,176,37,178,179,99,6,118,150,162,241,235,74,10,144,71,218,62,107,87,220,128,56,58,8,194,188,170,194,239,18,229,144,179,245,52,220,240,26,72,159,167,68,104,181,71,99,99,208,170,72,210,236,204,6,89,204,22,44,162,255,14,182,98,139,53,127,15,251,36,205,227,62,30,92,14,250,173,145,232,158,177,240,77,144,129,187,83,237,87,105,165,37,1,146,148,86,176,142,187,62,227,94,203,2,114,116,116,156,211,233,228,213,7,79,255,166,211,16,104,104,98,78,119,152,66,196,157,213,55,133,181,214,21,180,124,15,243,11,29,201,182,40,118,97,18,214,178,146,238,208,53,5,123,45,185,181,35,255,215,231,230,182,24,116,222,40,155,46,175,14,240,130,29,177,20,28,85,201,184,122,105,175,57,25,234,54,16,183,83,239,187,125,114,168,138,246,213,145,25,125,244,253,0,236,38,104,122,195,3,0,0 };
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

