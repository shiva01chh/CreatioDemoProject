namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IIncomingMessageNotifierSchema

	/// <exclude/>
	public class IIncomingMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IIncomingMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IIncomingMessageNotifierSchema(IIncomingMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ce1c4ef7-b936-4dd7-987d-b5980c9beea9");
			Name = "IIncomingMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("92ff52b6-dfba-4556-90d8-6f4c37f69c5d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,193,78,195,48,12,134,207,157,180,119,176,186,203,184,52,247,49,42,33,78,147,24,160,137,23,200,90,183,139,212,56,85,156,14,77,136,119,39,164,77,55,54,129,56,140,220,226,252,254,253,57,113,72,106,228,86,22,8,175,104,173,100,83,185,236,193,80,165,234,206,74,167,12,101,207,154,84,177,147,68,216,100,107,100,150,181,162,122,58,121,159,78,166,147,100,102,177,246,34,88,145,67,91,121,155,5,172,86,84,24,237,53,189,24,159,140,83,149,66,27,244,66,8,88,114,167,181,180,135,124,216,111,176,181,200,72,142,65,69,27,168,140,5,10,153,84,67,163,216,33,161,101,144,91,211,57,32,124,3,221,187,103,209,84,156,184,182,221,182,81,197,137,219,207,76,137,239,35,25,219,88,163,219,153,146,23,240,18,28,2,242,5,115,8,220,151,37,7,142,200,150,141,82,113,174,93,182,210,74,13,228,175,250,46,141,250,52,31,88,142,14,75,17,132,33,111,111,84,249,85,228,113,56,156,159,183,16,15,198,244,155,219,95,112,55,168,205,30,249,95,105,251,26,87,2,30,94,232,72,204,127,69,30,6,35,205,99,253,113,84,46,136,67,145,67,4,227,249,56,222,177,217,33,51,146,206,144,202,126,82,194,254,163,255,2,223,130,62,230,215,39,99,202,10,59,86,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ce1c4ef7-b936-4dd7-987d-b5980c9beea9"));
		}

		#endregion

	}

	#endregion

}

