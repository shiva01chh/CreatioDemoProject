namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ImapErrorMessagesSchema

	/// <exclude/>
	public class ImapErrorMessagesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ImapErrorMessagesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ImapErrorMessagesSchema(ImapErrorMessagesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a97a27d8-986d-4adc-b58a-66f3167f55a1");
			Name = "ImapErrorMessages";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,10,194,48,12,134,207,27,236,29,10,222,125,0,119,28,10,194,166,131,9,158,107,23,75,161,75,74,218,41,34,190,187,163,29,138,48,115,75,242,229,207,159,160,28,192,59,169,64,156,128,89,122,186,134,117,35,141,45,242,103,145,23,121,182,98,208,134,80,116,129,71,21,54,98,63,72,183,101,38,110,192,123,169,193,71,202,141,23,107,148,240,17,90,98,178,164,246,145,219,25,176,189,223,136,54,14,166,222,87,196,160,22,53,169,74,226,129,66,69,136,160,66,185,136,116,192,55,224,137,234,70,231,136,67,231,237,204,79,91,150,71,106,210,6,143,220,222,251,51,19,234,63,186,15,84,241,132,114,246,13,216,39,235,49,127,165,223,252,20,167,218,20,111,57,204,230,233,80,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a97a27d8-986d-4adc-b58a-66f3167f55a1"));
		}

		#endregion

	}

	#endregion

}

