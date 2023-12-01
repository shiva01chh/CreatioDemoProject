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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,10,126,135,161,94,90,144,228,94,219,130,86,42,61,40,194,179,239,242,240,176,221,76,234,64,178,27,103,119,133,34,239,187,59,217,52,218,196,40,152,75,118,135,255,252,103,230,151,137,81,37,186,74,105,132,71,100,86,206,230,62,89,90,147,211,46,176,242,100,77,178,162,2,215,101,101,217,159,157,190,157,157,158,4,71,102,7,127,246,206,99,121,249,113,63,206,102,252,46,158,172,148,246,150,9,157,40,68,115,206,184,147,26,176,44,148,115,83,184,179,6,247,75,91,132,210,60,176,213,232,156,229,168,75,211,20,102,100,158,145,201,103,86,131,102,204,231,163,85,97,149,239,201,71,233,162,213,187,80,150,138,247,237,253,202,0,25,231,149,145,89,109,14,254,153,28,232,186,46,200,129,5,130,53,142,182,5,66,110,25,170,198,175,158,32,54,5,58,150,129,87,85,4,116,73,91,34,61,170,241,239,6,115,21,10,127,77,38,147,188,177,223,87,104,243,241,186,215,224,228,2,238,133,57,204,193,200,75,4,67,67,79,38,79,226,88,133,109,65,250,208,228,144,12,166,48,196,64,82,223,34,182,79,190,50,155,231,80,179,23,204,15,209,183,81,252,150,236,23,180,49,176,100,84,30,93,23,176,204,47,74,196,131,231,208,0,226,153,124,152,166,125,215,89,165,88,149,145,211,124,20,28,178,140,97,80,215,91,57,90,108,228,46,95,165,13,36,179,52,170,99,242,1,220,80,197,241,166,227,3,93,219,137,16,221,42,135,227,126,184,94,252,147,255,7,168,104,178,134,107,23,178,212,168,144,189,44,247,180,62,123,201,197,236,39,202,215,82,233,23,144,111,148,87,205,2,54,108,131,161,23,57,83,134,198,83,78,200,223,160,172,218,94,192,190,202,223,40,122,184,13,148,69,191,191,181,221,163,184,109,214,25,204,23,221,88,18,1,246,101,151,131,20,26,54,221,160,196,228,121,7,159,139,212,138,98,4,0,0 };
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

