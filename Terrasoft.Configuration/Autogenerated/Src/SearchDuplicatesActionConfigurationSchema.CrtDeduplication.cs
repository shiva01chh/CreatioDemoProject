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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,205,106,195,48,12,62,183,208,119,16,244,158,220,215,82,24,237,40,133,29,202,178,23,240,108,37,53,196,118,176,236,65,8,123,247,217,78,154,37,165,108,157,15,6,73,223,159,140,53,83,72,13,227,8,239,104,45,35,83,186,108,111,116,41,43,111,153,147,70,103,7,20,190,169,37,79,213,106,217,173,150,11,79,82,87,80,180,228,80,109,110,234,192,174,107,228,17,76,217,17,53,90,201,127,48,83,19,165,140,190,63,177,152,157,173,225,72,20,230,1,177,182,88,5,61,216,215,140,232,9,10,100,150,95,14,67,42,164,231,228,54,75,157,104,121,158,195,150,188,82,204,182,187,161,14,186,159,82,32,1,37,17,16,163,10,176,36,3,124,182,253,85,38,159,232,52,254,35,112,128,199,52,143,133,89,116,41,208,184,72,72,209,160,117,18,195,54,231,164,214,207,111,19,167,198,139,118,210,181,112,18,217,8,153,166,185,198,57,122,41,6,236,73,64,7,21,186,77,216,50,92,95,127,139,19,191,160,98,160,195,111,120,216,165,72,156,127,120,189,74,114,96,74,176,190,70,250,221,38,66,183,209,107,7,111,17,157,168,119,124,214,168,69,255,166,169,238,187,243,102,232,197,243,13,75,187,10,67,233,2,0,0 };
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

