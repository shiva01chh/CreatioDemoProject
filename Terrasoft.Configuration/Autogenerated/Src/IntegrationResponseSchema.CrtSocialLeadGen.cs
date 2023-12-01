namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationResponseSchema

	/// <exclude/>
	public class IntegrationResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationResponseSchema(IntegrationResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("34726720-1e07-4f00-be95-bf2446ea34bc");
			Name = "IntegrationResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f1114c1f-cbc3-4ea1-be84-e9eaafb87c31");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,93,145,65,79,195,48,12,133,207,155,212,255,96,141,11,92,218,251,6,92,58,105,66,26,48,109,187,33,14,89,235,150,72,77,50,57,46,104,76,252,119,220,180,29,25,189,164,126,121,126,246,215,90,101,208,31,85,129,176,71,34,229,93,197,105,238,108,165,235,150,20,107,103,211,157,43,180,106,214,168,202,21,218,100,122,78,166,147,214,107,91,195,238,228,25,77,186,109,45,107,131,233,14,73,124,250,59,116,45,146,169,248,110,8,107,41,32,111,148,247,115,120,178,140,117,159,186,214,158,183,50,216,89,143,193,154,101,25,220,251,214,24,69,167,199,161,206,27,215,150,64,131,13,150,251,87,248,210,252,1,218,86,142,76,200,1,87,73,121,137,77,199,164,44,138,122,91,42,86,194,196,164,10,126,23,225,216,30,26,93,64,209,109,21,47,53,46,4,115,184,130,22,157,55,228,62,117,137,244,183,244,228,28,22,191,64,138,227,136,196,26,133,116,19,38,244,247,255,201,130,176,66,246,224,8,124,119,70,0,208,200,135,73,47,109,49,70,207,241,140,230,128,116,251,34,191,13,30,96,22,181,118,183,179,187,142,111,4,140,208,226,247,206,8,103,168,145,23,221,252,5,252,12,32,104,203,158,37,212,189,122,45,6,77,158,95,51,219,234,13,54,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("34726720-1e07-4f00-be95-bf2446ea34bc"));
		}

		#endregion

	}

	#endregion

}

