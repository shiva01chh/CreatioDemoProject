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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,146,207,106,195,48,12,198,207,13,228,29,68,123,217,46,201,189,237,122,233,101,57,20,202,216,30,192,139,149,196,16,219,65,118,2,163,236,221,231,200,77,72,86,24,204,55,253,249,126,250,36,108,132,70,215,137,18,225,29,137,132,179,149,207,206,214,84,170,238,73,120,101,77,154,220,210,100,211,59,101,234,85,11,225,33,77,66,101,71,88,135,54,40,140,71,170,2,104,15,197,69,168,54,244,191,10,35,91,36,110,203,243,28,142,174,215,90,208,215,233,30,95,201,14,74,162,3,53,105,161,178,4,190,65,208,145,0,77,68,100,19,33,95,32,186,254,179,85,229,66,252,48,119,115,227,217,179,199,11,250,198,74,183,135,43,75,99,241,183,51,78,156,9,133,103,103,206,11,19,216,182,98,95,11,63,143,134,98,166,19,36,52,152,112,215,151,109,239,144,194,53,13,150,227,41,183,167,98,129,27,107,80,206,197,236,152,179,146,65,131,85,242,238,97,146,60,125,172,88,176,70,63,31,254,88,230,13,181,29,254,189,12,123,136,210,217,195,52,102,135,70,198,155,114,252,29,127,194,42,201,185,241,253,0,33,142,245,35,98,2,0,0 };
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

