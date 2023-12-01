namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RecordProcessedEventArgsSchema

	/// <exclude/>
	public class RecordProcessedEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RecordProcessedEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RecordProcessedEventArgsSchema(RecordProcessedEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("55febf69-27f8-44d0-b988-9700d6626862");
			Name = "RecordProcessedEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("db43ba5c-9334-4bce-a1f8-d5a6f72577ed");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,80,203,106,195,48,16,60,215,224,127,88,200,221,190,39,165,80,66,40,189,133,62,62,64,149,214,238,130,45,185,187,82,104,8,253,247,74,114,18,155,38,141,14,98,53,218,157,153,29,171,122,148,65,105,132,55,100,86,226,26,95,173,157,109,168,13,172,60,57,11,135,178,184,11,66,182,133,215,189,120,236,87,101,17,145,5,99,155,126,215,157,18,89,194,11,106,199,102,203,78,163,8,154,205,14,173,127,228,86,114,111,93,215,112,47,161,239,21,239,31,142,239,216,186,35,131,2,202,24,74,58,170,3,178,141,227,126,84,141,21,248,79,252,75,12,152,152,171,19,105,61,99,29,194,71,71,26,116,50,244,175,31,88,194,84,167,205,206,139,196,222,1,217,19,198,109,182,153,42,123,191,48,159,129,205,183,198,33,251,116,13,112,214,130,97,20,139,65,85,231,185,185,191,147,193,105,118,170,14,208,162,95,129,164,235,231,134,238,187,165,175,128,16,131,179,158,26,66,150,201,192,109,213,167,64,230,152,202,179,185,166,183,64,107,198,40,226,107,196,230,80,89,100,44,158,95,85,76,242,170,50,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("55febf69-27f8-44d0-b988-9700d6626862"));
		}

		#endregion

	}

	#endregion

}

