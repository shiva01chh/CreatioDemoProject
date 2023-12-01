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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,145,193,74,196,48,16,134,207,91,232,59,12,123,82,144,230,1,172,123,145,101,45,236,73,247,5,198,102,90,3,77,82,38,201,97,17,223,221,36,182,91,235,122,21,44,133,146,201,252,255,255,205,212,160,38,55,98,75,112,34,102,116,182,243,213,163,53,157,234,3,163,87,214,148,197,123,89,108,130,83,166,135,151,179,243,164,239,203,34,86,132,16,80,187,160,53,242,121,55,157,27,227,137,187,100,214,89,134,145,109,75,46,11,209,0,105,84,3,68,249,56,160,167,88,145,224,8,185,125,75,247,173,213,58,24,213,230,68,24,208,244,1,123,170,230,24,241,45,103,12,175,131,106,65,93,162,154,125,114,62,77,198,199,73,251,68,195,72,28,251,19,253,21,108,46,28,200,131,164,14,195,224,47,145,25,220,145,145,137,106,141,92,93,140,196,79,167,122,68,70,13,38,238,242,97,59,247,55,114,187,219,175,135,86,178,22,185,117,81,50,249,192,198,237,158,243,119,225,80,178,170,197,124,153,186,15,65,201,132,60,15,216,200,155,92,90,226,110,191,126,204,63,30,246,55,229,209,162,36,190,82,59,111,153,254,114,91,119,208,156,86,8,176,38,74,219,220,124,148,69,124,227,243,9,160,106,237,3,39,3,0,0 };
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

