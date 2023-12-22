namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: PortalMessagePublisherSchema

	/// <exclude/>
	public class PortalMessagePublisherSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public PortalMessagePublisherSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public PortalMessagePublisherSchema(PortalMessagePublisherSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("6244c208-b197-4059-8d43-d8de62679b3c");
			Name = "PortalMessagePublisher";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4b8eb560-035d-46d4-af40-51e85d9668c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,65,78,195,48,16,60,39,82,254,176,42,151,34,85,125,64,10,28,104,129,19,168,82,225,1,91,119,155,90,114,156,106,215,62,68,17,127,103,237,84,130,80,176,44,217,51,158,157,241,110,20,235,27,216,245,18,168,93,174,59,231,200,4,219,121,89,190,144,39,182,102,85,149,49,75,222,137,25,165,59,6,85,49,41,93,149,30,91,146,51,26,154,60,250,163,109,34,99,114,169,202,161,42,11,221,55,76,141,98,88,59,20,169,97,219,113,64,247,74,34,216,208,54,238,157,149,19,113,178,44,206,9,25,48,73,248,143,14,106,120,68,161,235,242,98,200,22,223,105,218,71,224,104,66,199,154,153,141,71,193,37,228,111,251,249,135,16,107,169,31,39,1,113,2,23,176,177,249,130,220,223,169,187,142,102,1,227,249,0,228,131,13,253,179,37,119,144,13,6,188,77,97,69,13,123,253,238,252,183,207,149,24,134,44,127,202,252,206,156,168,197,55,157,48,220,195,108,242,211,217,42,233,62,47,189,146,63,140,237,102,60,178,83,82,185,159,235,11,195,39,203,199,242,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("6244c208-b197-4059-8d43-d8de62679b3c"));
		}

		#endregion

	}

	#endregion

}

