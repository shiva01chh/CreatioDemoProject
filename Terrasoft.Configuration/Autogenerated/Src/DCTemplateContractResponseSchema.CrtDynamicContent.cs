namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DCTemplateContractResponseSchema

	/// <exclude/>
	public class DCTemplateContractResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DCTemplateContractResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DCTemplateContractResponseSchema(DCTemplateContractResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3fd21c44-491c-46a0-85b5-eea55b81914b");
			Name = "DCTemplateContractResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ad993b20-8db8-48d6-9762-5a83fb4975c6");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,80,59,79,195,48,16,158,169,212,255,112,42,3,155,179,183,208,165,89,145,170,182,27,98,112,221,75,106,20,219,145,125,6,133,138,255,206,197,121,40,165,2,145,193,138,63,223,125,47,43,13,134,90,42,132,3,122,47,131,43,72,108,156,45,116,25,189,36,237,172,200,27,43,141,86,12,18,90,154,207,46,243,217,93,12,218,150,176,111,2,161,17,187,104,73,27,20,123,244,90,86,250,51,173,173,198,169,255,241,138,92,146,108,255,189,84,196,203,188,126,239,177,228,65,216,84,50,132,37,228,155,3,154,186,146,132,195,216,142,157,59,27,48,77,103,89,6,143,33,26,35,125,179,238,239,195,0,168,150,2,62,206,90,157,65,241,182,212,54,240,52,242,139,199,226,105,113,203,189,200,214,208,179,72,123,130,34,90,213,186,230,124,212,128,43,128,206,56,37,184,138,198,69,188,107,133,131,58,83,137,209,16,69,207,210,212,171,61,4,208,182,112,222,116,149,12,49,178,73,142,151,105,49,175,12,212,241,88,105,213,71,250,189,20,88,194,95,166,152,232,146,122,27,107,222,122,87,163,39,141,220,245,54,105,116,239,63,139,77,192,160,154,218,108,101,193,29,223,80,145,24,55,166,25,186,16,207,104,142,232,219,8,67,134,91,247,112,3,92,160,68,90,65,104,143,175,222,49,218,83,103,58,221,59,244,26,100,108,250,125,3,231,98,6,141,230,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3fd21c44-491c-46a0-85b5-eea55b81914b"));
		}

		#endregion

	}

	#endregion

}

