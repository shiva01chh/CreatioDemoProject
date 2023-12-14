namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationLoggerSchema

	/// <exclude/>
	public class TranslationLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationLoggerSchema(TranslationLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5a3f11c0-05c4-491f-b69b-c36875a97219");
			Name = "TranslationLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,219,106,194,64,16,125,142,224,63,12,246,37,66,201,7,40,34,69,164,4,42,72,107,159,203,26,199,52,37,217,13,179,27,169,136,255,222,201,238,122,201,69,104,94,118,46,103,206,204,156,137,20,5,234,82,36,8,27,36,18,90,237,77,180,80,114,159,165,21,9,147,41,25,109,72,72,157,91,123,56,56,13,7,65,165,51,153,194,199,81,27,44,166,87,63,205,213,86,228,147,201,66,21,5,87,189,169,52,229,240,45,127,79,79,248,40,126,223,141,49,140,122,34,76,217,129,69,46,180,158,192,93,190,110,129,100,65,101,181,205,179,4,146,26,211,133,192,4,226,158,186,224,100,107,111,29,148,212,134,170,196,40,226,70,107,75,233,16,158,190,195,17,126,106,36,46,147,152,212,65,168,26,238,24,106,181,130,160,5,154,181,96,181,20,193,217,143,130,114,231,166,105,142,182,38,85,34,153,12,235,193,40,59,8,131,126,50,231,64,171,71,203,117,115,164,104,108,175,64,123,227,220,228,136,121,41,248,202,237,102,211,78,194,75,121,165,242,86,64,104,42,146,151,58,152,207,33,188,216,179,186,104,37,164,96,39,122,69,227,69,27,117,116,28,141,199,110,178,243,63,180,88,161,249,86,187,254,11,29,84,182,131,37,145,162,112,249,155,96,105,183,199,203,33,92,179,200,229,249,212,252,251,69,203,162,52,199,103,198,52,20,233,176,197,47,86,201,119,212,85,110,128,236,211,75,235,82,209,10,181,230,181,31,178,198,114,175,66,181,253,225,3,65,225,177,77,58,139,40,122,104,90,186,184,104,51,104,99,252,253,1,236,206,238,131,221,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5a3f11c0-05c4-491f-b69b-c36875a97219"));
		}

		#endregion

	}

	#endregion

}

