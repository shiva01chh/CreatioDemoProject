namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: InvalidQueryStructureExceptionSchema

	/// <exclude/>
	public class InvalidQueryStructureExceptionSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public InvalidQueryStructureExceptionSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public InvalidQueryStructureExceptionSchema(InvalidQueryStructureExceptionSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("efb635f4-13c4-4e2e-a2d4-fb0118960ea2");
			Name = "InvalidQueryStructureException";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("69e28147-db31-49df-9976-b6fb9eb762c1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,82,77,143,130,64,12,61,99,226,127,104,240,162,23,184,187,234,65,241,176,55,55,238,31,168,99,193,73,96,32,243,177,46,49,251,223,183,12,32,104,178,38,75,50,9,125,125,109,223,155,169,194,130,76,133,130,224,147,180,70,83,166,54,218,149,42,149,153,211,104,101,169,162,164,86,88,72,193,160,37,101,167,147,219,116,18,56,35,85,6,199,218,88,42,222,238,241,184,131,166,40,217,114,138,147,51,77,25,55,130,93,142,198,44,33,217,29,41,39,97,183,78,230,103,210,251,111,65,85,51,200,115,227,56,134,149,113,69,129,186,222,116,241,157,1,246,162,203,171,130,83,205,28,34,16,154,210,117,248,212,47,140,55,112,189,144,26,83,90,66,147,185,160,1,169,190,48,151,103,48,86,59,97,29,43,237,7,199,163,201,149,59,229,82,128,104,68,195,123,91,242,225,72,215,199,190,108,208,181,132,145,139,224,230,157,12,182,75,213,78,42,53,187,63,248,182,45,227,217,172,7,18,74,209,229,22,196,80,22,221,201,99,129,189,194,215,218,230,11,104,30,44,248,121,49,242,208,89,29,38,66,202,199,144,5,126,81,254,227,21,49,152,17,223,28,80,223,248,15,81,30,169,80,99,1,188,54,180,14,187,218,112,51,92,87,7,69,171,216,19,255,97,134,245,53,139,214,53,88,52,133,193,18,78,104,104,222,99,15,118,103,164,206,237,51,248,184,69,31,65,198,198,223,47,150,44,49,49,16,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("efb635f4-13c4-4e2e-a2d4-fb0118960ea2"));
		}

		#endregion

	}

	#endregion

}

