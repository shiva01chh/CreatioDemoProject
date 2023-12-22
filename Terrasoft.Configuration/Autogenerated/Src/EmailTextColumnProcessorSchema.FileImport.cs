namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTextColumnProcessorSchema

	/// <exclude/>
	public class EmailTextColumnProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTextColumnProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTextColumnProcessorSchema(EmailTextColumnProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("70d219b6-f9e4-471d-9053-15d73a72c898");
			Name = "EmailTextColumnProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,233,37,129,197,190,167,73,96,155,110,75,96,89,10,77,246,178,244,160,200,227,116,192,150,220,145,84,26,74,255,251,142,229,56,27,167,241,66,125,177,52,60,189,167,249,36,25,85,162,171,148,70,88,33,179,114,54,247,201,194,154,156,182,129,149,39,107,146,59,42,112,89,86,150,253,229,197,251,229,197,32,56,50,91,120,220,57,143,229,245,97,126,188,154,177,175,158,220,41,237,45,19,58,81,136,230,138,113,43,25,176,40,148,115,19,248,81,42,42,86,248,230,23,182,8,165,121,96,171,209,57,203,81,155,166,41,76,201,60,35,147,207,172,6,205,152,207,134,103,212,195,116,222,202,93,40,75,197,187,118,254,221,0,25,231,149,145,118,109,14,254,153,28,232,58,26,100,192,194,193,26,71,155,2,33,183,12,85,227,87,55,241,211,154,109,29,4,58,38,193,171,42,2,186,164,77,73,143,98,254,220,98,174,66,225,111,200,100,178,116,228,119,21,218,124,180,60,217,227,248,27,252,18,242,48,3,35,63,17,244,181,62,30,63,137,107,21,54,5,233,253,94,251,164,48,129,179,236,6,239,145,223,63,216,210,165,231,80,31,132,48,127,136,214,141,226,139,136,63,49,142,133,5,163,242,232,186,164,133,130,40,17,247,150,125,45,136,111,114,48,78,79,157,167,149,98,85,70,98,179,97,112,200,210,137,65,93,223,210,225,124,45,115,57,159,182,144,76,211,168,142,139,247,248,250,82,71,235,142,23,116,173,199,194,117,163,28,142,78,203,245,99,24,124,236,217,162,201,26,188,93,214,146,81,33,123,185,240,147,122,236,101,45,102,255,131,125,35,73,95,128,125,171,188,106,174,99,195,56,24,122,145,49,101,104,60,229,132,220,131,179,106,247,2,246,85,94,168,232,225,62,80,22,253,126,215,118,43,113,91,47,51,152,205,187,181,228,0,241,84,122,125,150,68,195,167,91,140,181,227,239,47,222,1,139,129,133,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("70d219b6-f9e4-471d-9053-15d73a72c898"));
		}

		#endregion

	}

	#endregion

}

