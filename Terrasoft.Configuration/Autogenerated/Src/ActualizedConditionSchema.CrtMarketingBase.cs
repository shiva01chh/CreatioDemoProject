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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,201,106,195,48,16,61,219,224,127,24,200,221,186,55,165,80,28,232,45,248,208,31,152,200,99,87,212,150,140,52,42,180,33,255,94,45,169,155,116,35,141,46,98,158,230,45,26,70,227,68,110,70,73,240,72,214,162,51,61,215,141,209,189,26,188,69,86,70,87,229,190,42,171,18,194,89,89,26,2,2,205,136,206,221,192,189,100,143,163,122,163,46,16,58,149,155,115,167,16,2,110,157,159,38,180,175,119,159,80,34,130,52,154,81,105,7,74,247,198,78,201,5,112,103,60,3,74,86,47,148,59,36,215,39,98,226,92,109,246,187,81,73,144,73,240,199,32,69,138,93,20,31,161,91,107,102,178,172,40,36,111,19,59,191,127,137,154,129,7,98,7,198,130,139,55,63,17,232,48,38,48,61,4,26,105,71,245,194,20,167,212,99,42,199,86,233,1,90,148,207,56,208,54,82,247,48,16,175,163,222,26,14,255,49,150,198,107,142,206,223,70,243,71,0,21,40,203,40,154,164,112,117,128,14,153,4,171,252,125,63,199,242,162,223,47,254,155,192,184,222,254,56,112,232,124,142,114,145,247,198,211,111,174,43,210,93,222,136,84,31,150,221,62,195,19,28,207,59,69,252,49,235,31,3,0,0 };
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

