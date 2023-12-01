namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ITranslationBatchSchema

	/// <exclude/>
	public class ITranslationBatchSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ITranslationBatchSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ITranslationBatchSchema(ITranslationBatchSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6a16d126-b908-4b9c-8616-b21a5c69f407");
			Name = "ITranslationBatch";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,65,10,194,48,16,69,215,45,244,14,3,110,165,221,171,184,80,65,138,27,193,94,32,198,105,13,182,105,153,73,23,165,120,119,167,137,74,197,108,146,252,188,252,23,98,85,131,220,41,141,80,32,145,226,182,116,233,190,181,165,169,122,82,206,180,54,45,72,89,174,253,58,137,199,36,142,122,54,182,130,203,192,14,27,97,235,26,245,116,200,233,17,45,146,209,235,36,22,106,65,88,73,10,185,117,72,165,8,86,144,207,170,118,202,233,187,7,187,254,90,27,13,230,195,253,99,32,87,15,198,75,20,13,27,118,36,15,88,66,152,183,82,49,250,162,175,242,76,109,135,228,12,242,10,206,190,61,156,103,89,6,27,238,155,70,90,182,159,96,38,131,7,14,233,23,204,230,100,112,193,9,7,152,190,32,138,42,116,235,105,241,124,171,209,222,130,221,239,67,250,27,250,76,198,11,109,37,143,64,114,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6a16d126-b908-4b9c-8616-b21a5c69f407"));
		}

		#endregion

	}

	#endregion

}

