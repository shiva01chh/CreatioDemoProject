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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,80,59,79,195,48,16,158,169,212,255,112,42,3,155,179,183,208,165,89,145,170,182,27,98,112,221,75,106,20,219,145,125,6,133,138,255,206,57,47,165,84,32,50,88,241,231,187,239,101,165,193,80,75,133,112,64,239,101,112,5,137,141,179,133,46,163,151,164,157,21,121,99,165,209,138,65,66,75,243,217,101,62,187,139,65,219,18,246,77,32,52,98,23,45,105,131,98,143,94,203,74,127,182,107,171,113,234,127,188,34,151,36,211,191,151,138,120,153,215,239,61,150,60,8,155,74,134,176,132,124,115,64,83,87,146,112,24,219,177,115,103,3,182,211,89,150,193,99,136,198,72,223,172,251,251,48,0,42,81,192,199,89,171,51,40,222,150,218,6,158,70,126,241,88,60,45,110,185,23,217,26,122,22,105,79,80,68,171,146,107,206,71,13,184,2,232,140,83,130,171,104,92,196,187,86,56,168,51,149,24,13,81,244,44,77,189,218,67,0,109,11,231,77,87,201,16,35,155,228,120,153,22,243,202,64,29,143,149,86,125,164,223,75,129,37,252,101,138,137,46,109,111,99,205,91,239,106,244,164,145,187,222,182,26,221,251,207,98,91,96,80,109,219,76,178,224,142,111,168,72,140,27,211,12,93,136,103,52,71,244,41,194,144,225,214,61,220,0,23,40,145,86,16,210,241,213,59,70,123,234,76,183,247,14,189,6,25,75,223,55,190,145,76,137,222,2,0,0 };
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

