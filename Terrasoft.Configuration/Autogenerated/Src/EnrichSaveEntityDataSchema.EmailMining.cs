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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,146,77,79,2,49,16,134,207,144,240,31,38,112,209,196,236,222,65,185,192,198,24,163,18,49,94,136,135,210,157,133,198,109,75,218,46,97,37,254,119,167,237,74,128,248,17,232,169,51,243,206,244,153,153,42,38,209,174,24,71,120,65,99,152,213,133,75,70,90,21,98,81,25,230,132,86,157,246,182,211,110,85,86,168,5,76,107,235,80,82,188,44,145,251,160,77,110,81,161,17,124,112,172,121,174,148,19,18,147,41,69,89,41,62,66,45,82,145,174,103,112,65,6,140,74,102,109,31,50,69,249,203,41,91,99,70,41,174,30,51,199,130,46,77,83,184,182,149,148,204,212,195,198,158,24,189,22,57,90,200,73,5,92,43,199,184,131,149,209,43,122,199,145,127,46,84,238,49,10,109,0,67,101,204,233,66,133,5,69,45,91,83,48,249,46,158,238,85,159,249,119,169,115,103,168,226,27,57,86,213,188,20,28,184,167,252,5,178,181,13,160,187,142,38,129,195,191,212,135,73,72,143,241,227,78,26,7,34,112,131,197,77,55,214,156,18,171,100,217,198,161,178,84,45,154,221,116,8,138,118,148,236,210,246,161,35,245,3,202,57,154,139,71,146,193,13,116,67,183,181,183,186,151,190,145,239,78,172,51,126,50,217,46,12,126,179,173,214,2,221,32,92,108,115,249,252,131,250,142,150,219,140,17,180,201,209,156,0,22,244,135,76,66,57,120,242,238,179,89,184,46,43,169,96,205,202,10,237,9,48,49,225,144,102,44,194,175,166,180,235,56,172,171,102,104,67,120,13,242,115,40,179,141,176,206,143,139,254,167,164,47,136,204,240,101,131,125,10,240,59,214,163,152,244,211,90,103,111,112,191,19,252,131,217,67,149,199,31,27,236,232,61,116,6,223,254,249,2,24,149,238,199,40,4,0,0 };
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

