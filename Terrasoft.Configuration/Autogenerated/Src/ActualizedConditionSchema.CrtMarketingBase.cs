namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ActualizedConditionSchema

	/// <exclude/>
	public class ActualizedConditionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ActualizedConditionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ActualizedConditionSchema(ActualizedConditionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d465fc2e-b275-4e5b-aa8c-bb3916adc374");
			Name = "ActualizedCondition";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c92d8fca-4a0d-4385-86d2-4f5717aa816e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,205,106,195,48,12,62,39,208,119,16,244,158,220,215,49,24,41,236,86,114,216,11,168,142,146,137,37,118,176,229,193,86,250,238,115,236,46,75,247,71,87,95,140,62,235,251,177,144,198,129,220,136,138,224,145,172,69,103,90,41,42,163,91,238,188,69,97,163,87,249,97,149,175,114,8,103,109,169,11,8,84,61,58,119,3,247,74,60,246,252,70,77,32,52,156,154,83,103,89,150,112,235,252,48,160,125,189,251,132,34,17,148,209,130,172,29,176,110,141,29,162,11,224,222,120,1,84,194,47,148,58,148,20,11,177,242,92,109,244,251,158,21,168,40,248,99,144,44,198,206,178,143,208,181,53,35,89,97,10,201,235,200,78,239,95,162,38,224,129,196,129,177,224,166,91,158,8,116,24,19,152,22,2,141,180,163,98,102,150,75,234,41,149,19,203,186,131,26,213,51,118,180,155,168,7,232,72,54,147,222,6,142,255,49,86,198,107,153,156,191,141,230,143,0,28,40,243,40,170,168,112,117,128,6,133,74,225,244,125,63,78,229,69,191,159,253,183,129,113,189,253,105,224,208,248,20,229,34,239,173,167,223,92,215,164,155,180,17,177,62,206,187,125,134,71,120,121,222,1,236,125,40,145,39,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d465fc2e-b275-4e5b-aa8c-bb3916adc374"));
		}

		#endregion

	}

	#endregion

}

