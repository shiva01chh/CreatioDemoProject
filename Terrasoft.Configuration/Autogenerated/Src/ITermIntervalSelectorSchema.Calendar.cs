namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITermIntervalSelectorSchema

	/// <exclude/>
	public class ITermIntervalSelectorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITermIntervalSelectorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITermIntervalSelectorSchema(ITermIntervalSelectorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0ad912a0-8f79-46f0-9654-054938f2e9ef");
			Name = "ITermIntervalSelector";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f69a32ba-7e77-47bd-be6b-d095bbdc629a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,81,219,78,195,48,12,125,166,82,255,193,218,19,72,168,249,0,74,37,4,210,212,7,158,182,31,200,138,219,5,229,82,57,14,210,132,248,119,156,208,110,3,162,60,56,246,57,39,199,182,215,14,227,172,7,132,61,18,233,24,70,110,158,131,31,205,148,72,179,9,190,174,62,235,234,38,69,227,39,216,157,34,163,147,186,181,56,228,98,108,182,232,145,204,240,32,24,165,20,180,49,57,167,233,212,45,239,222,51,210,152,229,195,8,18,58,48,57,243,161,45,68,204,34,129,154,149,170,174,184,115,58,88,51,252,128,11,189,23,123,174,95,184,187,133,218,238,51,54,251,251,247,121,73,188,34,31,195,27,240,81,51,16,114,34,31,129,141,195,139,137,49,16,12,218,14,201,150,102,155,179,148,250,171,213,206,154,180,3,47,243,122,220,104,154,146,67,207,113,211,61,173,97,209,138,44,83,195,201,96,108,90,85,24,23,129,197,65,183,191,118,32,176,53,159,129,191,218,148,246,96,139,124,251,98,202,176,197,77,43,250,178,136,123,8,135,119,153,64,7,103,35,119,121,3,95,117,37,183,174,242,249,6,163,131,1,57,217,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0ad912a0-8f79-46f0-9654-054938f2e9ef"));
		}

		#endregion

	}

	#endregion

}

