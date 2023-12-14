namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarCountTermFactorySchema

	/// <exclude/>
	public class CalendarCountTermFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarCountTermFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarCountTermFactorySchema(CalendarCountTermFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8");
			Name = "CalendarCountTermFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,84,203,110,219,48,16,60,43,64,254,97,225,94,156,139,116,79,28,3,173,210,199,197,64,129,58,232,121,77,173,100,34,34,41,240,97,87,8,242,239,93,234,101,199,73,107,71,7,9,92,206,204,14,87,220,213,168,200,53,40,8,214,100,45,58,83,250,52,55,186,148,85,176,232,165,209,105,142,53,233,2,173,187,190,122,190,190,74,130,147,186,130,95,173,243,164,238,166,245,49,217,82,250,13,133,55,86,146,59,32,38,153,181,84,244,168,165,135,251,243,41,211,17,204,58,172,244,201,82,197,251,144,215,232,28,220,78,154,185,9,218,179,152,234,243,182,29,56,203,50,88,184,160,20,218,118,57,172,71,2,136,200,0,207,20,40,123,78,58,82,178,35,78,19,54,181,20,32,186,124,255,206,150,60,119,25,39,127,43,242,91,83,68,135,63,59,129,126,247,212,80,23,248,78,30,4,214,34,212,221,209,65,145,216,162,150,78,193,166,133,74,238,72,131,231,26,64,224,34,164,147,74,118,42,179,104,208,162,2,205,127,243,126,230,135,162,205,150,235,137,186,200,58,196,129,96,201,7,171,221,50,127,47,57,195,199,253,72,24,202,176,147,214,7,172,225,11,58,154,138,16,79,48,45,230,111,255,242,104,230,6,226,237,73,18,183,151,94,108,97,126,26,79,4,171,190,189,37,233,74,234,224,233,182,199,36,189,171,254,2,12,229,79,217,192,162,71,77,62,150,243,155,187,255,170,254,54,246,137,111,229,101,226,175,192,151,231,248,97,130,61,39,29,49,31,118,125,137,240,17,244,114,253,7,108,207,233,50,228,195,126,47,144,61,32,223,81,47,168,196,80,251,81,99,199,253,203,131,195,216,21,57,135,21,241,32,153,61,106,220,212,4,222,128,176,132,158,0,185,197,173,229,209,102,116,17,199,207,161,225,83,152,186,2,164,227,175,107,72,200,82,82,145,206,134,132,137,223,90,179,7,77,123,248,108,171,160,72,251,175,127,4,53,177,73,230,199,169,7,135,47,241,253,50,204,0,174,65,63,6,186,117,31,125,29,228,88,124,254,2,137,170,37,151,123,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("0a4f01d7-03db-4c5d-934f-5339cf3d53d8"));
		}

		#endregion

	}

	#endregion

}

