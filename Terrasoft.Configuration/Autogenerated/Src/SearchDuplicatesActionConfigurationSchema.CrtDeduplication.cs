namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SearchDuplicatesActionConfigurationSchema

	/// <exclude/>
	public class SearchDuplicatesActionConfigurationSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SearchDuplicatesActionConfigurationSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SearchDuplicatesActionConfigurationSchema(SearchDuplicatesActionConfigurationSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c9a4d829-6614-4e72-91b0-9433556c337c");
			Name = "SearchDuplicatesActionConfiguration";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,205,106,195,48,12,62,183,208,119,16,244,158,220,215,82,24,237,40,133,29,202,178,23,240,108,37,53,196,78,176,236,65,8,123,247,41,78,154,37,165,108,157,15,6,73,223,159,140,173,48,72,181,144,8,239,232,156,160,42,247,201,190,178,185,46,130,19,94,87,54,57,160,10,117,169,101,172,86,203,118,181,92,4,210,182,128,172,33,143,102,115,83,51,187,44,81,118,96,74,142,104,209,105,249,131,153,154,24,83,217,251,19,135,201,217,85,18,137,120,206,136,181,195,130,245,96,95,10,162,39,200,80,56,121,57,12,169,144,158,163,219,44,117,164,165,105,10,91,10,198,8,215,236,134,154,117,63,181,66,2,138,34,160,70,21,16,81,6,228,108,251,171,76,58,209,169,195,7,115,64,118,105,30,11,179,104,99,160,113,17,78,81,163,243,26,121,155,115,84,235,231,183,137,99,227,197,122,237,27,56,169,100,132,76,211,92,227,28,131,86,3,246,164,160,133,2,253,134,183,228,235,235,111,113,146,23,52,2,44,255,134,135,93,178,200,249,135,215,171,38,15,85,14,46,148,72,191,219,116,208,109,231,181,131,183,14,29,169,119,124,214,104,85,255,166,177,238,187,243,38,247,248,124,3,68,81,56,108,232,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c9a4d829-6614-4e72-91b0-9433556c337c"));
		}

		#endregion

	}

	#endregion

}

