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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,219,106,194,64,16,125,78,192,127,24,236,75,132,146,15,136,136,20,145,18,168,32,173,125,46,107,28,183,41,201,110,152,221,72,69,252,247,110,118,215,75,46,66,159,50,151,51,231,204,156,141,96,37,170,138,101,8,27,36,98,74,238,117,188,144,98,159,243,154,152,206,165,136,55,196,132,42,108,60,10,79,163,48,168,85,46,56,124,28,149,198,114,122,205,121,33,183,172,72,146,133,44,75,51,245,38,57,55,229,91,255,158,158,240,81,253,94,205,96,12,234,137,144,155,4,22,5,83,42,129,187,126,35,129,100,65,85,189,45,242,12,178,6,211,135,64,2,233,192,92,112,178,179,55,5,41,148,166,58,211,146,140,208,218,82,58,132,167,239,113,68,159,10,201,140,9,204,154,34,212,173,116,2,141,91,65,208,1,205,58,176,198,138,224,236,87,65,177,115,219,180,87,91,147,172,144,116,142,205,98,148,31,152,70,191,153,75,160,163,209,73,221,30,28,181,213,10,148,15,206,109,142,212,28,5,95,133,189,108,218,107,120,43,175,84,62,10,8,117,77,226,50,7,243,57,68,151,120,214,12,173,152,96,38,137,95,81,123,211,198,61,31,199,147,137,219,236,252,15,47,86,168,191,229,110,248,133,14,50,223,193,146,72,82,180,252,205,176,178,215,227,229,33,156,88,236,250,230,169,205,239,23,47,203,74,31,159,13,166,229,72,143,45,125,177,78,190,163,170,11,13,100,63,131,180,174,21,175,80,41,115,246,67,214,84,236,101,36,183,63,230,129,160,244,216,54,157,69,148,3,52,29,95,92,181,93,180,181,48,252,3,59,91,33,50,220,3,0,0 };
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

