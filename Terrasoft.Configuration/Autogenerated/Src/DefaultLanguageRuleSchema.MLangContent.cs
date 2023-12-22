namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultLanguageRuleSchema

	/// <exclude/>
	public class DefaultLanguageRuleSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultLanguageRuleSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultLanguageRuleSchema(DefaultLanguageRuleSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("32971764-08e0-45a0-b450-0b4e7438a79c");
			Name = "DefaultLanguageRule";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5c69ef14-1695-42a6-839b-8d7e06516faf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,77,111,219,48,12,134,207,46,208,255,64,184,151,4,8,236,123,190,14,203,128,34,192,138,13,237,186,187,98,209,137,0,91,50,40,42,88,80,236,191,143,82,156,52,241,210,97,11,114,33,69,189,47,249,136,182,170,69,223,169,10,225,59,18,41,239,106,46,86,206,214,102,27,72,177,113,246,254,238,237,254,46,11,222,216,45,188,28,60,99,59,59,199,151,87,8,103,131,186,23,100,150,200,195,98,80,120,109,80,72,245,169,84,36,68,164,44,75,152,251,208,182,138,14,203,62,94,53,202,251,9,240,78,49,116,228,246,70,163,135,70,217,109,80,91,4,31,186,206,17,67,171,76,179,113,63,251,58,143,12,198,130,79,221,196,40,122,20,39,131,242,194,161,11,155,198,84,80,69,19,248,140,181,10,13,127,233,197,159,67,131,48,133,79,202,227,101,74,110,69,48,217,3,225,86,166,0,153,201,179,178,236,167,240,141,204,94,49,166,89,178,238,24,64,21,207,193,51,69,64,189,197,19,122,47,114,39,217,149,211,40,176,242,219,167,249,17,78,246,128,86,31,61,99,252,71,11,20,42,118,20,187,72,51,29,43,134,68,143,72,9,165,49,47,136,98,227,178,1,174,150,34,148,86,9,235,69,126,3,67,94,46,139,179,92,57,212,155,119,138,84,11,86,54,106,145,7,143,36,253,88,172,226,27,231,203,87,137,35,131,62,81,204,203,84,157,46,247,244,111,24,142,94,175,100,224,90,117,28,47,103,211,141,188,204,104,112,2,111,191,110,209,122,103,245,132,188,115,250,95,48,125,221,176,18,68,239,203,38,171,103,217,212,70,6,170,201,181,255,187,124,31,209,51,118,135,100,88,187,10,202,75,44,110,47,31,143,120,194,99,48,26,30,241,12,104,173,71,41,21,187,225,195,51,86,142,244,90,203,232,9,75,58,210,215,72,251,141,90,107,217,178,235,111,180,16,221,31,170,9,67,226,147,191,172,234,36,249,100,189,71,234,101,60,158,165,36,33,7,178,31,218,167,162,219,15,36,89,249,95,254,126,3,29,199,68,151,162,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("32971764-08e0-45a0-b450-0b4e7438a79c"));
		}

		#endregion

	}

	#endregion

}

