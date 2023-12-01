namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AccountLanguageIteratorSchema

	/// <exclude/>
	public class AccountLanguageIteratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AccountLanguageIteratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AccountLanguageIteratorSchema(AccountLanguageIteratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e46324f1-8f69-4be3-9d3a-1af95158ae46");
			Name = "AccountLanguageIterator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d5fe5418-b108-401a-ba83-ff1213a966db");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,77,107,195,48,12,134,207,41,244,63,136,244,210,194,72,238,253,130,173,187,20,118,40,99,61,141,29,84,79,9,6,199,41,254,96,116,163,255,125,178,147,126,36,165,208,128,9,150,94,63,122,37,105,172,200,238,81,16,124,144,49,104,235,194,101,171,90,23,178,244,6,157,172,245,112,240,55,28,36,222,74,93,118,36,134,102,195,1,103,70,134,74,150,193,74,161,181,83,120,22,162,246,218,189,161,46,61,150,180,118,196,152,218,68,105,158,231,48,183,190,170,208,28,150,237,253,36,128,130,143,146,214,133,58,187,3,96,195,1,213,130,108,118,2,228,87,132,189,223,41,41,64,132,218,247,74,195,20,94,208,210,173,163,36,52,118,241,95,107,235,140,23,156,226,54,54,17,28,93,223,216,110,124,107,233,36,42,249,75,22,52,253,128,228,215,168,121,140,117,193,98,34,16,134,138,69,122,199,83,154,47,51,56,179,243,62,124,190,71,131,21,104,222,205,34,245,150,12,155,211,36,194,58,210,229,150,239,32,206,129,108,158,71,117,124,220,206,227,78,213,241,182,131,130,46,121,18,0,201,20,118,60,172,113,47,5,113,84,201,9,248,238,21,183,189,136,141,175,175,131,159,95,173,50,9,169,141,145,21,49,197,161,112,107,221,51,21,228,61,67,147,167,203,219,87,42,208,171,7,212,199,89,248,29,155,85,141,72,127,55,251,140,247,38,218,13,114,140,191,127,94,18,192,122,247,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e46324f1-8f69-4be3-9d3a-1af95158ae46"));
		}

		#endregion

	}

	#endregion

}

