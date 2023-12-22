namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ILogoutEventHandlerSchema

	/// <exclude/>
	public class ILogoutEventHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ILogoutEventHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ILogoutEventHandlerSchema(ILogoutEventHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("06f8ea2d-d42f-9e96-1ad8-2155021d7863");
			Name = "ILogoutEventHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ee75749b-5184-4f75-a3ec-dd2e096c705e");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,145,205,110,194,48,12,128,207,67,226,29,172,238,178,93,154,59,20,46,104,210,144,54,137,3,123,128,144,186,37,82,126,42,59,97,154,208,222,125,38,5,4,104,61,53,142,253,249,139,29,180,71,30,180,65,216,34,145,230,216,165,122,21,67,103,251,76,58,217,24,166,147,227,116,242,148,217,134,254,46,133,112,62,157,200,205,51,97,47,105,176,14,9,169,19,208,12,214,31,177,143,57,189,29,48,164,119,29,90,135,84,82,149,82,208,112,246,94,211,207,242,124,222,80,60,216,22,25,244,96,161,139,4,149,176,50,35,129,43,144,10,180,57,105,48,88,63,56,244,130,44,90,245,133,167,110,128,67,222,57,107,192,94,84,254,51,129,99,113,185,122,127,98,218,199,150,103,176,41,197,227,229,163,105,9,108,247,150,193,151,116,248,182,206,193,14,193,104,231,176,149,63,81,199,209,155,145,249,4,198,208,138,9,72,194,131,58,215,215,22,234,177,71,51,104,210,30,130,108,101,81,101,83,45,27,70,233,66,216,45,170,47,161,203,106,2,150,129,84,106,41,120,78,58,24,172,27,85,234,10,230,16,109,11,227,99,203,187,95,238,235,32,155,215,249,121,4,162,56,78,161,156,127,199,125,222,5,37,118,251,253,1,180,178,150,219,46,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("06f8ea2d-d42f-9e96-1ad8-2155021d7863"));
		}

		#endregion

	}

	#endregion

}

