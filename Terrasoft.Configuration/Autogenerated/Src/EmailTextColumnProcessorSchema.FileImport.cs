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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,147,65,107,227,48,16,133,207,41,244,63,12,217,75,2,139,125,79,147,64,155,110,151,64,41,133,38,189,148,61,40,242,56,29,176,37,239,72,42,27,74,255,123,199,114,156,214,217,184,80,95,44,13,79,239,105,62,73,70,149,232,42,165,17,86,200,172,156,205,125,178,176,38,167,109,96,229,201,154,228,134,10,92,150,149,101,127,126,246,122,126,54,8,142,204,22,30,118,206,99,121,113,152,127,94,205,216,87,79,110,148,246,150,9,157,40,68,243,131,113,43,25,176,40,148,115,19,248,85,42,42,86,248,207,47,108,17,74,115,207,86,163,115,150,163,54,77,83,152,146,121,70,38,159,89,13,154,49,159,13,79,168,135,233,188,149,187,80,150,138,119,237,252,210,0,25,231,149,145,118,109,14,254,153,28,232,58,26,100,192,194,193,26,71,155,2,33,183,12,85,227,87,55,113,107,205,182,14,2,29,147,224,69,21,1,93,210,166,164,159,98,158,174,49,87,161,240,87,100,50,89,58,242,187,10,109,62,90,30,237,113,252,19,238,132,60,204,192,200,79,4,125,173,143,199,127,196,181,10,155,130,244,126,175,125,82,152,192,73,118,131,215,200,239,3,182,116,233,57,212,7,33,204,239,163,117,163,248,38,226,255,24,199,194,130,81,121,116,93,210,66,65,148,136,123,203,190,22,196,55,57,24,167,199,206,211,74,177,42,35,177,217,48,56,100,233,196,160,174,111,233,112,190,150,185,156,79,91,72,166,105,84,199,197,123,124,125,169,163,117,199,11,186,214,99,225,186,81,14,71,199,229,250,49,12,222,246,108,209,100,13,222,46,107,201,168,144,189,92,248,73,61,246,178,22,179,175,96,95,73,210,55,96,95,43,175,154,235,216,48,14,134,254,202,152,50,52,158,114,66,238,193,89,181,123,1,251,34,47,84,244,240,59,80,22,253,30,107,187,149,184,173,151,25,204,230,221,90,114,128,120,44,189,56,73,162,225,211,45,198,154,124,239,222,91,181,136,124,4,0,0 };
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

