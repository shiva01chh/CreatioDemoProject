namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationLoggerSchema

	/// <exclude/>
	public class ITranslationLoggerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationLoggerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationLoggerSchema(ITranslationLoggerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d");
			Name = "ITranslationLogger";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5bb0d1bd-fb48-4884-8a1c-84058bcf48c3");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,65,10,194,48,16,69,215,22,188,195,128,27,221,120,0,93,137,184,40,40,136,122,129,52,157,198,72,205,148,73,42,138,120,119,211,41,150,40,102,147,252,249,111,254,36,113,234,138,190,81,26,225,132,204,202,83,21,230,107,114,149,53,45,171,96,201,205,79,172,156,175,229,60,206,158,227,108,212,122,235,12,28,31,62,224,117,57,232,180,157,49,237,138,76,164,38,140,38,10,200,93,64,174,226,192,5,228,9,180,37,99,144,133,108,218,162,182,26,236,7,252,203,141,158,194,14,177,59,12,103,42,253,2,246,210,221,155,55,178,37,108,152,137,167,155,187,198,166,11,0,156,45,127,188,124,165,59,231,128,190,173,3,176,108,9,148,187,138,166,84,92,80,7,136,159,229,149,145,8,153,142,174,236,47,32,250,213,191,244,171,40,181,116,189,1,251,147,211,44,114,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("fee74088-6ba4-462a-9370-fec3c8e1fb8d"));
		}

		#endregion

	}

	#endregion

}

