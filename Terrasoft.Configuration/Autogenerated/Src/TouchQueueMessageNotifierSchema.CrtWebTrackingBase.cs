namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TouchQueueMessageNotifierSchema

	/// <exclude/>
	public class TouchQueueMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TouchQueueMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TouchQueueMessageNotifierSchema(TouchQueueMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("38be02db-3e45-4885-b616-878b6f010bac");
			Name = "TouchQueueMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d23d224d-d671-416d-91d0-80132a374d7a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,219,106,27,49,16,125,118,32,255,48,108,95,28,40,222,247,248,242,208,180,132,62,36,184,177,251,1,178,118,214,86,226,149,182,51,82,193,152,252,123,71,146,55,177,23,59,148,44,44,72,115,57,115,230,140,36,171,26,228,86,105,132,37,18,41,118,181,31,221,57,91,155,117,32,229,141,179,215,87,251,235,171,65,96,99,215,176,216,177,199,102,252,182,63,78,33,20,187,120,190,16,174,37,13,238,182,138,249,22,150,46,232,205,175,128,1,31,144,89,173,241,209,121,83,27,164,20,92,150,37,76,56,52,141,162,221,236,176,79,137,224,29,216,24,185,3,181,114,193,203,94,112,224,79,4,130,38,35,65,75,78,203,50,50,33,228,176,245,60,234,48,203,35,208,54,172,182,70,131,78,184,23,249,192,45,124,83,140,231,169,14,246,137,238,123,115,206,178,167,160,189,35,233,113,158,10,228,136,126,71,185,165,247,112,168,229,159,48,34,104,194,122,90,92,228,83,148,179,76,121,244,6,91,246,113,39,173,34,213,128,149,25,78,139,192,72,82,200,162,142,99,43,102,147,50,121,83,240,65,130,139,197,134,191,79,146,225,20,235,70,180,89,137,54,195,190,121,15,175,7,93,208,86,89,154,83,157,230,228,188,4,99,117,70,36,99,55,72,198,87,78,151,153,99,23,11,238,175,156,43,83,33,136,104,113,184,29,203,71,233,19,166,51,200,162,205,157,177,158,139,241,167,32,159,176,49,182,146,213,66,111,176,81,29,114,84,210,213,195,132,127,51,254,184,183,7,244,27,87,157,27,255,127,208,184,15,166,130,123,244,139,176,122,22,215,207,106,24,15,223,82,241,203,241,120,186,147,46,74,71,156,1,161,15,100,83,242,232,71,211,250,93,188,138,131,215,79,41,32,197,179,174,58,93,243,239,200,154,76,27,151,31,82,249,218,229,187,22,243,3,241,148,174,94,143,98,207,123,204,179,167,103,182,158,26,147,77,190,127,151,233,129,157,157,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("38be02db-3e45-4885-b616-878b6f010bac"));
		}

		#endregion

	}

	#endregion

}

