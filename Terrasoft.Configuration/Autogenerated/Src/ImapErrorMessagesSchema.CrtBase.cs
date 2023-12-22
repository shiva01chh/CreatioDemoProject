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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,144,207,10,194,48,12,198,207,27,236,29,10,222,125,128,237,56,20,132,77,7,19,60,215,46,150,194,150,148,180,83,68,124,119,71,59,252,3,51,183,36,191,124,249,18,148,3,56,43,21,136,35,48,75,71,23,191,174,165,233,179,244,145,165,89,154,172,24,180,33,20,173,231,81,249,92,236,6,105,55,204,196,53,56,39,53,184,64,217,241,220,27,37,92,128,150,152,36,170,189,229,182,6,250,206,229,162,9,131,177,247,17,49,168,69,69,170,148,184,39,95,18,34,40,95,44,34,45,240,21,120,162,218,209,90,98,223,186,126,230,167,45,203,35,21,105,131,7,110,110,221,137,9,245,31,221,59,170,112,66,49,251,6,236,162,245,144,63,227,111,126,138,83,237,59,94,193,127,12,43,89,1,0,0 };
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

