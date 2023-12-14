namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MoneyColumnProcessorSchema

	/// <exclude/>
	public class MoneyColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MoneyColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MoneyColumnProcessorSchema(MoneyColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1ada78ef-dac1-4b3e-9c3b-95c44f2ee05b");
			Name = "MoneyColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("1a247561-b87d-48fb-9e13-b6a8baa960d3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,10,126,135,161,94,90,144,228,94,219,130,86,42,61,40,194,179,239,242,240,48,221,76,234,66,178,27,103,119,133,34,239,187,59,217,52,218,196,40,152,75,118,135,255,252,103,230,151,137,193,146,92,133,138,224,145,152,209,217,220,39,75,107,114,189,11,140,94,91,147,172,116,65,235,178,178,236,207,78,223,206,78,79,130,211,102,7,127,246,206,83,121,249,113,63,206,102,250,46,158,172,80,121,203,154,156,40,68,115,206,180,147,26,176,44,208,185,41,220,89,67,251,165,45,66,105,30,216,42,114,206,114,212,165,105,10,51,109,158,137,181,207,172,2,197,148,207,71,171,194,162,239,201,71,233,162,213,187,80,150,200,251,246,126,101,64,27,231,209,200,172,54,7,255,172,29,168,186,46,200,129,5,130,53,78,111,11,130,220,50,84,141,95,61,65,108,10,84,44,3,175,88,4,114,73,91,34,61,170,241,239,134,114,12,133,191,214,38,147,188,177,223,87,100,243,241,186,215,224,228,2,238,133,57,204,193,200,75,4,67,67,79,38,79,226,88,133,109,161,213,161,201,33,25,76,97,136,129,164,190,69,108,159,124,101,54,207,161,102,47,152,31,162,111,163,248,45,217,47,104,99,96,201,132,158,92,23,176,204,47,74,162,131,231,208,0,226,153,124,152,166,125,215,89,133,140,101,228,52,31,5,71,44,99,24,82,245,86,142,22,27,185,203,87,105,3,201,44,141,234,152,124,0,55,84,113,188,233,248,64,215,118,34,68,183,232,104,220,15,215,139,127,242,255,0,149,76,214,112,237,66,150,26,21,177,151,229,158,214,103,47,185,148,253,68,249,90,42,253,2,242,13,122,108,22,176,97,27,140,126,145,179,206,200,120,157,107,226,111,80,86,109,47,96,95,229,111,20,61,220,6,157,69,191,191,181,221,163,184,109,214,25,204,23,221,88,18,1,246,101,151,131,20,26,54,221,160,196,234,231,29,205,92,237,82,99,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1ada78ef-dac1-4b3e-9c3b-95c44f2ee05b"));
		}

		#endregion

	}

	#endregion

}

