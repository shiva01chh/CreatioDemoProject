namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailTemplateUserTaskMLangBinderSchema

	/// <exclude/>
	public class EmailTemplateUserTaskMLangBinderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailTemplateUserTaskMLangBinderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailTemplateUserTaskMLangBinderSchema(EmailTemplateUserTaskMLangBinderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0b12cd08-0384-44fd-b87b-86ac638b898a");
			Name = "EmailTemplateUserTaskMLangBinder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6b752d82-945c-4729-b067-d3f384b1bc2d");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,223,107,194,48,16,199,159,21,252,31,14,247,226,96,180,239,42,194,20,7,130,178,193,28,123,190,182,103,23,214,36,37,185,200,68,246,191,239,76,219,161,210,188,132,220,247,123,159,251,17,131,154,124,141,57,193,158,156,67,111,15,156,172,172,57,168,50,56,100,101,205,104,120,30,13,7,193,43,83,222,88,28,37,47,152,179,117,138,252,172,199,241,73,153,184,180,182,70,84,209,31,28,149,130,131,85,133,222,79,97,173,81,85,31,158,220,30,253,247,110,139,166,92,42,83,144,139,222,52,77,97,238,131,214,232,78,139,246,29,19,128,73,215,21,50,65,144,84,96,201,5,29,42,86,149,0,2,150,4,249,5,15,89,100,37,29,42,189,98,213,33,171,84,222,250,34,116,223,50,123,186,153,194,115,93,175,143,100,120,171,60,147,33,183,68,79,66,57,199,62,255,135,218,17,127,217,66,198,122,139,244,70,108,43,217,163,236,68,21,4,71,171,10,120,53,66,124,103,116,60,233,208,178,110,166,31,134,188,185,31,225,178,240,193,32,147,74,201,149,189,147,103,81,141,107,108,62,224,148,92,154,157,111,182,237,14,54,76,242,117,214,61,245,143,119,111,91,76,198,189,190,113,83,233,183,157,148,76,209,12,27,223,77,244,54,40,49,57,127,121,84,12,122,81,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0b12cd08-0384-44fd-b87b-86ac638b898a"));
		}

		#endregion

	}

	#endregion

}

