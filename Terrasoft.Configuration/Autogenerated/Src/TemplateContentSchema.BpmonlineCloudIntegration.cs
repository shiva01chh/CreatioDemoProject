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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,205,10,194,48,16,132,207,6,250,14,11,222,219,187,138,151,34,158,132,130,190,64,172,107,13,180,73,217,221,30,68,124,119,243,99,197,191,131,230,18,50,59,147,249,18,171,59,228,94,215,8,59,36,210,236,142,146,151,206,30,77,51,144,22,227,108,94,174,182,27,119,192,150,51,117,201,84,166,38,83,194,198,15,160,108,53,243,204,231,186,190,213,130,62,37,104,37,90,138,162,128,5,15,93,167,233,188,188,159,195,218,157,16,228,238,135,58,5,242,209,95,60,5,250,97,223,154,26,234,80,241,217,48,73,32,15,146,138,92,143,36,6,61,78,21,147,105,254,142,17,133,53,10,131,35,224,176,203,233,133,227,19,100,36,97,33,99,155,209,11,23,104,80,230,225,142,57,92,255,41,179,254,191,127,106,10,198,111,53,83,180,135,244,236,120,78,234,171,24,53,165,110,136,155,138,40,219,1,0,0 };
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

