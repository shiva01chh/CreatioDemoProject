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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,49,107,195,48,16,133,231,24,252,31,14,178,91,123,83,186,152,210,169,157,10,157,47,246,73,17,149,78,70,146,9,193,228,191,87,146,107,106,183,205,80,122,203,161,199,233,189,79,135,24,45,133,1,59,130,87,242,30,131,147,177,105,29,75,173,70,143,81,59,174,171,169,174,234,10,82,237,61,169,164,64,107,48,132,59,120,163,227,201,185,247,214,153,209,242,51,14,203,152,16,2,238,195,104,45,250,203,195,151,148,92,35,106,14,16,79,4,22,135,65,179,2,227,148,238,64,58,95,212,243,236,8,93,177,4,78,108,128,220,3,113,212,241,178,150,155,85,148,216,102,13,227,209,36,207,46,67,254,194,152,71,166,185,221,128,93,228,39,138,1,18,89,200,61,227,21,30,39,55,168,82,147,233,155,111,126,226,167,225,39,85,136,62,63,123,131,245,146,109,39,80,20,15,57,235,0,215,101,147,255,1,220,236,236,207,128,143,229,246,109,190,93,97,220,237,137,251,249,83,228,99,209,86,245,1,58,131,168,97,92,2,0,0 };
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

