namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MailingResponseSchema

	/// <exclude/>
	public class MailingResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MailingResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MailingResponseSchema(MailingResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e");
			Name = "MailingResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6e206974-7c3f-4704-9c49-6b38b2d992b2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,111,194,48,12,134,207,32,241,31,44,113,47,119,64,28,198,16,154,4,19,162,187,77,59,164,169,219,69,75,154,42,31,211,0,237,191,207,73,91,6,131,161,173,135,42,126,99,191,126,106,183,98,10,109,205,56,194,19,26,195,172,46,92,50,215,85,33,74,111,152,19,186,26,244,15,131,254,160,223,243,86,84,37,164,59,235,80,77,126,196,84,33,37,242,144,110,147,37,86,104,4,191,200,217,250,202,9,133,73,74,183,76,138,125,116,159,68,239,161,193,146,2,152,75,102,237,24,214,76,72,42,220,18,24,25,98,76,25,141,70,48,181,94,41,102,118,51,104,133,141,209,239,34,71,11,181,209,53,26,39,232,168,11,112,175,8,153,151,111,128,138,156,192,98,149,7,14,211,250,37,157,221,168,243,35,225,249,158,57,70,31,238,12,227,238,133,132,218,103,82,112,224,1,233,146,168,215,12,229,72,190,57,2,140,97,19,43,155,251,51,236,78,32,27,47,93,32,109,209,146,99,234,41,82,195,180,70,149,161,9,68,29,82,166,181,132,212,115,142,68,118,128,18,221,132,140,232,245,121,163,231,221,201,60,28,115,222,254,175,231,210,139,28,210,88,248,144,255,185,233,18,29,45,196,132,68,11,248,193,177,14,59,255,165,115,219,105,209,165,157,156,174,244,107,179,173,51,97,181,91,84,34,78,114,197,247,105,148,230,58,199,27,117,15,139,202,43,52,44,147,56,109,60,102,240,168,157,40,4,143,255,229,138,219,111,159,171,83,30,210,234,154,229,199,184,81,207,197,168,133,231,11,76,81,163,105,101,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3aa9b5b-0ffb-4cd9-a76c-7a7c5b382b5e"));
		}

		#endregion

	}

	#endregion

}

