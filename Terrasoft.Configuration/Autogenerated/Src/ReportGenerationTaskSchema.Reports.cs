namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ReportGenerationTaskSchema

	/// <exclude/>
	public class ReportGenerationTaskSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ReportGenerationTaskSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ReportGenerationTaskSchema(ReportGenerationTaskSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("68544e27-681d-4cfb-9b4f-a820834261f0");
			Name = "ReportGenerationTask";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("f8ef1a6f-6619-48e3-9227-afa9b7782f83");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,80,177,106,195,48,20,156,109,240,63,60,200,210,66,137,247,186,237,146,193,116,41,33,241,86,58,40,246,179,17,181,37,241,36,13,169,201,191,87,146,149,196,9,105,75,181,72,156,238,221,189,59,193,6,212,138,213,8,21,18,49,45,91,179,92,73,209,242,206,18,51,92,138,44,29,179,52,177,154,139,14,182,123,109,112,40,178,212,33,11,194,206,125,195,170,103,90,63,194,6,149,36,83,162,192,105,172,98,250,51,240,222,183,72,156,245,252,139,237,122,252,112,128,178,187,158,215,80,251,185,31,198,146,49,140,158,61,164,208,134,108,109,36,57,171,117,16,152,24,81,236,150,204,221,61,248,205,147,195,223,204,210,242,6,140,123,189,54,15,224,156,124,86,10,196,55,87,79,212,73,170,64,128,231,200,44,2,184,57,209,220,199,121,166,152,57,47,80,52,83,144,203,84,107,146,10,201,112,188,202,148,231,57,60,105,59,12,140,246,47,71,160,68,163,65,18,104,127,51,232,166,0,24,45,65,145,172,209,245,233,87,3,222,160,48,188,229,72,203,147,94,62,23,140,93,132,216,49,213,232,36,77,225,229,11,56,252,127,143,230,184,136,112,225,127,119,141,253,206,138,187,225,125,213,217,132,94,130,1,155,159,111,71,157,243,122,203,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("68544e27-681d-4cfb-9b4f-a820834261f0"));
		}

		#endregion

	}

	#endregion

}

