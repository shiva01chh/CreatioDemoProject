namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateReadOptionSchema

	/// <exclude/>
	public class DCTemplateReadOptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateReadOptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateReadOptionSchema(DCTemplateReadOptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f88a83ea-c4fe-4ac2-870c-f6abbd2f69d5");
			Name = "DCTemplateReadOption";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,77,75,195,64,16,134,207,9,228,63,12,120,45,137,122,180,182,32,109,197,147,66,173,39,241,48,77,38,97,97,63,194,206,44,24,138,255,221,201,135,208,131,123,218,119,222,153,103,134,215,163,35,238,177,38,56,81,140,200,161,149,114,23,124,107,186,20,81,76,240,229,126,240,232,76,173,69,33,47,69,126,41,242,44,177,241,29,188,15,44,228,214,69,174,149,155,72,157,118,195,193,39,247,0,251,221,137,92,111,81,232,72,216,188,245,35,104,106,171,170,10,30,57,57,135,113,216,46,122,182,25,72,71,161,13,17,162,206,48,200,66,40,225,131,137,1,25,90,139,29,151,127,148,234,10,243,249,60,90,95,250,235,211,217,154,122,102,253,127,69,118,153,46,201,94,131,39,216,192,237,106,20,135,239,218,166,134,158,68,162,57,39,209,125,27,184,187,118,142,212,43,23,95,196,217,37,9,237,184,159,72,63,115,0,228,155,57,131,81,106,77,223,47,204,131,229,236,93,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f88a83ea-c4fe-4ac2-870c-f6abbd2f69d5"));
		}

		#endregion

	}

	#endregion

}

