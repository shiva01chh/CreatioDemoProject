namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IMailingHandlerSchema

	/// <exclude/>
	public class IMailingHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IMailingHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IMailingHandlerSchema(IMailingHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e6d073d5-261f-4fd0-a166-ab3452299b92");
			Name = "IMailingHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0a66fb70-43c4-43cd-a81c-f036ca2264c0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,207,106,195,48,12,198,207,13,244,29,68,123,217,46,201,189,237,122,233,101,57,20,202,216,30,64,75,148,196,16,219,65,118,2,163,236,221,231,202,77,72,86,24,204,55,253,249,126,250,36,108,80,147,235,176,32,120,39,102,116,182,242,233,201,154,74,213,61,163,87,214,172,147,235,58,89,245,78,153,122,209,194,180,95,39,161,178,101,170,67,27,228,198,19,87,1,180,131,252,140,170,13,253,175,104,202,150,88,218,178,44,131,131,235,181,70,254,58,222,227,11,219,65,149,228,64,141,90,168,44,131,111,8,116,36,64,19,17,233,72,200,102,136,174,255,108,85,49,19,63,204,93,93,101,246,228,241,76,190,177,165,219,193,69,164,177,248,219,153,36,78,76,232,197,153,243,104,2,219,86,226,107,230,231,209,80,204,116,200,168,193,132,187,190,108,122,71,28,174,105,168,184,157,114,115,204,103,184,91,13,138,169,152,30,50,81,10,104,176,170,188,123,24,37,79,31,11,22,44,209,207,251,63,150,121,35,109,135,127,47,35,30,162,116,242,48,142,217,146,41,227,77,37,254,142,63,97,145,148,220,252,253,0,23,237,98,237,106,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e6d073d5-261f-4fd0-a166-ab3452299b92"));
		}

		#endregion

	}

	#endregion

}

