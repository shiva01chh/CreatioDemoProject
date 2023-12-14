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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,205,145,207,74,196,48,16,198,207,91,232,59,12,123,82,144,230,1,172,123,145,101,45,236,73,251,2,99,51,173,129,38,41,147,228,176,136,239,110,19,251,199,186,94,5,75,161,100,50,223,247,253,102,106,80,147,27,176,33,168,137,25,157,109,125,241,104,77,171,186,192,232,149,53,121,246,158,103,187,224,148,233,224,229,226,60,233,251,60,27,43,66,8,40,93,208,26,249,114,152,206,149,241,196,109,52,107,45,195,192,182,33,151,132,104,128,52,170,30,70,249,208,163,167,177,34,193,17,114,243,22,239,27,171,117,48,170,73,137,208,163,233,2,118,84,204,49,226,91,206,16,94,123,213,128,90,162,170,99,116,174,39,227,243,164,125,162,126,32,30,251,35,253,21,108,42,156,200,131,164,22,67,239,151,200,4,238,200,200,72,181,69,46,22,35,241,211,169,28,144,81,131,25,119,249,176,159,251,43,185,63,28,183,67,43,89,138,212,186,42,153,124,96,227,14,207,233,187,114,40,89,148,98,190,140,221,167,160,100,68,158,7,172,228,77,42,173,113,183,95,63,230,31,15,251,155,242,108,81,18,95,169,157,183,76,127,185,173,59,168,234,13,2,108,137,226,54,119,31,121,54,190,241,249,4,17,72,2,228,40,3,0,0 };
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

