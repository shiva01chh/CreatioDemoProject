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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,80,65,106,195,48,16,60,219,224,63,44,57,165,23,235,1,117,125,73,33,4,114,107,63,176,181,87,174,192,146,204,106,69,8,165,127,175,228,216,105,72,105,43,116,16,171,153,217,153,113,104,41,76,216,17,188,18,51,6,175,165,222,121,167,205,16,25,197,120,87,149,31,85,89,196,96,220,0,47,231,32,100,31,171,50,77,166,248,54,154,14,140,19,98,157,249,135,68,19,236,100,231,173,61,162,27,34,14,148,112,153,93,40,165,160,9,209,90,228,115,187,14,246,36,48,46,64,48,61,57,49,218,16,3,211,136,66,61,156,140,188,67,119,17,173,175,42,234,94,166,153,144,209,130,75,65,158,54,11,252,208,111,218,197,206,141,114,221,168,25,251,77,101,146,200,46,180,199,159,54,18,120,253,205,240,125,52,125,118,188,157,31,215,53,15,151,50,126,13,24,160,39,141,113,188,73,170,217,91,8,115,147,16,72,36,21,251,87,186,213,196,243,189,206,191,86,23,198,54,123,44,62,171,50,221,124,190,0,145,134,249,185,242,1,0,0 };
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

