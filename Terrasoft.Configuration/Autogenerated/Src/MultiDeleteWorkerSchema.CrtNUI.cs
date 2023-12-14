namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiDeleteWorkerSchema

	/// <exclude/>
	public class MultiDeleteWorkerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiDeleteWorkerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiDeleteWorkerSchema(MultiDeleteWorkerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fec963bc-4f40-4b98-bb72-921691cdead0");
			Name = "MultiDeleteWorker";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,193,78,219,64,16,61,27,137,127,24,129,132,28,9,229,3,146,166,135,6,132,16,66,68,208,138,3,234,97,179,126,9,219,154,93,107,102,221,18,33,254,189,187,107,155,216,88,84,173,15,182,103,230,237,123,51,111,214,170,39,72,165,52,232,43,152,149,184,141,159,46,157,221,152,109,205,202,27,103,233,229,240,32,171,197,216,45,221,237,196,227,105,254,46,14,240,178,132,142,88,153,94,192,130,141,222,99,250,172,140,143,242,211,115,235,141,55,144,0,8,144,99,198,54,74,47,75,37,50,163,235,186,244,230,12,37,60,238,29,255,4,39,80,85,175,75,163,73,71,204,24,66,51,250,162,4,183,208,142,11,185,169,208,76,211,22,227,76,89,22,95,111,82,161,123,207,181,246,142,131,226,42,113,39,153,78,103,164,144,127,19,112,56,102,155,217,169,30,132,167,116,121,102,210,159,226,221,167,64,29,134,62,37,183,254,17,202,159,169,82,28,124,247,96,153,164,78,178,25,173,67,183,249,123,142,30,174,237,217,108,40,223,103,227,170,188,50,86,174,176,203,143,46,101,169,68,171,2,71,19,58,57,161,124,237,92,57,217,131,31,122,128,239,180,88,80,152,23,29,111,246,102,209,249,51,116,29,108,160,5,89,252,166,198,193,102,112,190,55,254,241,206,187,106,197,78,67,228,111,253,206,19,237,43,161,20,252,151,198,63,144,198,247,107,179,157,99,216,162,89,97,140,250,27,189,134,127,116,69,92,38,59,31,184,80,116,136,170,75,144,251,21,174,161,41,64,233,254,237,232,2,126,197,8,130,40,154,76,222,22,144,62,157,89,12,95,179,109,147,243,182,155,143,185,159,53,170,116,69,2,125,207,130,54,155,119,172,3,23,136,7,209,130,242,65,121,50,178,114,222,239,108,112,120,58,214,28,246,60,242,176,241,118,144,62,60,72,201,248,252,1,238,225,100,59,51,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fec963bc-4f40-4b98-bb72-921691cdead0"));
		}

		#endregion

	}

	#endregion

}

