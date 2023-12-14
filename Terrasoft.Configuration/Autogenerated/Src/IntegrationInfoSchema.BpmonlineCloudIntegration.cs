namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IntegrationInfoSchema

	/// <exclude/>
	public class IntegrationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IntegrationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IntegrationInfoSchema(IntegrationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6fa37aed-45de-4068-b0cc-7201310174fb");
			Name = "IntegrationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e8c267b1-bae4-4c71-bb04-0c218f8cac09");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,221,74,196,48,16,133,175,91,232,59,12,187,247,173,120,233,234,130,84,144,222,232,194,250,2,217,116,218,6,218,164,204,36,138,44,190,187,211,214,117,127,20,113,53,23,45,61,57,39,231,35,83,171,58,228,94,105,132,39,36,82,236,42,159,230,206,86,166,14,164,188,113,54,137,183,73,156,196,32,107,78,88,139,2,121,171,152,175,160,176,30,235,201,84,216,202,237,92,89,150,193,53,135,174,83,244,186,220,75,119,202,43,168,200,117,240,120,27,124,115,153,94,128,217,31,112,16,205,142,179,125,216,180,70,131,30,58,191,86,70,35,92,20,237,208,86,228,122,36,111,80,248,86,99,114,218,63,129,154,132,123,244,12,142,128,135,183,111,16,172,92,70,250,105,207,14,253,31,24,236,201,216,26,30,196,8,91,168,209,47,134,244,2,222,206,169,209,173,65,235,193,148,242,52,149,65,250,85,103,62,166,138,242,223,189,140,154,208,159,209,185,30,3,127,235,85,240,172,218,128,50,235,210,104,25,156,28,250,210,160,208,144,32,25,150,52,10,24,97,117,51,59,25,238,44,91,130,24,56,104,141,204,63,227,110,156,107,97,61,57,191,227,156,163,45,167,63,100,252,158,212,99,113,212,134,245,14,128,160,80,88,18,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6fa37aed-45de-4068-b0cc-7201310174fb"));
		}

		#endregion

	}

	#endregion

}

