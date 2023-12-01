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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,82,205,106,195,48,12,62,39,144,119,16,244,158,220,215,49,24,41,236,86,114,216,11,168,142,146,137,37,118,176,229,193,86,250,238,115,236,46,107,247,71,87,95,140,62,235,251,177,144,198,145,220,132,138,224,145,172,69,103,58,41,107,163,59,238,189,69,97,163,139,124,95,228,69,14,225,172,44,245,1,129,122,64,231,110,224,94,137,199,129,223,168,13,132,150,83,115,234,172,170,10,110,157,31,71,180,175,119,159,80,36,130,50,90,144,181,3,214,157,177,99,116,1,220,25,47,128,74,248,133,82,135,146,242,68,172,58,87,155,252,110,96,5,42,10,254,24,36,139,177,179,236,35,116,99,205,68,86,152,66,242,38,178,211,251,151,168,9,120,32,113,96,44,184,249,150,39,2,29,198,4,166,131,64,35,237,168,92,152,213,41,245,152,202,137,101,221,67,131,234,25,123,218,206,212,61,244,36,235,89,111,13,135,255,24,43,227,181,204,206,223,70,243,71,0,14,148,101,20,117,84,184,58,64,139,66,149,112,250,190,159,230,242,162,223,47,254,155,192,184,222,254,56,112,104,125,138,114,145,247,198,211,111,174,43,210,109,218,136,88,31,150,221,62,195,35,28,206,59,233,10,160,48,30,3,0,0 };
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

