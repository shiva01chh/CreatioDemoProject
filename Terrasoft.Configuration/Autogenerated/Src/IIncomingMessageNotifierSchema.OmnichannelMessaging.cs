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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,147,193,78,195,48,12,134,207,173,180,119,176,186,203,184,180,247,81,42,33,78,149,24,160,137,23,200,90,183,139,212,56,85,156,14,77,136,119,167,164,77,87,54,129,56,140,220,226,252,254,253,57,113,72,40,228,86,20,8,175,104,140,96,93,217,248,65,83,37,235,206,8,43,53,197,207,138,100,177,23,68,216,196,27,100,22,181,164,122,17,190,47,194,69,24,44,13,214,189,8,114,178,104,170,222,102,13,121,78,133,86,189,102,16,227,147,182,178,146,104,156,62,73,18,72,185,83,74,152,99,54,238,183,216,26,100,36,203,32,189,13,84,218,0,185,76,170,161,145,108,145,208,48,136,157,238,44,16,190,129,26,220,99,111,154,204,92,219,110,215,200,98,230,246,51,83,208,247,17,76,109,108,208,238,117,201,107,120,113,14,14,249,130,217,5,238,203,146,29,135,103,139,39,105,114,174,77,91,97,132,2,234,175,250,46,242,250,40,27,89,78,14,105,226,132,46,239,160,101,249,85,228,113,60,92,157,183,224,15,166,244,155,219,95,112,183,168,244,1,249,95,105,135,26,87,2,30,95,232,68,204,127,69,30,7,35,202,124,253,105,84,46,136,93,145,163,7,227,213,52,222,190,217,49,211,147,46,145,202,97,82,220,254,99,248,2,223,130,125,108,190,62,1,233,204,233,145,95,3,0,0 };
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

