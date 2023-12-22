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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,144,209,10,130,48,20,134,175,21,124,135,3,221,134,222,167,116,81,65,72,55,65,190,192,90,71,27,185,41,231,204,11,145,222,189,185,85,24,237,102,219,191,111,255,55,102,132,70,238,133,68,168,144,72,112,87,219,116,223,153,90,53,3,9,171,58,147,86,36,12,183,126,157,196,83,18,71,3,43,211,192,101,100,139,218,177,109,139,114,62,228,244,136,6,73,201,60,137,29,181,34,108,92,10,165,177,72,181,19,108,160,92,84,237,132,149,119,15,246,195,181,85,18,212,135,251,199,192,93,61,40,47,17,52,22,108,201,61,96,13,97,222,186,138,201,23,125,149,103,234,122,36,171,144,55,112,246,237,225,60,203,50,40,120,208,218,181,108,63,193,66,6,15,28,211,47,152,45,201,224,130,19,142,48,127,65,20,53,104,243,121,241,124,171,209,220,130,221,239,67,250,27,250,108,57,94,225,24,16,184,123,1,0,0 };
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

