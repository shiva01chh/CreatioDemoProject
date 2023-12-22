namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysCultureInfoSchema

	/// <exclude/>
	public class ISysCultureInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysCultureInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysCultureInfoSchema(ISysCultureInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8");
			Name = "ISysCultureInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,77,107,195,48,12,61,39,144,255,32,232,61,185,183,99,151,28,70,46,163,176,178,187,23,43,153,32,145,131,108,195,74,217,127,159,99,175,197,99,148,18,159,236,167,247,97,73,172,102,180,139,234,17,78,40,162,172,25,92,221,26,30,104,244,162,28,25,174,79,162,216,78,241,94,149,151,170,44,188,37,30,225,237,108,29,206,135,170,12,200,78,112,12,101,232,216,161,12,193,108,15,93,168,183,126,114,94,176,227,193,68,218,226,63,38,234,129,174,172,255,164,226,18,137,55,195,163,152,5,197,17,218,61,28,163,58,213,155,166,129,39,235,231,89,201,249,249,10,164,31,65,159,12,129,52,178,163,129,80,234,155,164,201,53,47,158,52,116,26,214,158,138,98,68,119,88,47,223,27,18,88,227,215,29,243,208,100,24,71,168,111,176,207,38,13,189,153,252,204,192,97,61,119,18,172,147,117,15,153,168,141,154,215,32,217,16,250,142,18,134,212,111,76,205,85,143,98,127,37,157,109,63,21,143,168,31,241,119,200,58,237,63,190,19,250,23,140,88,126,126,0,230,37,157,152,199,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ea1fdfd0-6ef8-44d6-b478-24f2418a19b8"));
		}

		#endregion

	}

	#endregion

}

