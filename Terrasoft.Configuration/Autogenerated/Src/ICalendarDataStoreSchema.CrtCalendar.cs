namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ICalendarDataStoreSchema

	/// <exclude/>
	public class ICalendarDataStoreSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ICalendarDataStoreSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ICalendarDataStoreSchema(ICalendarDataStoreSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a242fa2e-8226-41ca-826d-a20b92e1d9d5");
			Name = "ICalendarDataStore";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("761f835c-6644-4753-9a3e-2c2ccab7b4d0");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,177,110,131,48,16,134,103,144,120,135,83,166,116,193,123,75,89,146,165,82,167,146,23,184,192,65,44,129,141,238,76,42,20,245,221,107,28,32,73,219,169,150,101,201,246,255,249,62,219,6,59,146,30,75,130,3,49,163,216,218,165,59,107,106,221,12,140,78,91,147,238,176,37,83,33,75,18,95,146,56,26,68,155,6,138,81,28,117,47,73,236,87,148,82,144,201,208,117,200,99,62,207,63,168,103,18,50,78,0,161,156,79,128,10,29,130,56,203,148,46,156,186,3,251,225,216,234,18,180,113,196,245,164,244,182,212,222,123,176,152,184,236,144,195,231,137,216,235,194,243,109,63,187,75,134,163,46,81,228,199,95,106,97,225,221,98,37,55,41,109,106,203,221,245,174,43,163,126,66,89,143,140,29,24,255,92,175,155,133,221,228,187,245,106,62,63,166,153,10,177,64,157,173,174,66,173,45,83,237,117,23,232,233,250,106,127,187,21,120,38,40,79,104,26,18,176,245,10,253,223,236,193,41,228,153,220,192,70,242,98,40,75,146,80,198,246,52,255,118,166,150,237,41,127,180,182,13,78,219,71,255,232,43,137,125,247,237,27,142,120,19,232,64,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a242fa2e-8226-41ca-826d-a20b92e1d9d5"));
		}

		#endregion

	}

	#endregion

}

