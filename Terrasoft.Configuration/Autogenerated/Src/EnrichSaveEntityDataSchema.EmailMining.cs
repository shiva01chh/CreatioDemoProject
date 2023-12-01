namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EnrichSaveEntityDataSchema

	/// <exclude/>
	public class EnrichSaveEntityDataSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EnrichSaveEntityDataSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EnrichSaveEntityDataSchema(EnrichSaveEntityDataSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8a0b8b3a-216a-4b0e-a0df-953fd0dac922");
			Name = "EnrichSaveEntityData";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c9ff5cbb-cb0e-4041-b483-395260757ab0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,77,79,195,48,12,134,207,67,226,63,88,219,5,36,212,222,217,199,101,84,8,33,96,162,136,11,226,144,165,238,22,209,36,83,146,86,43,19,255,29,39,233,38,54,241,161,145,83,108,191,118,30,219,81,76,162,93,49,142,240,132,198,48,171,75,151,76,181,42,197,162,54,204,9,173,78,79,54,167,39,189,218,10,181,128,188,181,14,37,197,171,10,185,15,218,228,26,21,26,193,135,135,154,199,90,57,33,49,201,41,202,42,241,30,106,145,138,116,3,131,11,50,96,90,49,107,47,33,83,148,191,204,89,131,25,165,184,246,138,57,22,116,105,154,194,200,214,82,50,211,78,58,123,102,116,35,10,180,80,144,10,184,86,142,113,7,43,163,87,244,142,35,255,92,168,194,99,148,218,0,134,202,88,208,133,10,11,138,90,214,80,48,217,22,79,191,84,127,241,239,82,231,206,80,197,87,114,172,234,121,37,56,112,79,249,3,100,111,19,64,119,29,205,2,135,127,233,18,102,33,61,198,15,59,233,28,136,192,13,150,227,126,172,153,19,171,100,217,218,161,178,84,45,154,253,116,2,138,118,148,236,210,190,66,71,234,59,148,115,52,103,247,36,131,49,244,67,183,173,183,250,231,190,145,109,39,214,25,63,153,108,23,6,191,217,94,111,129,110,24,46,182,187,124,252,66,125,67,203,237,198,8,218,20,104,142,0,11,250,125,38,161,28,60,120,247,191,89,184,174,106,169,160,97,85,141,246,8,152,152,176,79,115,37,194,175,166,180,81,28,214,69,55,180,9,60,7,249,127,40,179,181,176,206,143,139,254,167,164,47,136,204,240,101,135,125,12,240,27,182,211,152,244,221,90,95,94,225,118,39,248,3,115,128,170,136,63,54,216,209,187,239,12,62,58,159,10,203,116,170,31,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8a0b8b3a-216a-4b0e-a0df-953fd0dac922"));
		}

		#endregion

	}

	#endregion

}

