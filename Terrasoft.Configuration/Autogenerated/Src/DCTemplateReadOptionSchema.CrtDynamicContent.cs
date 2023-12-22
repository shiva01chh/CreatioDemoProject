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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,144,77,75,196,64,12,134,207,45,244,63,4,188,74,171,30,213,93,144,221,21,79,10,235,122,18,15,217,54,45,3,243,81,38,25,176,44,254,119,211,15,161,7,231,52,111,222,228,73,120,61,58,226,30,107,130,19,197,136,28,90,41,119,193,183,166,75,17,197,4,95,238,7,143,206,212,90,20,242,82,228,151,34,207,18,27,223,193,251,192,66,238,161,200,181,114,21,169,211,110,56,248,228,238,97,191,59,145,235,45,10,29,9,155,183,126,4,77,109,85,85,193,35,39,231,48,14,219,69,207,54,3,233,40,180,33,66,212,25,6,89,8,37,124,48,49,32,67,107,177,227,242,143,82,173,48,159,207,163,245,165,191,62,157,173,169,103,214,255,87,100,151,233,146,236,53,120,130,13,220,92,143,226,240,93,219,212,208,147,72,52,231,36,186,111,3,183,107,231,72,189,114,241,69,156,93,146,208,142,187,137,244,51,7,64,190,153,51,24,165,214,214,239,23,123,162,245,102,102,1,0,0 };
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

