namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SspUserInviteSchema

	/// <exclude/>
	public class SspUserInviteSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SspUserInviteSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SspUserInviteSchema(SspUserInviteSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c0da7f03-8582-4036-b93e-8094a1fe6e41");
			Name = "SspUserInvite";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7cc31540-fa76-4c79-9b86-a6eabd8e662c");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,165,84,77,107,2,49,16,61,87,240,63,12,120,215,187,182,5,145,34,66,145,197,173,167,210,67,140,163,13,236,38,203,76,98,17,233,127,111,146,245,187,69,163,221,195,178,25,230,205,123,111,102,51,90,148,200,149,144,8,111,72,36,216,44,108,123,96,244,66,45,29,9,171,140,110,231,121,214,108,108,154,141,7,199,74,47,33,95,179,197,178,215,108,248,72,139,112,233,83,96,80,8,230,46,228,92,77,25,105,164,87,202,98,76,232,116,58,240,200,174,44,5,173,159,183,103,95,221,10,165,145,96,97,8,42,67,86,20,160,34,166,189,131,116,142,48,149,155,21,74,130,12,28,167,20,208,133,209,113,32,234,245,136,32,118,175,45,35,83,33,89,133,94,96,22,75,69,101,191,164,197,192,75,41,84,1,102,177,147,229,124,233,246,62,251,88,213,78,22,91,10,93,169,129,27,88,162,237,1,135,215,247,5,154,236,80,189,110,135,180,163,249,101,158,161,83,243,67,238,127,152,64,251,145,39,153,26,251,196,187,152,252,63,210,159,151,74,79,181,74,51,118,10,72,230,12,147,7,50,5,242,117,142,247,143,152,62,9,217,119,153,170,191,251,82,26,167,211,92,157,33,110,179,229,171,160,102,76,159,214,107,13,184,123,104,91,157,67,50,174,74,178,119,10,184,139,115,156,106,46,180,228,38,103,19,100,87,216,112,149,195,245,175,55,217,69,162,153,49,5,228,78,74,228,179,255,3,158,192,146,195,222,165,189,65,228,119,217,215,167,42,176,94,101,94,115,218,222,136,192,84,83,185,95,113,142,131,41,94,179,8,23,198,249,11,3,132,210,208,149,137,69,123,35,14,125,236,75,171,86,127,118,178,133,122,94,175,205,120,174,163,167,65,31,11,207,15,110,123,184,38,55,6,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c0da7f03-8582-4036-b93e-8094a1fe6e41"));
		}

		#endregion

	}

	#endregion

}

