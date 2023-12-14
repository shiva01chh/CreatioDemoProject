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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,75,235,64,16,199,207,21,252,14,67,189,180,32,201,189,182,133,103,69,41,60,68,176,245,34,30,182,155,73,93,72,118,243,102,118,197,34,126,119,39,155,70,77,109,30,152,75,118,135,255,252,103,230,183,187,86,149,200,149,210,8,43,36,82,236,114,159,44,156,205,205,54,144,242,198,217,228,218,20,184,44,43,71,254,244,228,237,244,100,16,216,216,45,220,239,216,99,121,241,185,255,158,77,216,23,79,174,149,246,142,12,178,40,68,115,70,184,149,26,176,40,20,243,4,254,58,187,93,225,171,95,184,34,148,246,142,156,70,102,71,81,154,166,41,76,141,125,70,50,62,115,26,52,97,62,27,30,81,15,211,121,43,231,80,150,138,118,237,254,143,5,99,217,43,43,211,186,28,252,179,97,208,117,101,144,5,9,6,103,217,108,10,132,220,17,84,141,95,61,67,219,22,232,88,9,94,84,17,144,147,182,74,250,173,204,227,21,230,42,20,254,210,216,76,82,71,126,87,161,203,71,203,131,30,199,231,112,43,224,97,6,86,126,34,232,153,124,60,126,18,211,42,108,10,163,247,173,246,40,97,2,71,201,13,222,34,189,47,210,50,163,167,80,159,130,0,191,139,206,141,226,151,128,127,16,142,129,5,161,242,200,93,206,194,64,148,136,123,203,158,9,196,54,249,244,77,15,141,167,149,34,85,70,92,179,97,96,36,25,196,162,174,111,232,112,190,150,189,28,78,27,72,166,105,84,199,228,61,188,158,162,163,117,199,10,186,206,99,161,186,81,140,163,195,112,253,14,6,239,123,178,104,179,6,110,151,180,212,168,144,188,220,245,73,189,246,146,139,217,255,80,95,74,165,95,160,190,82,94,53,87,177,33,28,172,249,39,107,147,161,245,38,55,72,61,52,171,182,23,112,47,242,56,69,15,55,193,100,209,239,161,182,91,137,219,122,153,193,108,222,141,37,45,195,67,229,197,81,16,13,158,110,80,98,245,247,1,16,149,40,43,117,4,0,0 };
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

