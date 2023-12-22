namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseQueueMessageSchema

	/// <exclude/>
	public class BaseQueueMessageSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseQueueMessageSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseQueueMessageSchema(BaseQueueMessageSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("04c48118-f957-49c4-a4ac-39fa34b1c523");
			Name = "BaseQueueMessage";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("097cd95f-c972-4e9b-ab53-9b1cae85bae7");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,77,79,195,48,12,134,207,155,180,255,96,105,23,184,180,119,6,28,40,72,128,4,26,48,184,160,29,188,206,45,17,77,50,98,71,99,154,248,239,36,233,24,29,76,203,33,146,63,94,251,177,19,131,154,120,129,37,193,132,156,67,182,149,100,133,53,149,170,189,67,81,214,12,250,235,65,191,231,89,153,26,158,86,44,164,71,91,251,158,150,98,77,210,220,178,53,33,16,66,67,71,117,208,65,209,32,243,9,92,32,211,131,39,79,119,196,140,53,165,156,60,207,225,148,189,214,232,86,231,27,59,38,130,110,147,160,178,14,62,162,42,251,201,206,59,233,11,63,107,84,9,56,99,113,88,10,148,177,213,191,78,208,54,159,32,191,239,2,244,214,9,98,75,58,118,118,65,78,20,5,220,113,42,221,198,255,82,38,199,21,139,210,40,52,7,50,162,162,8,74,235,141,100,91,69,151,180,247,26,23,115,83,27,235,104,26,237,13,186,50,242,91,233,209,46,185,136,53,96,13,53,201,8,56,94,95,7,32,158,153,92,168,17,182,164,211,35,129,173,64,222,8,74,239,92,192,2,31,226,135,128,54,19,175,142,46,169,66,223,200,11,54,158,174,209,204,155,248,172,103,176,207,157,181,83,28,119,199,8,251,143,130,136,19,62,141,208,231,222,17,134,100,230,237,170,147,221,122,119,157,201,215,61,223,107,180,46,195,152,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("04c48118-f957-49c4-a4ac-39fa34b1c523"));
		}

		#endregion

	}

	#endregion

}

