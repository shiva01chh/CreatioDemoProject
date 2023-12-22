namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LookupValuesProcessorErrorEventArgsSchema

	/// <exclude/>
	public class LookupValuesProcessorErrorEventArgsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LookupValuesProcessorErrorEventArgsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LookupValuesProcessorErrorEventArgsSchema(LookupValuesProcessorErrorEventArgsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8dbe4f07-e89f-42d7-b44a-3c89f43c4a8f");
			Name = "LookupValuesProcessorErrorEventArgs";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,144,193,106,195,48,12,134,207,41,244,29,4,189,108,80,250,0,45,59,140,208,141,194,54,10,221,118,247,92,53,51,75,236,32,217,99,165,244,221,103,59,105,226,150,173,36,135,96,201,250,255,95,254,180,168,144,107,33,17,94,145,72,176,217,217,89,110,244,78,21,142,132,85,70,207,30,84,137,171,170,54,100,199,163,195,120,148,57,86,186,128,205,158,45,86,139,241,200,119,38,132,133,159,4,200,75,193,60,135,39,99,190,92,253,46,74,135,188,38,35,145,217,208,146,200,255,190,81,219,123,42,56,234,106,247,81,42,9,50,168,134,136,96,14,137,65,22,150,233,178,253,206,108,201,73,107,200,111,176,142,206,49,228,148,50,192,255,230,209,169,45,248,66,217,253,70,126,98,37,222,86,219,41,120,223,240,98,105,74,87,233,23,207,171,107,85,138,3,140,104,58,133,229,143,196,58,32,11,169,89,134,167,242,22,226,166,217,242,220,24,238,46,163,22,113,44,239,114,252,68,31,218,92,62,39,137,254,58,93,160,25,232,150,8,246,167,115,188,58,54,56,38,168,183,13,179,182,110,1,122,38,53,146,85,248,55,190,222,183,63,29,160,64,187,0,165,45,146,22,37,112,168,142,103,178,72,244,242,225,255,233,58,85,139,247,236,177,3,194,90,89,2,240,154,40,5,209,194,73,91,177,147,126,191,239,196,60,216,42,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8dbe4f07-e89f-42d7-b44a-3c89f43c4a8f"));
		}

		#endregion

	}

	#endregion

}

