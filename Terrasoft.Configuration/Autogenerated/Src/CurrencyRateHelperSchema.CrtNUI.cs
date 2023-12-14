namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CurrencyRateHelperSchema

	/// <exclude/>
	public class CurrencyRateHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CurrencyRateHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CurrencyRateHelperSchema(CurrencyRateHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10302f70-95a4-407b-9a13-247da73bf707");
			Name = "CurrencyRateHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d9c4378b-4458-41ff-9d84-e4b071fcce18");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,82,77,111,219,48,12,61,39,64,254,3,225,147,141,121,114,119,110,146,75,134,118,3,214,161,72,130,221,25,151,78,12,200,146,161,143,21,217,144,255,62,81,142,92,119,88,119,106,0,35,16,249,248,30,201,71,111,91,117,132,221,217,58,234,110,23,115,63,121,138,123,169,15,40,219,95,232,90,173,66,114,49,87,216,145,237,177,38,216,147,49,104,117,227,196,70,171,166,61,122,19,81,139,249,239,197,124,214,251,131,108,107,168,37,90,11,27,111,12,169,250,188,69,71,95,72,246,100,2,130,81,179,170,170,96,105,125,215,161,57,175,83,224,158,156,5,119,34,168,189,131,14,149,107,173,69,208,77,120,15,60,16,148,72,140,245,213,223,4,203,30,13,118,192,173,174,50,198,102,107,150,22,203,42,38,94,112,134,156,55,202,174,55,19,161,101,149,162,12,187,206,97,93,152,141,255,12,47,39,52,200,124,15,215,138,252,137,234,182,67,25,219,42,32,14,54,75,177,198,96,205,107,129,85,76,195,71,200,189,212,234,88,240,235,54,66,127,162,129,176,192,128,80,244,12,223,125,119,32,115,167,77,135,238,171,106,244,149,111,54,196,63,15,180,59,226,73,156,54,161,40,43,179,136,184,12,108,67,247,163,174,216,235,93,236,58,15,18,133,216,82,47,131,121,121,118,83,102,37,100,89,17,139,46,236,236,27,110,236,216,141,209,5,167,223,109,249,83,92,226,207,214,105,169,111,155,181,253,159,67,105,237,161,235,196,180,215,172,255,202,164,50,57,153,116,147,107,109,3,57,187,35,246,230,252,136,198,82,158,16,37,232,112,36,156,27,139,126,160,244,84,164,210,127,57,254,10,9,21,164,38,138,7,116,39,241,168,159,243,79,55,229,136,18,223,72,29,221,105,176,36,24,201,231,178,130,8,189,147,90,155,60,222,215,36,251,97,53,138,13,209,203,244,2,198,3,227,104,248,162,201,252,251,3,19,231,70,102,241,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10302f70-95a4-407b-9a13-247da73bf707"));
		}

		#endregion

	}

	#endregion

}

