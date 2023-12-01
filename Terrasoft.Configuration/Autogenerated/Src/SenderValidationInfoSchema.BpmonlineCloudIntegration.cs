namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SenderValidationInfoSchema

	/// <exclude/>
	public class SenderValidationInfoSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SenderValidationInfoSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SenderValidationInfoSchema(SenderValidationInfoSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f6ab86a0-e08a-4fdf-9955-a869f72bbafb");
			Name = "SenderValidationInfo";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,77,107,195,48,12,61,39,144,255,32,232,61,185,175,165,151,82,202,96,27,101,41,221,217,75,148,204,224,216,193,114,58,74,217,127,159,226,164,89,215,117,253,202,197,88,214,123,122,146,30,209,162,66,170,69,134,176,66,107,5,153,194,197,51,163,11,89,54,86,56,105,116,60,155,167,207,38,71,69,81,184,139,194,160,33,169,75,72,183,228,176,226,76,165,48,107,211,40,94,160,70,43,179,113,20,114,214,200,98,201,81,152,41,65,244,0,41,234,28,237,90,40,153,123,210,71,93,24,159,151,36,9,76,168,169,42,97,183,211,254,254,138,181,69,66,237,8,248,172,153,27,161,48,22,200,147,192,102,96,137,247,4,201,1,67,221,188,43,153,65,214,22,254,167,110,176,243,181,7,145,75,107,106,180,78,34,43,93,122,120,247,126,44,206,7,22,200,186,188,26,62,221,7,194,167,53,60,16,172,132,84,4,74,146,139,7,108,114,12,158,176,248,6,135,235,234,2,252,39,187,239,234,137,223,39,228,44,175,96,10,111,45,114,238,129,109,28,118,80,162,27,183,194,198,240,117,75,7,253,68,49,191,191,139,75,20,231,59,89,239,209,231,187,25,241,54,187,149,249,123,23,61,12,6,127,157,199,187,221,72,246,64,231,4,207,127,141,241,122,175,245,205,116,238,107,157,206,13,206,211,229,101,227,157,44,123,141,239,130,224,250,189,181,51,6,83,252,22,251,207,222,78,141,253,64,28,29,207,251,22,29,60,17,208,252,31,57,95,186,171,58,76,230,133,1,119,45,57,10,125,140,191,111,103,138,11,115,188,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f6ab86a0-e08a-4fdf-9955-a869f72bbafb"));
		}

		#endregion

	}

	#endregion

}

