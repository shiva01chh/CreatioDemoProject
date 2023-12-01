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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,146,77,79,195,48,12,134,207,155,180,255,96,105,23,184,180,119,6,28,40,72,128,4,26,48,184,160,29,188,214,45,17,77,50,98,71,99,154,248,239,36,233,24,27,76,203,33,146,63,94,251,177,19,131,154,120,142,37,193,132,156,67,182,181,100,133,53,181,106,188,67,81,214,12,250,171,65,191,231,89,153,6,158,150,44,164,71,27,251,158,22,98,77,210,220,178,53,33,16,66,67,71,77,208,65,209,34,243,9,92,32,211,131,39,79,119,196,140,13,165,156,60,207,225,148,189,214,232,150,231,107,59,38,130,238,146,160,182,14,62,162,42,251,201,206,183,210,231,126,214,170,18,112,198,226,176,20,40,99,171,127,157,160,107,62,65,126,223,5,232,173,18,196,134,116,236,236,156,156,40,10,184,227,84,186,139,255,165,76,142,43,22,165,81,168,2,50,162,162,8,74,235,141,100,27,197,54,105,239,53,46,230,166,49,214,209,52,218,107,116,101,228,183,210,163,93,112,17,107,192,10,26,146,17,112,188,190,14,64,60,51,185,80,35,108,73,167,71,2,91,131,188,17,148,222,185,128,5,62,196,15,1,173,39,94,30,93,82,141,190,149,23,108,61,93,163,169,218,248,172,103,176,207,157,117,83,28,111,143,17,246,31,5,17,39,124,26,161,207,189,35,12,201,84,221,170,147,221,121,119,157,201,23,206,55,106,45,160,232,143,2,0,0 };
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

