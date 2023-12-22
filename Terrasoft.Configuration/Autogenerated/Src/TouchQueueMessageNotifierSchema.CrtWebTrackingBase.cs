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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,84,219,78,227,48,16,125,46,18,255,48,202,190,20,105,213,188,211,203,195,178,8,241,0,234,210,242,1,174,51,105,13,181,157,29,219,43,85,21,255,206,216,110,32,141,90,180,34,82,36,123,46,103,206,156,177,109,132,70,215,8,137,176,68,34,225,108,237,71,55,214,212,106,29,72,120,101,205,229,197,254,242,98,16,156,50,107,88,236,156,71,61,254,216,119,83,8,217,206,158,31,132,107,78,131,155,173,112,238,26,150,54,200,205,159,128,1,31,208,57,177,198,71,235,85,173,144,82,112,89,150,48,113,65,107,65,187,217,97,159,18,193,91,48,49,114,7,98,101,131,231,61,227,192,223,8,4,58,35,65,67,86,242,50,50,33,116,97,235,221,168,197,44,59,160,77,88,109,149,4,153,112,207,242,129,107,248,37,28,158,166,58,216,39,186,159,205,89,227,60,5,233,45,113,143,243,84,32,71,244,59,202,45,125,134,67,205,255,196,33,130,36,172,167,197,89,62,69,57,203,148,71,31,176,101,31,119,210,8,18,26,12,207,112,90,4,135,196,133,12,202,56,182,98,54,41,147,55,5,31,36,56,91,108,248,124,148,12,199,88,87,172,205,138,181,25,246,205,123,120,59,232,130,166,202,210,28,235,52,39,235,57,24,171,19,34,41,179,65,82,190,178,178,204,28,219,88,176,255,248,92,169,10,129,69,139,195,109,89,62,114,159,48,157,65,22,109,110,149,241,174,24,127,11,242,9,181,50,21,175,22,114,131,90,180,200,81,73,91,15,19,254,213,248,235,222,30,208,111,108,117,106,252,255,65,227,46,168,10,238,208,47,194,234,133,93,247,213,48,30,190,165,112,175,221,241,180,39,157,149,142,56,3,66,31,200,164,228,209,173,110,252,46,94,197,193,219,183,20,224,226,89,87,153,174,249,111,116,146,84,19,151,95,82,249,217,230,219,6,243,3,241,148,174,94,143,98,207,219,229,217,211,51,91,143,141,201,214,249,222,1,254,185,174,140,165,4,0,0 };
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

