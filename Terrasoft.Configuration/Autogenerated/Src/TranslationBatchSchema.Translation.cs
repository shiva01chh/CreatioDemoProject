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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,143,205,74,3,49,20,133,215,19,152,119,184,224,70,161,204,236,219,218,133,21,68,220,20,236,11,196,120,59,13,206,36,195,189,137,48,20,223,221,252,169,211,214,85,38,103,14,231,251,98,228,128,60,74,133,176,71,34,201,246,224,154,173,53,7,221,121,146,78,91,211,236,73,26,238,211,119,45,78,181,168,60,107,211,193,235,196,14,135,208,237,123,84,241,39,55,79,104,144,180,90,213,34,180,110,8,187,144,194,182,151,204,75,152,173,60,72,167,142,169,51,250,183,94,43,80,177,114,213,128,37,60,234,180,44,105,90,179,163,64,93,64,62,55,11,120,190,94,172,78,105,245,15,29,164,28,121,229,44,5,131,93,130,229,70,1,95,78,220,230,117,248,192,233,14,226,83,171,234,5,39,184,143,193,42,94,191,10,0,205,123,102,156,3,119,100,71,36,167,241,2,215,182,45,172,217,15,67,120,201,230,39,152,193,227,126,243,91,108,231,205,98,90,196,162,77,246,234,208,37,163,106,36,253,41,29,2,151,224,127,197,156,158,135,41,19,226,27,130,210,56,12,2,2,0,0 };
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

