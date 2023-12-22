namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IEmailTemplateLanguageHelperSchema

	/// <exclude/>
	public class IEmailTemplateLanguageHelperSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IEmailTemplateLanguageHelperSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IEmailTemplateLanguageHelperSchema(IEmailTemplateLanguageHelperSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a06ed1bb-262f-444b-a442-af9c8800a88f");
			Name = "IEmailTemplateLanguageHelper";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("91d5b8ed-2389-4812-9e17-f329888285e6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,145,193,106,132,48,16,134,207,43,248,14,195,158,90,88,204,3,212,238,165,44,91,97,79,173,47,48,53,163,13,152,68,38,201,97,41,125,247,154,84,221,181,219,107,161,34,72,38,243,255,255,55,163,65,77,110,192,134,160,38,102,116,182,245,197,147,53,173,234,2,163,87,214,228,217,71,158,109,130,83,166,131,215,179,243,164,31,242,108,172,8,33,160,116,65,107,228,243,126,58,87,198,19,183,209,172,181,12,3,219,134,92,18,162,1,210,168,122,24,229,67,143,158,198,138,4,71,200,205,123,188,111,172,214,193,168,38,37,66,143,166,11,216,81,49,199,136,171,156,33,188,245,170,1,181,68,85,135,232,92,79,198,167,73,251,76,253,64,60,246,71,250,27,216,84,56,146,7,73,45,134,222,47,145,9,220,145,145,145,106,141,92,44,70,226,167,83,57,32,163,6,51,238,242,113,59,247,87,114,187,63,172,135,86,178,20,169,245,162,100,242,129,141,219,191,164,239,133,67,201,162,20,243,101,236,62,6,37,35,242,60,96,37,239,82,233,18,119,255,253,99,254,241,176,191,41,79,22,37,241,141,218,121,203,244,151,219,218,65,85,175,16,96,77,20,183,185,249,204,179,241,189,126,190,0,177,9,192,148,48,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a06ed1bb-262f-444b-a442-af9c8800a88f"));
		}

		#endregion

	}

	#endregion

}

