namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarUtilitiesSchema

	/// <exclude/>
	public class CalendarUtilitiesSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarUtilitiesSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarUtilitiesSchema(CalendarUtilitiesSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("62f7c1b7-845c-4ca7-86ea-eb981e255cb0");
			Name = "CalendarUtilities";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("d770fc62-0459-4fe8-8528-e32423c8d6cb");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,81,79,219,48,16,126,14,18,255,225,224,1,37,3,89,236,5,33,161,34,65,91,33,164,77,72,43,85,159,157,228,82,60,146,51,59,159,213,85,83,255,251,236,52,36,5,149,141,68,113,236,187,207,223,247,249,124,222,25,90,194,108,237,4,155,171,195,3,223,46,31,145,89,59,91,137,26,219,166,177,180,55,193,248,65,88,77,110,251,204,150,88,125,51,244,235,125,108,108,235,26,11,49,150,156,186,67,66,54,197,94,66,170,204,210,179,142,192,143,4,167,36,70,12,186,61,249,249,189,90,96,30,88,132,109,237,212,235,228,95,102,30,242,159,97,250,221,150,88,7,216,246,125,241,121,109,10,112,18,124,20,80,212,218,57,24,235,26,169,212,60,23,83,183,242,240,231,240,32,121,139,52,36,112,135,178,176,252,28,212,30,77,131,183,40,43,68,154,104,65,151,198,49,6,35,156,37,174,206,160,143,5,242,54,50,119,200,193,55,109,253,129,127,179,204,90,209,132,81,60,211,142,212,68,175,93,186,195,218,145,101,240,5,46,195,119,113,30,142,150,108,254,227,183,37,249,140,199,206,69,143,128,209,128,86,113,136,106,73,7,14,201,110,54,164,76,5,131,91,184,126,199,155,200,19,219,21,16,174,224,134,151,190,65,146,233,239,2,95,98,1,210,227,123,42,44,115,40,7,132,107,17,40,245,26,142,225,180,167,104,249,55,59,69,130,41,5,10,214,121,141,234,135,166,37,166,231,103,240,117,216,161,102,62,23,214,133,12,142,50,21,75,145,181,94,212,12,99,171,164,182,170,28,10,140,174,119,142,122,83,150,109,205,182,185,172,219,176,120,66,198,52,250,10,224,240,139,100,15,213,2,241,25,142,70,175,29,216,199,212,76,7,155,17,125,114,242,25,180,15,61,184,238,148,198,214,147,164,89,119,183,155,216,185,225,249,11,25,29,152,64,228,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("62f7c1b7-845c-4ca7-86ea-eb981e255cb0"));
		}

		#endregion

	}

	#endregion

}

