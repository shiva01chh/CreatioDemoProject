namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationBatchSchema

	/// <exclude/>
	public class TranslationBatchSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationBatchSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationBatchSchema(TranslationBatchSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("10369cb8-3549-4f33-8ff6-7c40df21ba6d");
			Name = "TranslationBatch";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,205,74,195,64,20,133,215,19,200,59,92,112,163,80,146,125,91,187,176,130,136,155,130,125,129,113,188,77,7,39,147,112,239,140,16,138,239,238,252,169,105,107,54,201,156,28,206,247,141,149,61,242,40,21,194,30,137,36,15,7,215,108,7,123,208,157,39,233,244,96,155,61,73,203,38,125,215,213,169,174,132,103,109,59,120,157,216,97,31,186,198,160,138,63,185,121,66,139,164,213,170,174,66,235,134,176,11,41,108,141,100,94,194,108,229,65,58,117,76,157,209,191,25,173,64,197,202,85,3,150,240,168,211,178,164,105,205,142,2,117,1,249,189,89,192,243,245,162,56,165,213,63,116,144,114,228,149,27,40,24,236,18,44,55,10,248,114,226,54,175,195,7,78,119,16,175,42,196,11,78,112,31,131,85,60,126,21,0,218,247,204,56,7,238,104,24,145,156,198,11,92,219,182,176,102,223,247,225,38,155,159,96,6,143,251,205,111,177,157,55,139,105,17,139,54,217,171,67,151,140,196,72,250,83,58,4,46,193,255,138,57,61,15,83,22,158,111,77,220,109,49,3,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("10369cb8-3549-4f33-8ff6-7c40df21ba6d"));
		}

		#endregion

	}

	#endregion

}

