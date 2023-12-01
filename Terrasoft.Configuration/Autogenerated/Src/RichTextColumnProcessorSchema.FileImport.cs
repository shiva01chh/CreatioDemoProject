namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RichTextColumnProcessorSchema

	/// <exclude/>
	public class RichTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RichTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RichTextColumnProcessorSchema(RichTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0707d032-3302-49c0-85c6-57a87aecda8d");
			Name = "RichTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,197,190,167,73,96,155,210,18,88,74,217,38,189,148,61,40,242,56,25,176,37,239,72,42,13,165,255,189,99,57,110,235,108,188,80,95,44,13,79,239,105,62,73,70,149,232,42,165,17,86,200,172,156,205,125,178,176,38,167,109,96,229,201,154,228,134,10,92,150,149,101,127,126,246,122,126,54,8,142,204,22,30,246,206,99,121,249,49,255,186,154,177,175,158,220,40,237,45,19,58,81,136,230,7,227,86,50,96,81,40,231,38,240,155,244,110,133,47,126,97,139,80,154,123,182,26,157,179,28,165,105,154,194,148,204,14,153,124,102,53,104,198,124,54,60,161,30,166,243,86,238,66,89,42,222,183,243,159,6,200,56,175,140,116,107,115,240,59,114,160,235,100,144,1,11,6,107,28,109,10,132,220,50,84,141,95,221,195,47,107,182,117,16,232,152,4,207,170,8,232,146,54,37,253,18,243,116,141,185,10,133,191,34,147,201,210,145,223,87,104,243,209,242,104,143,227,11,184,19,240,48,3,35,63,17,244,116,62,30,255,17,211,42,108,10,210,135,173,246,40,97,2,39,201,13,94,35,189,79,210,210,163,231,80,159,130,0,191,143,206,141,226,155,128,255,33,28,11,11,70,229,209,117,57,11,3,81,34,30,44,123,58,16,219,228,195,55,61,54,158,86,138,85,25,113,205,134,193,33,75,35,6,117,125,67,135,243,181,204,229,112,218,66,50,77,163,58,46,62,192,235,9,29,173,59,86,208,117,30,11,213,141,114,56,58,46,215,239,96,240,118,32,139,38,107,224,118,73,75,70,133,236,229,174,79,234,177,151,181,152,253,15,245,149,36,125,3,245,181,242,170,185,138,13,225,96,232,175,140,41,67,227,41,39,228,30,154,85,187,23,176,207,242,56,69,15,183,129,178,232,247,88,219,173,196,109,189,204,96,54,239,214,146,150,225,177,242,242,36,136,6,79,183,24,107,242,189,3,174,140,60,130,118,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0707d032-3302-49c0-85c6-57a87aecda8d"));
		}

		#endregion

	}

	#endregion

}

