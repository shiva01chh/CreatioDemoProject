namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailHeaderModelSchema

	/// <exclude/>
	public class EmailHeaderModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailHeaderModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailHeaderModelSchema(EmailHeaderModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("2d6eaf3b-23d3-462e-bed5-b0973014733e");
			Name = "EmailHeaderModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("05bb6355-677b-44f1-8326-8d7c3ae660cf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,146,193,110,131,48,12,134,207,69,226,29,44,245,14,247,50,237,210,77,219,101,29,218,250,2,129,26,154,45,36,40,78,14,21,218,187,207,73,70,133,166,30,218,13,33,33,59,191,253,127,250,137,22,3,210,40,90,132,61,90,43,200,116,174,216,26,221,201,222,91,225,164,209,121,54,229,217,202,147,212,61,188,159,200,225,80,113,205,239,218,98,207,231,176,85,130,104,3,143,131,144,234,25,197,1,237,139,57,160,202,51,214,148,101,9,119,228,135,65,216,211,253,79,253,134,163,69,66,237,8,30,246,175,96,58,56,198,41,130,206,88,112,71,132,198,171,79,192,176,15,216,110,84,194,97,49,47,43,23,219,70,223,40,217,66,27,0,46,248,175,166,200,112,6,173,173,25,209,58,137,76,91,199,209,116,254,27,50,54,158,144,249,152,135,194,151,105,121,45,104,206,170,56,79,44,73,102,20,114,54,230,20,245,59,150,195,4,61,186,42,172,169,224,235,70,191,24,193,13,134,49,130,191,57,134,216,83,226,228,155,15,108,221,117,182,73,251,95,75,190,15,233,10,92,101,90,207,234,75,182,107,14,34,253,238,88,167,238,178,201,157,240,124,3,91,13,150,118,247,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("2d6eaf3b-23d3-462e-bed5-b0973014733e"));
		}

		#endregion

	}

	#endregion

}

