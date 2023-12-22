namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CheckedEmailResponseSchema

	/// <exclude/>
	public class CheckedEmailResponseSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CheckedEmailResponseSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CheckedEmailResponseSchema(CheckedEmailResponseSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d3507f4f-1914-4114-8a7c-cc67545f380a");
			Name = "CheckedEmailResponse";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("5f5fe385-d25b-4c17-9585-cfaff007abaf");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,187,110,194,64,16,69,107,144,248,135,17,105,146,198,238,3,161,113,16,74,65,132,32,93,148,98,89,6,179,202,62,172,153,221,130,160,252,123,198,15,136,131,68,220,237,221,115,103,142,109,175,28,114,165,52,194,27,18,41,14,251,152,21,193,239,77,153,72,69,19,124,86,204,55,107,65,130,103,228,209,240,52,26,14,18,27,95,194,230,200,17,157,192,214,162,174,73,206,22,232,145,140,158,92,51,235,228,163,113,152,109,228,86,89,243,213,12,254,165,254,217,188,12,59,180,44,168,192,119,132,165,196,80,88,197,252,8,197,1,245,39,238,230,78,25,123,22,108,184,60,207,97,202,201,57,69,199,89,119,94,99,69,200,232,35,67,60,32,232,182,11,88,151,129,186,54,236,41,56,144,173,217,121,74,222,27,243,254,172,162,18,193,72,74,199,15,9,170,180,181,70,131,174,117,110,216,12,78,141,209,69,125,69,161,66,138,6,197,127,213,212,219,251,107,229,38,88,160,216,6,2,198,206,90,60,147,141,217,165,208,183,107,245,150,232,182,72,247,175,242,83,225,9,198,109,97,252,80,219,158,117,95,230,62,57,36,181,181,56,237,75,207,228,27,213,52,156,160,196,56,169,183,78,224,187,211,71,191,107,223,160,57,183,233,223,176,201,250,207,15,21,117,52,172,89,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d3507f4f-1914-4114-8a7c-cc67545f380a"));
		}

		#endregion

	}

	#endregion

}

