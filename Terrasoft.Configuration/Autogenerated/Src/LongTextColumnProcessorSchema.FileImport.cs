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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,193,106,227,48,16,134,207,41,244,29,134,236,37,129,98,223,211,36,208,166,180,4,74,41,108,178,151,101,15,138,60,78,5,182,228,206,72,165,161,236,187,239,88,142,211,56,27,23,234,139,165,225,159,127,102,62,73,86,149,200,149,210,8,43,36,82,236,114,159,44,156,205,205,54,144,242,198,217,228,222,20,184,44,43,71,254,242,226,227,242,98,16,216,216,45,252,220,177,199,242,250,176,63,206,38,236,139,39,247,74,123,71,6,89,20,162,249,65,184,149,26,176,40,20,243,4,30,157,221,174,240,221,47,92,17,74,251,76,78,35,179,163,40,77,211,20,166,198,190,32,25,159,57,13,154,48,159,13,207,168,135,233,188,149,115,40,75,69,187,118,127,99,193,88,246,202,202,180,46,7,255,98,24,116,93,25,100,65,130,193,89,54,155,2,33,119,4,85,227,87,207,208,182,5,58,86,130,55,85,4,228,164,173,146,30,149,249,125,135,185,10,133,191,53,54,147,212,145,223,85,232,242,209,242,164,199,241,21,60,9,120,152,129,149,159,8,122,38,31,143,255,136,105,21,54,133,209,251,86,123,148,48,129,179,228,6,31,145,222,39,105,153,209,83,168,79,65,128,63,71,231,70,241,77,192,255,17,142,129,5,161,242,200,93,206,194,64,148,136,123,203,158,9,196,54,57,248,166,167,198,211,74,145,42,35,174,217,48,48,146,12,98,81,215,55,116,56,95,203,94,14,167,13,36,211,52,170,99,242,30,94,79,209,209,186,99,5,93,231,177,80,221,40,198,209,105,184,126,7,131,191,123,178,104,179,6,110,151,180,212,168,144,188,220,245,73,189,246,146,139,217,87,168,111,165,210,55,80,223,41,175,154,171,216,16,14,214,188,202,218,100,104,189,201,13,82,15,205,170,237,5,220,155,60,78,209,195,67,48,89,244,251,85,219,173,196,109,189,204,96,54,239,198,146,150,225,169,242,250,44,136,6,79,55,40,177,227,239,31,240,50,12,95,125,4,0,0 };
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

