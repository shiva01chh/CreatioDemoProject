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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,145,177,110,131,48,16,134,103,144,120,135,83,166,116,193,123,75,89,200,82,169,83,201,11,92,224,32,150,192,70,119,38,85,20,245,221,107,28,32,73,219,169,150,101,201,246,255,249,62,219,6,123,146,1,43,130,61,49,163,216,198,165,133,53,141,110,71,70,167,173,73,11,236,200,212,200,146,196,151,36,142,70,209,166,133,242,44,142,250,151,36,246,43,74,41,200,100,236,123,228,115,62,207,63,104,96,18,50,78,0,161,154,79,128,26,29,130,56,203,148,46,156,186,3,135,241,208,233,10,180,113,196,205,164,244,182,212,222,121,176,156,184,108,159,195,231,145,216,235,194,243,109,63,187,75,134,163,46,81,228,199,95,106,97,225,221,98,45,55,41,109,26,203,253,245,174,43,163,126,66,217,128,140,61,24,255,92,175,155,133,221,228,197,122,53,159,63,167,153,10,177,64,157,172,174,67,173,45,83,227,117,23,232,233,250,106,127,187,149,120,34,168,142,104,90,18,176,205,10,253,223,236,193,41,228,153,220,200,70,242,114,172,42,146,80,198,14,52,255,118,166,150,237,41,127,176,182,11,78,219,71,255,232,43,137,125,191,111,223,19,204,175,168,73,2,0,0 };
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

