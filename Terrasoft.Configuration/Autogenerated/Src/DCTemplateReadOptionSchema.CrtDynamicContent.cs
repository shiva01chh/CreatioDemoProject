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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,79,75,195,64,16,197,207,9,228,59,12,120,45,137,122,180,182,32,109,197,147,66,173,39,241,48,77,38,97,97,255,177,51,11,134,226,119,119,55,137,208,131,123,218,55,111,230,55,195,179,104,136,61,182,4,39,10,1,217,245,82,239,156,237,213,16,3,138,114,182,222,143,22,141,106,83,81,200,74,85,94,170,178,136,172,236,0,239,35,11,153,117,85,166,202,77,160,33,117,195,193,70,243,0,251,221,137,140,215,40,116,36,236,222,124,6,77,109,77,211,192,35,71,99,48,140,219,69,207,54,3,165,81,232,93,128,144,102,24,100,33,212,240,193,196,128,12,189,198,129,235,63,74,115,133,249,124,206,214,87,250,249,120,214,170,157,89,255,95,81,92,166,75,138,87,103,9,54,112,187,202,226,240,221,234,216,209,147,72,80,231,40,105,223,6,238,174,157,35,249,196,197,23,49,122,73,34,117,220,79,164,159,57,0,178,221,156,65,150,169,150,223,47,139,109,233,160,94,1,0,0 };
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

