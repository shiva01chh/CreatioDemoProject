namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IContactCommLanguageSchema

	/// <exclude/>
	public class IContactCommLanguageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IContactCommLanguageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IContactCommLanguageSchema(IContactCommLanguageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("eb716256-d7b9-4bb9-a683-e956c5354404");
			Name = "IContactCommLanguage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("77fa8847-960e-4748-ad77-e37bb90e03a0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,80,65,106,195,48,16,60,219,224,63,44,57,165,23,235,1,117,125,73,33,4,114,107,63,176,181,86,174,192,146,204,106,69,8,165,127,175,236,216,105,72,105,43,116,16,171,153,217,153,241,232,40,142,216,17,188,18,51,198,96,164,222,5,111,108,159,24,197,6,95,149,31,85,89,164,104,125,15,47,231,40,228,30,171,50,79,198,244,54,216,14,172,23,98,51,241,15,153,38,216,201,46,56,119,68,223,39,236,41,227,38,118,161,148,130,38,38,231,144,207,237,58,216,147,192,176,0,193,106,242,98,141,37,6,166,1,133,52,156,172,188,67,119,17,173,175,42,234,94,166,25,145,209,129,207,65,158,54,11,252,160,55,237,98,231,70,185,110,212,140,253,166,50,73,98,31,219,227,79,27,25,188,254,78,240,125,178,122,114,188,157,31,215,53,15,151,50,126,13,24,65,147,193,52,220,36,53,28,28,196,185,73,136,36,146,139,253,43,221,106,226,249,94,231,95,171,11,99,59,121,44,62,171,50,223,124,190,0,90,232,56,144,241,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("eb716256-d7b9-4bb9-a683-e956c5354404"));
		}

		#endregion

	}

	#endregion

}

