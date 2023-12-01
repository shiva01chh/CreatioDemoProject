namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ValueToProcessSchema

	/// <exclude/>
	public class ValueToProcessSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ValueToProcessSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ValueToProcessSchema(ValueToProcessSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dfa4da1a-566c-479e-a9dd-b9d6bfc7fa46");
			Name = "ValueToProcess";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,139,194,48,16,133,207,13,244,63,12,236,101,23,150,254,0,101,79,194,130,55,17,241,30,227,88,2,105,166,76,146,85,40,254,119,211,105,176,149,245,152,249,230,189,121,47,94,119,24,122,109,16,14,200,172,3,93,98,179,33,127,177,109,98,29,45,249,230,215,58,220,118,61,113,172,213,80,171,170,79,39,103,13,24,167,67,128,163,118,9,15,180,99,50,24,66,166,227,70,245,193,216,102,41,100,163,16,57,153,72,188,130,157,232,70,92,28,94,181,159,201,250,8,76,215,173,63,227,237,27,178,208,250,22,12,185,212,249,215,217,223,40,252,2,57,85,237,139,2,126,158,226,181,128,205,172,204,108,225,51,97,185,158,129,152,201,232,94,43,9,143,254,60,229,47,239,82,38,231,236,145,163,197,48,119,89,180,41,217,38,219,1,90,140,107,184,255,231,203,84,111,182,228,19,158,149,230,133,55,193,242,84,128,82,15,226,91,22,217,196,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dfa4da1a-566c-479e-a9dd-b9d6bfc7fa46"));
		}

		#endregion

	}

	#endregion

}

