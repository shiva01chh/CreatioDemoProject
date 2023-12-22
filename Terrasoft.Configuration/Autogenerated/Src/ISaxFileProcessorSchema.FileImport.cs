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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,189,83,61,111,219,48,16,157,29,32,255,225,144,44,233,98,237,137,170,37,112,93,1,9,96,196,109,119,154,60,89,68,197,163,192,35,83,27,69,255,123,73,202,114,108,167,73,138,20,168,54,30,222,187,123,31,16,9,131,220,11,137,240,5,157,19,108,27,63,189,181,212,232,117,112,194,107,75,211,79,186,195,218,244,214,249,243,179,159,231,103,147,192,154,214,176,220,178,71,115,115,242,142,212,174,67,153,120,60,157,35,161,211,50,98,34,234,210,225,58,78,161,38,143,174,137,247,174,161,94,138,77,90,190,112,86,34,179,117,25,216,135,85,167,37,232,17,247,39,216,36,233,216,175,188,71,223,90,197,215,176,200,212,188,101,82,20,5,148,28,140,17,110,91,141,131,221,10,100,88,235,71,36,232,52,123,104,81,40,116,60,221,179,138,83,90,217,11,39,12,80,140,234,227,133,206,81,44,210,4,163,68,174,213,69,85,147,194,13,196,189,156,2,43,139,140,127,162,59,244,193,17,87,119,135,231,202,98,28,39,92,61,163,96,208,137,85,135,229,16,118,76,50,24,170,96,142,254,243,64,185,154,7,173,224,249,253,15,55,175,88,190,109,81,126,7,223,10,15,77,12,17,164,37,47,52,241,168,3,4,41,112,246,199,63,249,127,209,241,177,201,71,27,245,103,65,53,167,70,191,137,78,171,119,185,218,21,121,88,35,146,215,94,199,106,27,103,13,224,70,98,247,191,42,29,79,191,217,233,44,1,183,21,60,196,236,103,59,210,187,252,47,209,67,232,99,111,214,3,203,22,141,128,213,22,180,250,91,199,137,184,204,188,175,167,253,229,146,106,210,254,97,143,25,36,30,113,70,117,151,72,106,248,13,243,251,215,240,175,31,13,227,236,240,251,13,253,166,201,166,113,4,0,0 };
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

