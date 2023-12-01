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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,80,65,106,195,48,16,60,219,224,63,44,233,37,133,144,7,56,109,15,73,218,158,90,2,105,31,176,81,54,142,64,150,195,174,116,48,166,127,239,74,14,20,55,173,16,72,51,154,157,209,110,20,235,27,216,247,18,168,93,110,58,231,200,4,219,121,89,190,146,39,182,102,85,149,49,75,62,136,25,165,59,5,85,49,41,93,149,30,91,146,11,26,154,60,250,147,109,34,99,114,169,202,161,42,11,221,119,76,141,98,216,56,20,169,97,215,113,64,247,70,34,216,208,46,30,156,149,51,113,178,44,46,9,25,48,73,248,143,14,106,88,163,208,109,121,49,100,139,159,52,237,35,112,52,161,99,205,204,198,163,224,26,242,183,253,252,83,136,181,212,143,147,128,56,129,11,216,218,124,65,238,31,212,93,71,179,128,241,124,2,242,193,134,254,197,146,59,202,22,3,222,167,176,162,134,131,126,119,254,219,231,70,12,67,150,63,103,126,111,206,212,226,187,78,24,30,97,54,249,233,108,149,116,95,215,94,201,31,199,118,51,30,217,41,169,156,174,111,233,188,11,32,233,1,0,0 };
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

