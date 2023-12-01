namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: AutoSubmittedHandlerSchema

	/// <exclude/>
	public class AutoSubmittedHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public AutoSubmittedHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public AutoSubmittedHandlerSchema(AutoSubmittedHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e");
			Name = "AutoSubmittedHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,146,77,107,227,64,12,134,207,14,228,63,8,239,37,129,214,190,111,211,64,8,91,218,67,63,216,132,222,101,91,137,103,59,31,174,52,211,18,202,254,247,142,199,78,63,178,172,15,54,35,235,125,164,119,36,139,134,164,195,154,96,75,204,40,110,231,139,181,179,59,181,15,140,94,57,59,157,188,77,39,89,16,101,247,176,57,136,39,115,49,157,196,72,89,150,176,144,96,12,242,97,57,158,87,80,107,20,1,223,162,7,166,142,73,200,122,1,132,22,109,163,137,193,237,32,95,5,239,206,55,161,50,202,123,106,114,232,216,117,196,254,0,202,2,25,84,26,90,194,134,184,56,86,41,191,148,233,66,165,85,61,214,233,73,31,160,235,177,196,79,184,185,78,250,135,145,59,254,136,226,183,212,121,246,131,105,31,157,253,39,15,110,201,84,196,50,228,158,218,76,129,91,242,173,107,160,110,169,126,234,221,18,188,160,14,212,187,27,90,255,244,116,234,182,248,128,150,167,212,69,135,140,6,108,156,200,101,158,128,249,242,241,200,253,231,214,78,10,21,139,50,201,63,105,76,62,176,149,229,239,225,11,91,142,36,181,27,91,85,2,249,157,203,33,122,134,43,212,18,139,68,31,252,170,132,34,234,168,237,97,227,141,87,206,105,88,247,142,103,174,250,67,181,31,64,115,232,215,35,203,6,5,136,231,184,40,197,175,231,16,153,179,148,81,108,221,38,69,103,243,51,88,163,80,92,47,241,82,172,180,118,175,212,124,155,225,113,20,201,246,89,2,103,131,120,237,76,244,167,196,217,226,158,27,101,81,223,236,173,99,234,129,243,139,62,243,239,56,92,178,205,48,223,120,138,177,108,58,137,239,248,188,3,21,79,157,72,234,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4504d36d-abab-4979-82a1-10f52e7b8f0e"));
		}

		#endregion

	}

	#endregion

}

