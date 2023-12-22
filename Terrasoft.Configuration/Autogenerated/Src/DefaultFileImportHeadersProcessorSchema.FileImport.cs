namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DefaultFileImportHeadersProcessorSchema

	/// <exclude/>
	public class DefaultFileImportHeadersProcessorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DefaultFileImportHeadersProcessorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DefaultFileImportHeadersProcessorSchema(DefaultFileImportHeadersProcessorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d4b90d0-4c5e-4fab-b39c-029dbd674809");
			Name = "DefaultFileImportHeadersProcessor";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("b51eda84-5cfb-4f7f-b7eb-7f869b20e7e8");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,83,75,111,219,48,12,62,123,192,254,3,209,93,18,32,176,239,105,155,195,188,116,11,208,162,5,178,237,174,200,116,34,64,150,92,82,42,16,4,253,239,163,45,103,113,147,109,5,150,83,72,241,123,152,15,167,26,228,86,105,132,239,72,164,216,215,33,47,189,171,205,54,146,10,198,187,252,206,88,92,53,173,167,0,135,143,31,178,200,198,109,97,189,231,128,205,245,89,44,72,107,81,119,48,206,191,162,67,50,250,162,230,222,184,231,83,114,172,74,248,183,124,190,116,193,4,131,44,5,82,242,137,112,43,26,80,90,197,60,135,47,88,171,104,195,201,232,55,84,21,18,63,145,215,200,236,169,7,21,69,1,55,198,237,196,84,168,188,6,77,88,223,94,125,86,140,23,192,146,80,5,79,87,197,226,136,227,216,52,138,246,199,88,152,95,76,133,12,85,146,6,221,57,129,218,19,180,73,20,118,137,42,63,50,20,35,138,54,110,172,209,3,232,93,247,48,135,127,185,20,190,67,255,129,167,182,72,251,3,69,45,143,210,157,167,94,44,85,12,194,239,74,78,126,48,146,208,184,52,76,136,111,194,105,71,149,205,97,35,174,38,103,79,112,128,215,193,13,186,42,25,122,235,238,1,195,206,87,157,49,242,65,80,88,165,247,243,62,255,223,192,224,55,114,220,240,172,61,106,129,127,145,205,146,217,65,191,82,251,181,222,97,163,100,111,99,227,224,206,184,42,253,157,172,150,46,54,72,106,99,241,230,178,114,1,228,125,24,103,120,6,210,243,110,115,117,31,255,84,54,226,180,191,152,44,35,12,145,220,37,70,110,139,56,60,210,48,143,73,130,194,237,98,224,202,151,207,81,89,30,242,121,169,218,174,199,179,177,196,12,214,125,105,233,155,86,145,97,57,216,71,170,140,83,118,181,117,114,57,165,180,107,58,237,238,42,251,243,92,82,118,156,148,204,248,247,11,41,113,139,197,34,4,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d4b90d0-4c5e-4fab-b39c-029dbd674809"));
		}

		#endregion

	}

	#endregion

}

