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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,82,81,107,219,48,16,126,118,161,255,225,214,135,98,111,69,116,47,101,48,82,104,147,80,10,27,133,165,33,207,178,125,78,181,218,167,238,116,34,11,35,255,125,146,227,218,110,73,183,218,88,150,238,62,125,223,167,211,121,103,104,13,139,173,19,108,190,30,31,249,118,121,143,204,218,217,74,212,212,54,141,165,131,9,198,55,194,106,118,221,103,246,196,234,155,161,95,175,99,83,91,215,88,136,177,228,212,13,18,178,41,14,18,82,101,214,158,117,4,190,37,56,39,49,98,208,29,200,47,111,213,10,243,192,34,108,107,167,158,39,255,50,115,151,255,12,211,239,182,196,58,192,246,239,147,207,107,83,128,147,224,163,128,162,214,206,193,84,215,72,165,230,165,152,186,149,135,63,199,71,201,75,164,33,129,27,148,149,229,199,160,118,111,26,188,70,217,32,210,76,11,186,52,142,49,24,225,44,113,117,6,125,44,144,183,145,165,67,14,190,105,239,15,252,139,101,214,138,38,140,226,153,70,82,51,189,117,233,136,181,35,203,224,35,124,9,223,197,121,56,90,178,251,143,223,150,228,61,30,59,23,61,2,38,3,90,197,33,170,37,29,56,36,187,217,144,50,21,12,110,225,242,21,111,34,15,108,55,64,184,129,43,94,251,6,73,230,191,11,124,138,5,72,79,110,169,176,204,161,28,16,174,69,160,212,91,56,129,79,61,69,203,191,27,21,9,230,20,40,88,231,53,170,31,154,214,152,158,159,193,231,97,135,90,248,92,88,23,50,56,202,84,44,69,214,122,81,11,140,173,146,218,170,114,40,48,185,28,29,245,170,44,219,154,237,115,89,183,97,245,128,140,105,244,21,192,225,23,201,238,170,21,226,35,124,152,60,119,96,31,83,11,29,108,70,244,233,233,123,208,62,244,224,182,83,154,90,79,146,102,221,221,238,98,231,142,159,191,176,96,14,225,237,3,0,0 };
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

