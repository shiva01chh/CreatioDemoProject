namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TemplateContentSchema

	/// <exclude/>
	public class TemplateContentSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TemplateContentSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TemplateContentSchema(TemplateContentSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5dae23e0-f39b-4db5-9d47-a9196b501f89");
			Name = "TemplateContent";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,203,10,194,64,12,69,215,22,250,15,1,247,237,222,138,155,34,174,132,130,254,192,88,99,29,104,103,74,146,46,164,248,239,206,195,138,175,133,102,51,36,185,119,238,153,49,170,67,238,85,141,176,71,34,197,246,36,89,105,205,73,55,3,41,209,214,100,229,122,183,181,71,108,57,77,198,52,73,147,217,156,176,113,11,40,91,197,188,112,190,174,111,149,160,115,9,26,9,146,60,207,97,201,67,215,41,186,172,238,189,175,253,25,65,238,122,168,163,33,155,244,249,147,161,31,14,173,174,161,246,17,159,9,179,8,242,32,169,200,246,72,162,209,225,84,193,25,247,239,24,97,176,65,97,176,4,236,79,57,191,112,124,130,76,36,44,164,77,51,105,97,132,6,165,240,119,20,112,253,39,204,184,255,254,41,201,11,191,197,204,209,28,227,179,67,31,167,175,195,48,115,117,3,26,135,156,209,220,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5dae23e0-f39b-4db5-9d47-a9196b501f89"));
		}

		#endregion

	}

	#endregion

}

