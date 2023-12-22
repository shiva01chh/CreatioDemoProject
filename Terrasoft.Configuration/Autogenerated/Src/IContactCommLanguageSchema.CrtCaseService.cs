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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,80,65,106,195,48,16,60,219,224,63,44,57,165,23,235,1,117,125,73,33,4,114,107,62,176,181,86,174,192,146,205,106,69,8,37,127,175,236,216,169,73,105,43,116,16,171,153,217,153,241,232,40,12,216,16,156,136,25,67,111,164,220,245,222,216,54,50,138,237,125,145,127,22,121,22,131,245,45,188,93,130,144,123,46,242,52,25,226,123,103,27,176,94,136,205,200,63,36,154,96,35,187,222,185,35,250,54,98,75,9,55,178,51,165,20,84,33,58,135,124,169,151,193,158,4,186,25,8,86,147,23,107,44,49,48,117,40,164,225,108,229,3,154,155,104,121,87,81,143,50,213,128,140,14,124,10,242,178,153,225,7,189,169,103,59,43,229,178,82,19,246,155,202,36,145,125,168,143,63,109,36,240,242,59,194,247,209,234,209,241,118,122,220,215,60,221,202,248,53,96,0,77,6,99,183,74,106,184,119,16,166,38,33,144,72,42,246,175,116,139,137,215,71,157,127,173,206,140,237,232,49,187,22,121,186,235,243,5,29,138,15,228,250,1,0,0 };
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

