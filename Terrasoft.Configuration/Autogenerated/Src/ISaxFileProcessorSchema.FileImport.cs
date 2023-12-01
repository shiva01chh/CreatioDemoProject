namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISaxFileProcessorSchema

	/// <exclude/>
	public class ISaxFileProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISaxFileProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISaxFileProcessorSchema(ISaxFileProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6c7807a8-a16e-4cad-b5b6-7f795f2cb0e0");
			Name = "ISaxFileProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,61,111,219,48,16,157,29,32,255,225,144,44,201,98,237,137,170,37,112,93,1,45,96,196,109,119,154,60,89,68,197,163,192,35,83,27,69,255,123,73,202,114,108,183,77,130,4,136,54,30,222,187,123,31,16,9,131,220,11,137,240,21,157,19,108,27,63,189,179,212,232,117,112,194,107,75,211,143,186,195,218,244,214,249,243,179,95,231,103,147,192,154,214,176,220,178,71,115,123,242,142,212,174,67,153,120,60,157,35,161,211,50,98,34,234,210,225,58,78,161,38,143,174,137,247,110,160,94,138,77,90,190,112,86,34,179,117,25,216,135,85,167,37,232,17,247,47,216,36,233,216,175,252,130,190,181,138,111,96,145,169,121,203,164,40,10,40,57,24,35,220,182,26,7,187,21,200,176,214,15,72,208,105,246,208,162,80,232,120,186,103,21,167,180,178,23,78,24,160,24,213,135,11,157,163,88,164,9,70,137,92,171,139,170,38,133,27,136,123,57,5,86,22,25,255,72,119,232,131,35,174,62,31,158,43,139,113,156,112,245,140,130,65,39,86,29,150,67,216,49,201,96,168,130,57,250,79,3,229,106,30,180,130,191,239,95,223,62,97,249,174,69,249,3,124,43,60,52,49,68,144,150,188,208,196,163,14,16,164,192,217,159,111,242,255,95,199,199,38,31,108,212,159,5,213,156,26,253,46,58,173,94,229,106,87,228,97,141,72,94,123,29,171,109,156,53,128,27,137,221,123,85,58,158,126,182,211,89,2,110,43,184,143,217,207,118,164,87,249,95,162,135,208,199,222,172,7,150,45,26,1,171,45,104,245,82,199,137,184,204,188,111,167,253,229,146,106,210,254,126,143,25,36,30,113,70,117,151,72,106,248,13,243,251,247,240,175,31,13,227,44,126,127,0,64,161,53,233,104,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6c7807a8-a16e-4cad-b5b6-7f795f2cb0e0"));
		}

		#endregion

	}

	#endregion

}

