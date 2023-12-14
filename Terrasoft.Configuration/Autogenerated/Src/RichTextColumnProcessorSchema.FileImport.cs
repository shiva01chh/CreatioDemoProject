namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RichTextColumnProcessorSchema

	/// <exclude/>
	public class RichTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RichTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RichTextColumnProcessorSchema(RichTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0707d032-3302-49c0-85c6-57a87aecda8d");
			Name = "RichTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,209,107,219,48,16,198,159,83,232,255,112,100,47,9,20,251,61,77,2,107,74,75,96,140,178,37,123,25,123,80,228,115,114,96,75,222,73,42,11,101,255,251,78,114,220,213,89,60,168,95,44,29,159,190,79,247,147,100,84,141,174,81,26,97,131,204,202,217,210,103,43,107,74,218,7,86,158,172,201,30,168,194,117,221,88,246,215,87,47,215,87,163,224,200,236,225,235,209,121,172,111,95,231,111,87,51,14,213,179,7,165,189,101,66,39,10,209,124,96,220,75,6,172,42,229,220,12,190,144,62,108,240,151,95,217,42,212,230,137,173,70,231,44,39,105,158,231,48,39,115,64,38,95,88,13,154,177,92,140,47,168,199,249,178,147,187,80,215,138,143,221,252,163,1,50,206,43,35,221,218,18,252,129,28,232,152,12,50,96,193,96,141,163,93,133,80,90,134,166,245,139,61,124,178,102,31,131,64,167,36,120,86,85,64,151,117,41,249,155,152,239,247,88,170,80,249,59,50,133,44,157,248,99,131,182,156,172,207,246,56,189,129,207,2,30,22,96,228,39,130,129,206,167,211,31,98,218,132,93,69,250,180,213,1,37,204,224,34,185,209,75,162,247,151,180,244,232,57,196,83,16,224,79,201,185,85,188,19,240,63,132,83,97,197,168,60,186,62,103,97,32,74,196,147,229,64,7,98,155,189,250,230,231,198,243,70,177,170,19,174,197,56,56,100,105,196,160,142,55,116,188,220,202,92,14,167,43,100,243,60,169,211,226,19,188,129,208,201,182,103,5,125,231,169,80,221,41,135,147,243,114,124,7,163,223,39,178,104,138,22,110,159,180,100,52,200,94,238,250,44,142,189,172,197,226,127,168,239,36,233,29,168,239,149,87,237,85,108,9,7,67,63,101,76,5,26,79,37,33,15,208,108,186,189,128,125,150,199,41,122,120,12,84,36,191,111,209,110,35,110,219,117,1,139,101,191,150,117,12,207,149,183,23,65,180,120,250,197,84,139,223,31,240,180,59,3,119,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0707d032-3302-49c0-85c6-57a87aecda8d"));
		}

		#endregion

	}

	#endregion

}

