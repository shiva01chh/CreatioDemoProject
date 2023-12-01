namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SendEmailHandlerSchema

	/// <exclude/>
	public class SendEmailHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SendEmailHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SendEmailHandlerSchema(SendEmailHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cddda84f-607c-4d91-a668-52f2fe181138");
			Name = "SendEmailHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,203,75,204,77,45,46,72,76,78,85,8,73,45,42,74,44,206,79,43,209,115,206,207,75,203,76,47,45,74,44,201,204,207,227,229,170,230,229,226,4,34,229,162,212,116,32,95,193,57,39,177,184,216,74,33,56,53,47,197,53,55,49,51,199,35,49,47,37,39,181,136,151,11,168,166,160,52,41,39,51,89,33,25,164,4,139,10,206,106,144,42,32,93,11,38,149,129,10,32,134,242,114,129,69,128,0,0,91,108,13,95,144,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cddda84f-607c-4d91-a668-52f2fe181138"));
		}

		#endregion

	}

	#endregion

}

