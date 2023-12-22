namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: IFileImportServiceSchema

	/// <exclude/>
	public class IFileImportServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public IFileImportServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public IFileImportServiceSchema(IFileImportServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("1053b299-f5b8-465b-9060-5fe6f2707c72");
			Name = "IFileImportService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("39b49a3d-3e30-4c01-a6cc-3961eeed3fd5");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,229,85,77,111,130,64,16,61,99,226,127,216,232,5,19,195,15,208,244,210,38,54,52,161,26,49,241,96,60,172,48,208,109,97,151,238,44,36,166,233,127,239,192,130,213,216,120,233,73,229,66,246,205,155,143,55,179,48,146,231,128,5,143,128,173,64,107,142,42,49,222,147,146,137,72,75,205,141,80,210,155,137,12,252,188,80,218,244,123,95,253,158,83,162,144,41,11,247,104,32,247,66,208,149,136,32,80,49,100,211,75,70,111,13,59,34,16,101,168,33,165,184,140,249,210,128,78,40,245,132,249,191,73,90,167,134,186,105,15,84,144,209,60,50,238,43,85,203,30,216,224,140,62,24,109,137,95,148,187,76,68,76,116,129,255,140,235,212,34,14,85,4,96,222,84,140,19,182,104,124,155,180,206,102,94,128,85,223,101,222,54,48,105,240,101,165,62,192,181,110,117,41,139,121,184,26,140,217,18,62,75,64,51,83,58,231,134,112,162,6,128,200,83,176,144,247,130,74,142,217,163,138,247,161,217,103,112,66,57,160,222,90,243,162,128,120,92,167,115,156,37,141,70,73,132,203,81,27,233,206,201,208,90,177,157,63,11,121,5,117,43,220,209,244,122,21,118,115,68,164,178,125,153,168,131,188,103,48,103,70,247,108,244,173,0,166,237,251,154,91,113,121,216,93,55,230,187,119,160,143,230,158,27,209,104,191,235,219,96,69,223,184,254,172,204,37,6,228,79,219,231,248,175,112,106,89,112,77,251,131,118,3,222,116,59,42,37,226,250,238,255,91,252,16,100,108,215,36,157,190,237,242,62,130,26,228,248,249,1,160,132,34,2,76,8,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("1053b299-f5b8-465b-9060-5fe6f2707c72"));
		}

		#endregion

	}

	#endregion

}

