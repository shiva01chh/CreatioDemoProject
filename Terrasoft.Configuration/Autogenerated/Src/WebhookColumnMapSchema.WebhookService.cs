namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WebhookColumnMapSchema

	/// <exclude/>
	public class WebhookColumnMapSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WebhookColumnMapSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WebhookColumnMapSchema(WebhookColumnMapSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("8640abaf-c1c2-47ff-a168-5310c87cef25");
			Name = "WebhookColumnMap";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("fe674b36-6b4e-4761-be68-f76112863a49");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,65,75,196,48,16,133,207,91,232,127,24,216,123,115,119,197,75,17,79,122,18,60,207,182,147,108,48,153,132,36,69,150,226,127,55,73,45,110,213,61,136,115,25,242,152,188,247,101,8,163,165,232,113,32,120,166,16,48,58,153,186,222,177,212,106,10,152,180,227,182,153,219,166,109,32,215,62,144,202,10,244,6,99,188,129,23,58,158,156,123,237,157,153,44,63,162,95,199,132,16,112,27,39,107,49,156,239,190,164,236,154,80,115,132,116,34,176,232,189,102,5,198,41,61,128,116,161,170,111,139,35,12,213,18,56,179,1,242,8,196,73,167,243,165,220,93,68,137,109,150,159,142,38,123,14,5,242,23,198,50,50,47,237,10,236,42,63,80,138,144,201,98,233,5,175,242,56,185,65,149,154,204,216,125,243,19,63,13,63,169,98,10,229,217,27,172,167,98,59,131,162,116,40,89,7,120,95,55,249,31,192,205,206,254,12,120,95,111,95,231,219,85,198,221,158,120,92,62,69,57,86,45,215,7,169,69,115,129,84,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("8640abaf-c1c2-47ff-a168-5310c87cef25"));
		}

		#endregion

	}

	#endregion

}

