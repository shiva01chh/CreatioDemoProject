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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,77,79,194,64,16,134,207,144,240,31,38,225,94,238,64,56,136,132,152,128,33,212,155,241,176,221,78,235,198,253,104,246,195,8,196,255,238,116,219,34,8,18,237,161,217,121,119,230,157,167,51,213,76,161,171,24,71,120,66,107,153,51,133,79,230,70,23,162,12,150,121,97,244,160,127,24,244,7,253,94,112,66,151,144,238,156,71,53,249,17,83,133,148,200,235,116,151,44,81,163,21,252,34,103,27,180,23,10,147,148,110,153,20,251,232,62,137,222,67,139,37,5,48,151,204,185,49,172,153,144,84,184,37,48,50,196,152,50,26,141,96,234,130,82,204,238,102,208,10,27,107,222,69,142,14,42,107,42,180,94,208,209,20,224,95,17,178,32,223,0,21,57,129,67,157,215,28,182,245,75,58,187,81,231,71,194,243,61,243,140,62,220,91,198,253,11,9,85,200,164,224,192,107,164,75,162,94,51,148,35,249,230,8,48,134,77,172,108,238,207,176,59,129,108,130,244,53,105,139,150,28,83,79,145,26,166,53,170,12,109,77,212,33,101,198,72,72,3,231,72,100,7,40,209,79,200,136,94,159,55,122,222,157,204,195,51,31,220,255,122,46,131,200,33,141,133,15,249,159,155,46,209,211,66,108,157,232,0,63,56,86,245,206,127,233,220,118,90,116,105,39,167,43,253,218,108,231,109,189,218,45,42,17,39,185,226,251,52,74,115,147,227,141,186,135,133,14,10,45,203,36,78,27,143,25,60,26,47,10,193,227,127,185,226,238,219,231,234,148,135,180,186,102,249,49,110,212,115,49,106,244,124,1,191,194,249,170,100,3,0,0 };
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

