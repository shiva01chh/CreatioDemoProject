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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,83,193,106,195,48,12,61,175,208,127,16,217,165,131,82,223,215,46,80,178,49,10,99,151,236,7,92,71,105,77,19,59,88,118,89,25,251,247,217,78,186,54,100,180,133,229,224,88,242,147,158,252,36,59,146,106,3,249,129,44,214,243,241,104,60,82,188,70,106,184,64,248,64,99,56,233,210,206,50,173,74,185,113,134,91,169,21,124,5,216,221,189,193,77,176,86,202,162,41,61,254,17,86,75,17,0,111,90,236,208,68,16,99,12,22,228,234,154,155,67,218,217,62,153,53,186,34,224,66,32,17,88,13,248,137,194,197,220,186,4,221,96,75,68,179,99,6,118,150,162,113,235,74,10,144,71,218,62,107,87,220,128,56,58,2,132,57,85,249,223,37,202,33,103,235,105,184,225,53,4,125,158,18,161,213,30,13,197,160,85,145,164,217,153,13,178,152,45,88,68,255,29,76,98,139,53,127,247,251,36,205,227,62,30,92,14,250,173,49,208,61,99,225,26,47,3,183,167,218,175,210,74,10,2,36,105,88,129,44,183,125,198,189,150,5,228,104,195,113,30,78,39,175,206,123,250,55,157,250,64,19,38,230,116,135,41,68,220,89,125,83,88,107,93,65,203,247,48,191,208,145,108,139,98,231,39,97,45,43,105,15,93,83,176,215,146,91,59,242,127,125,110,110,139,65,235,140,162,116,121,117,128,23,236,136,13,193,81,149,140,171,151,246,154,147,161,110,3,113,59,245,190,219,39,135,170,104,95,93,48,163,207,127,63,167,52,22,13,194,3,0,0 };
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

