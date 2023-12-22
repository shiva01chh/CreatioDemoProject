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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,219,106,194,64,16,125,142,224,63,12,246,37,66,201,7,68,68,138,72,9,84,144,214,62,151,53,142,219,148,100,55,204,110,164,34,254,123,55,187,171,230,38,52,47,59,151,51,103,102,206,68,176,2,85,201,82,132,45,18,49,37,15,58,90,74,113,200,120,69,76,103,82,68,91,98,66,229,214,30,143,206,227,81,80,169,76,112,248,56,41,141,197,236,230,243,92,238,88,30,199,75,89,20,166,234,77,114,110,194,247,124,147,158,240,81,188,217,205,96,12,234,137,144,27,7,150,57,83,42,134,70,190,110,129,100,65,101,181,203,179,20,210,26,211,135,64,12,201,64,93,112,182,181,247,14,82,40,77,85,170,37,153,70,27,75,233,16,158,190,199,17,126,42,36,83,38,48,173,131,80,181,220,41,212,106,5,65,7,52,239,192,106,41,130,139,31,5,197,222,77,211,30,109,67,178,68,210,25,214,131,81,118,100,26,253,100,206,129,78,143,142,235,230,224,168,109,175,64,121,227,210,230,72,204,82,240,149,219,205,102,189,132,151,242,70,229,173,128,80,87,36,174,117,176,88,64,120,181,231,117,209,154,9,102,156,232,21,181,23,109,210,211,113,50,157,186,201,46,255,208,98,141,250,91,238,135,47,116,148,217,30,86,68,146,194,213,111,138,165,221,30,175,135,112,205,34,151,55,167,54,191,95,180,42,74,125,122,54,152,150,34,61,182,228,197,42,249,142,170,202,53,144,125,6,105,93,42,90,163,82,102,237,135,172,137,56,200,80,238,126,204,129,160,240,216,54,157,69,20,3,52,29,93,92,180,29,180,177,198,247,7,70,167,252,81,229,3,0,0 };
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

