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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,65,75,195,64,16,133,207,13,228,63,12,237,61,17,143,86,11,18,65,114,209,66,253,3,219,205,108,178,144,236,134,153,141,34,197,255,238,36,177,54,173,34,86,247,144,144,183,239,237,251,216,137,83,13,114,171,52,194,19,18,41,246,38,36,153,119,198,150,29,169,96,189,139,163,93,28,197,17,200,90,16,150,162,64,86,43,230,43,200,93,192,114,52,229,206,248,189,43,77,83,184,230,174,105,20,189,174,14,210,157,10,10,12,249,6,30,111,187,80,93,38,23,96,15,7,76,162,233,113,182,237,182,181,213,160,251,206,175,149,179,1,110,54,219,163,173,201,183,72,193,162,240,173,135,228,184,127,2,53,10,247,24,24,60,1,247,239,80,33,56,185,140,228,211,158,78,253,31,24,28,200,186,18,30,196,8,59,40,49,44,251,244,18,222,206,169,209,181,69,23,192,22,242,180,198,34,253,170,51,27,82,121,241,239,94,70,77,24,206,232,220,12,129,191,245,42,120,86,117,135,50,235,194,106,25,156,28,250,82,161,208,144,32,89,150,52,10,24,161,185,153,159,12,119,158,174,64,12,220,105,141,204,63,227,110,189,175,97,51,58,191,227,92,160,43,198,63,100,248,30,213,99,113,208,166,235,29,71,25,212,211,26,3,0,0 };
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

