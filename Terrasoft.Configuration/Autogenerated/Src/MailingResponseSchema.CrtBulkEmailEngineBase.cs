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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,111,194,48,12,134,207,32,241,31,44,113,111,239,128,56,140,33,52,9,38,68,119,155,118,72,83,183,139,150,52,85,62,166,1,218,127,159,155,182,172,12,134,182,30,170,248,141,253,250,169,221,146,41,180,21,227,8,79,104,12,179,58,119,209,66,151,185,40,188,97,78,232,114,52,60,142,134,163,225,192,91,81,22,144,236,173,67,53,253,17,83,133,148,200,235,116,27,173,176,68,35,248,69,206,206,151,78,40,140,18,186,101,82,28,130,251,52,120,143,13,22,20,192,66,50,107,39,176,97,66,82,225,142,192,200,16,67,74,28,199,48,179,94,41,102,246,115,104,133,173,209,239,34,67,11,149,209,21,26,39,232,168,115,112,175,8,169,151,111,128,138,156,192,98,153,213,28,166,245,139,58,187,184,243,35,225,249,158,57,70,31,238,12,227,238,133,132,202,167,82,112,224,53,210,37,209,160,25,202,137,124,123,2,152,192,54,84,54,247,103,216,157,64,54,94,186,154,180,69,139,78,169,125,164,134,105,131,42,69,83,19,117,72,169,214,18,18,207,57,18,217,17,10,116,83,50,162,215,231,141,158,119,189,121,56,230,188,253,95,207,149,23,25,36,161,240,33,251,115,211,21,58,90,136,169,19,45,224,7,199,170,222,249,47,157,219,78,203,46,173,119,186,210,175,205,182,206,212,171,221,161,18,97,146,107,126,72,130,180,208,25,222,168,123,88,150,94,161,97,169,196,89,227,49,135,71,237,68,46,120,248,47,215,220,126,251,92,157,242,152,86,215,44,63,196,141,122,46,6,173,255,124,1,211,128,147,51,109,3,0,0 };
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

