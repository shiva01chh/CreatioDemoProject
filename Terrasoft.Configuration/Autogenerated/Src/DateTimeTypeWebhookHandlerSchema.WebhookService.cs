namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeTypeWebhookHandlerSchema

	/// <exclude/>
	public class DateTimeTypeWebhookHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeTypeWebhookHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeTypeWebhookHandlerSchema(DateTimeTypeWebhookHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6423a49-1ee5-458c-ab0f-20db6e65c91d");
			Name = "DateTimeTypeWebhookHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d7950703-7230-445f-b3e5-fcd99a7a2e60");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,77,139,219,48,16,61,103,97,255,195,224,189,196,176,216,247,124,24,218,44,165,61,180,4,18,232,161,244,160,216,227,68,173,45,153,145,180,197,148,253,239,213,167,55,237,174,151,250,32,172,209,155,247,102,222,140,96,61,170,129,213,8,71,36,98,74,182,186,216,73,209,242,179,33,166,185,20,183,55,191,111,111,22,70,113,113,134,195,168,52,246,235,233,126,157,66,88,124,96,181,150,196,81,89,132,197,220,17,158,45,1,236,58,166,212,10,30,152,198,35,239,241,56,14,248,21,79,23,41,127,126,100,162,233,144,60,186,44,75,216,40,211,247,140,198,42,222,35,12,46,1,7,173,36,139,65,132,154,176,221,102,137,49,43,43,208,150,181,72,52,229,63,60,46,135,117,74,198,188,153,78,139,79,59,163,180,236,95,22,152,65,233,168,190,61,96,203,76,167,223,115,209,216,246,151,78,83,182,203,217,180,252,30,190,88,123,97,11,217,124,243,89,254,221,82,15,230,212,241,26,106,103,213,27,78,193,10,102,213,44,139,155,212,100,251,158,228,128,164,237,56,86,176,247,244,222,231,23,70,251,128,5,63,242,198,10,8,91,112,49,193,174,141,76,53,42,77,110,246,41,35,116,88,165,89,29,164,161,26,173,175,74,51,161,85,241,78,140,235,55,116,125,237,142,46,205,111,94,215,117,28,142,109,24,183,181,62,57,149,71,141,59,20,77,104,63,222,163,23,159,81,95,100,243,63,70,76,5,253,138,187,55,48,178,29,106,107,205,35,235,204,92,141,62,226,161,222,193,109,198,197,96,116,86,29,130,89,62,21,100,251,10,171,219,233,36,90,108,74,255,240,76,73,168,13,9,85,109,202,244,119,229,136,60,253,192,90,135,108,92,198,185,120,225,28,252,42,44,120,11,147,71,197,145,198,61,35,133,75,15,185,7,105,244,180,106,64,168,236,102,231,41,113,17,228,98,120,237,99,79,254,140,15,194,116,157,15,63,189,234,124,136,254,29,244,177,235,239,15,167,160,235,224,124,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6423a49-1ee5-458c-ab0f-20db6e65c91d"));
		}

		#endregion

	}

	#endregion

}

