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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,197,190,167,73,160,77,105,9,44,75,217,38,189,44,123,80,228,113,50,96,75,222,145,84,54,148,254,247,142,229,184,27,103,227,66,125,177,52,60,189,167,249,36,25,85,162,171,148,70,88,33,179,114,54,247,201,194,154,156,182,129,149,39,107,146,123,42,112,89,86,150,253,229,197,235,229,197,32,56,50,91,120,218,59,143,229,245,199,252,120,53,99,95,61,185,87,218,91,38,116,162,16,205,55,198,173,100,192,162,80,206,77,224,39,233,221,10,255,250,133,45,66,105,30,217,106,116,206,114,148,166,105,10,83,50,59,100,242,153,213,160,25,243,217,240,140,122,152,206,91,185,11,101,169,120,223,206,111,12,144,113,94,25,233,214,230,224,119,228,64,215,201,32,3,22,12,214,56,218,20,8,185,101,168,26,191,186,135,239,214,108,235,32,208,49,9,94,84,17,208,37,109,74,122,20,243,235,14,115,21,10,127,75,38,147,165,35,191,175,208,230,163,229,201,30,199,87,240,67,192,195,12,140,252,68,208,211,249,120,252,91,76,171,176,41,72,31,182,218,163,132,9,156,37,55,120,141,244,254,145,150,30,61,135,250,20,4,248,99,116,110,20,95,4,252,31,225,88,88,48,42,143,174,203,89,24,136,18,241,96,217,211,129,216,38,31,190,233,169,241,180,82,172,202,136,107,54,12,14,89,26,49,168,235,27,58,156,175,101,46,135,211,22,146,105,26,213,113,241,1,94,79,232,104,221,177,130,174,243,88,168,110,148,195,209,105,185,126,7,131,183,3,89,52,89,3,183,75,90,50,42,100,47,119,125,82,143,189,172,197,236,51,212,183,146,244,5,212,119,202,171,230,42,54,132,131,161,63,50,166,12,141,167,156,144,123,104,86,237,94,192,190,200,227,20,61,60,4,202,162,223,115,109,183,18,183,245,50,131,217,188,91,75,90,134,167,202,235,179,32,26,60,221,98,172,29,127,239,73,49,229,193,127,4,0,0 };
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

