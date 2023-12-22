namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MandrillMailingResponseSchema

	/// <exclude/>
	public class MandrillMailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MandrillMailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MandrillMailingResponseSchema(MandrillMailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444");
			Name = "MandrillMailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("aa578739-72a4-4d6e-8c15-4350e99d075d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,77,75,196,64,12,134,207,43,248,31,2,123,111,239,238,226,101,5,241,80,88,182,222,196,67,58,155,214,129,249,40,51,25,113,21,255,187,233,180,93,171,160,226,156,38,111,242,38,79,226,208,82,236,81,17,220,83,8,24,125,203,197,206,187,86,119,41,32,107,239,138,10,221,49,104,99,106,10,207,90,234,222,46,47,86,41,106,215,65,125,138,76,118,243,45,46,14,201,177,182,84,136,65,163,209,175,185,141,84,73,221,58,80,39,1,236,12,198,120,5,115,235,10,181,145,6,7,33,241,46,82,46,45,203,18,182,49,89,139,225,116,45,153,100,24,124,11,252,68,103,27,196,9,201,142,254,98,91,206,6,105,240,112,131,140,178,10,7,84,252,40,66,159,26,163,21,168,97,246,79,163,135,237,164,244,12,186,15,190,167,192,154,132,118,159,253,99,254,11,221,44,124,82,78,64,64,47,164,82,190,226,217,180,68,28,25,43,178,13,133,129,112,70,108,188,55,80,39,165,72,72,135,123,175,86,29,241,38,127,226,244,121,255,5,100,90,10,34,35,167,248,191,217,183,73,31,161,206,198,187,227,31,195,215,36,71,204,135,146,104,212,150,82,86,150,239,3,217,132,71,101,109,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("300c4950-cc6e-4d74-b555-e972ea0b4444"));
		}

		#endregion

	}

	#endregion

}

