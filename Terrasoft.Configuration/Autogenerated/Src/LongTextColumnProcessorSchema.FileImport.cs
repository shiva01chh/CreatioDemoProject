namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LongTextColumnProcessorSchema

	/// <exclude/>
	public class LongTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LongTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LongTextColumnProcessorSchema(LongTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("9c7c9656-e810-4ae6-bd3f-7aa194ca6b08");
			Name = "LongTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("560ff4eb-7ab5-4d8f-8733-4031e1e3144b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,21,252,14,67,189,180,32,201,189,182,133,103,69,41,60,68,176,245,34,30,182,155,73,29,72,118,243,102,119,197,34,126,119,39,155,70,77,109,30,152,75,118,135,255,252,103,230,183,187,70,149,232,42,165,17,86,200,172,156,205,125,178,176,38,167,109,96,229,201,154,228,154,10,92,150,149,101,127,122,242,118,122,50,8,142,204,22,238,119,206,99,121,241,185,255,158,205,216,23,79,174,149,246,150,9,157,40,68,115,198,184,149,26,176,40,148,115,19,248,107,205,118,133,175,126,97,139,80,154,59,182,26,157,179,28,165,105,154,194,148,204,51,50,249,204,106,208,140,249,108,120,68,61,76,231,173,220,133,178,84,188,107,247,127,12,144,113,94,25,153,214,230,224,159,201,129,174,43,131,44,88,48,88,227,104,83,32,228,150,161,106,252,234,25,218,182,64,199,74,240,162,138,128,46,105,171,164,223,202,60,94,97,174,66,225,47,201,100,146,58,242,187,10,109,62,90,30,244,56,62,135,91,1,15,51,48,242,19,65,207,228,227,241,147,152,86,97,83,144,222,183,218,163,132,9,28,37,55,120,139,244,190,72,203,140,158,67,125,10,2,252,46,58,55,138,95,2,254,65,56,6,22,140,202,163,235,114,22,6,162,68,220,91,246,76,32,182,201,167,111,122,104,60,173,20,171,50,226,154,13,131,67,150,65,12,234,250,134,14,231,107,217,203,225,180,129,100,154,70,117,76,222,195,235,41,58,90,119,172,160,235,60,22,170,27,229,112,116,24,174,223,193,224,125,79,22,77,214,192,237,146,150,26,21,178,151,187,62,169,215,94,114,49,251,31,234,75,169,244,11,212,87,202,171,230,42,54,132,131,161,127,178,166,12,141,167,156,144,123,104,86,109,47,96,95,228,113,138,30,110,2,101,209,239,161,182,91,137,219,122,153,193,108,222,141,37,45,195,67,229,197,81,16,13,158,110,80,98,242,125,0,150,242,165,147,116,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("9c7c9656-e810-4ae6-bd3f-7aa194ca6b08"));
		}

		#endregion

	}

	#endregion

}

