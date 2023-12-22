namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ClearResponseOverdueDateRuleHandlerSchema

	/// <exclude/>
	public class ClearResponseOverdueDateRuleHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ClearResponseOverdueDateRuleHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ClearResponseOverdueDateRuleHandlerSchema(ClearResponseOverdueDateRuleHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1d4ab598-48ce-4320-8df6-59d7c39071fd");
			Name = "ClearResponseOverdueDateRuleHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b11d550e-0087-4f53-ae17-fb00d41102cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,203,110,194,48,16,60,7,137,127,112,225,18,164,42,244,76,75,15,13,125,29,170,34,30,189,187,201,146,90,114,236,104,109,35,161,138,127,175,31,65,132,64,84,114,137,118,60,179,179,179,182,160,37,168,138,102,64,86,128,72,149,220,232,36,149,98,195,10,131,84,51,41,250,189,223,126,47,50,138,137,130,44,119,74,67,121,223,170,147,25,213,244,12,76,37,231,144,185,14,42,121,5,1,200,178,35,167,233,85,150,82,92,62,65,232,194,147,217,83,231,209,179,208,76,51,80,157,132,23,154,105,137,157,140,70,246,36,165,28,68,78,209,81,45,121,136,80,88,152,164,156,42,53,177,63,160,184,176,235,179,25,225,115,11,152,27,176,187,128,133,225,240,70,69,206,1,189,172,50,223,156,101,36,115,170,107,68,100,60,158,144,247,148,170,211,78,145,187,136,227,12,86,175,209,184,40,118,148,185,183,240,110,7,187,43,140,226,181,2,180,141,68,184,40,98,78,202,17,241,134,81,139,52,109,209,220,22,163,125,176,30,218,109,133,249,234,186,30,118,142,178,2,116,183,114,113,212,150,67,171,12,83,20,160,189,83,84,33,219,218,24,68,213,192,63,214,31,160,127,100,126,217,119,43,89,78,194,46,98,255,108,118,4,252,239,16,157,109,72,28,16,251,134,245,106,87,65,110,223,181,41,197,23,229,6,30,152,208,143,241,160,181,227,193,136,220,76,201,221,161,69,84,235,151,160,27,210,115,213,173,149,132,128,251,142,84,53,118,26,212,99,205,239,15,117,164,224,164,209,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1d4ab598-48ce-4320-8df6-59d7c39071fd"));
		}

		#endregion

	}

	#endregion

}

