namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: HourCountTermSchema

	/// <exclude/>
	public class HourCountTermSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public HourCountTermSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public HourCountTermSchema(HourCountTermSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e2216cbe-4197-4a17-8a40-fbb367f7eb39");
			Name = "HourCountTerm";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,83,93,107,27,49,16,124,118,32,255,97,113,94,46,16,116,239,141,123,80,156,54,53,36,80,168,251,3,228,187,141,45,208,73,174,86,10,28,161,255,189,43,201,58,159,157,143,214,15,198,90,207,236,206,206,72,70,246,72,123,217,34,172,209,57,73,246,201,139,165,53,79,106,27,156,244,202,26,177,148,26,77,39,29,93,94,188,92,94,204,2,41,179,133,159,3,121,236,111,207,206,204,212,26,219,72,35,113,143,6,157,106,95,97,30,148,249,125,44,190,51,149,1,12,185,114,184,229,3,44,181,36,130,79,240,221,6,183,180,193,120,102,245,9,81,215,53,44,40,244,189,116,67,115,56,39,4,120,134,192,102,128,29,115,72,20,104,61,193,238,195,70,171,22,218,212,252,164,53,143,122,84,38,120,156,12,155,189,164,129,163,166,71,244,59,219,69,85,63,82,159,252,239,185,158,44,72,234,54,104,233,17,58,254,90,171,30,163,176,246,224,171,24,121,245,57,113,177,151,78,246,96,56,163,207,243,78,14,52,111,74,26,16,143,98,81,39,196,219,132,180,249,188,137,155,17,120,27,7,102,25,175,105,14,125,112,134,142,221,61,139,100,88,169,71,224,193,46,251,204,137,169,14,225,174,236,50,174,87,173,190,154,208,163,147,27,141,139,85,233,117,39,135,38,169,189,1,197,185,36,85,215,16,175,210,108,246,96,183,133,205,158,174,12,135,246,44,53,85,25,158,161,183,9,153,149,228,173,191,41,71,190,186,22,199,9,89,137,248,210,117,105,219,106,194,252,243,65,48,247,232,217,153,29,166,117,33,24,229,233,127,211,40,233,205,155,53,243,199,44,63,12,132,33,25,206,63,222,207,96,61,106,129,54,94,191,127,196,16,61,229,61,34,235,87,36,85,163,241,103,17,20,141,55,48,141,169,120,87,188,111,96,207,175,150,47,118,137,232,96,252,70,18,138,147,57,199,126,35,35,93,245,84,228,199,76,108,102,126,69,180,50,49,150,105,28,87,140,202,15,41,157,115,245,180,200,181,248,249,11,221,111,171,232,161,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e2216cbe-4197-4a17-8a40-fbb367f7eb39"));
		}

		#endregion

	}

	#endregion

}

