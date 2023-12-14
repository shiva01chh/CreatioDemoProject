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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,193,10,194,48,12,134,207,27,236,29,10,222,125,128,237,56,20,132,77,7,19,60,215,46,150,194,150,148,180,83,68,124,119,103,59,20,97,230,150,228,203,159,63,65,57,128,179,82,129,56,2,179,116,116,241,235,90,154,62,75,31,89,154,165,201,138,65,27,66,209,122,30,149,207,197,110,144,118,195,76,92,131,115,82,131,11,148,29,207,189,81,194,5,104,137,73,162,218,71,110,107,160,239,92,46,154,48,24,123,95,17,131,90,84,164,74,137,123,242,37,33,130,242,197,34,210,2,95,129,39,170,29,173,37,246,173,235,103,126,218,178,60,82,145,54,120,224,230,214,157,152,80,255,209,189,163,10,39,20,179,111,192,46,90,15,249,51,254,230,167,56,213,222,241,2,87,104,59,109,81,1,0,0 };
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

