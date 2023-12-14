namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: WordReportingAppEventListenerSchema

	/// <exclude/>
	public class WordReportingAppEventListenerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public WordReportingAppEventListenerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public WordReportingAppEventListenerSchema(WordReportingAppEventListenerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("c074c284-2329-406d-b902-b8e6677ad447");
			Name = "WordReportingAppEventListener";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("7609649d-94a6-447b-b054-9d91465ffa7b");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,219,110,131,48,12,125,110,165,254,67,164,189,192,11,31,0,93,165,181,187,104,210,166,85,187,168,207,41,184,44,90,113,34,199,176,77,213,254,125,129,244,150,138,150,135,128,237,99,31,159,19,80,86,96,141,204,65,188,3,145,180,122,197,201,76,227,74,149,53,73,86,26,147,87,48,154,88,97,153,44,52,21,251,104,52,220,140,134,131,218,186,207,160,181,170,52,102,189,149,243,67,219,227,11,168,191,141,224,92,62,185,151,57,107,82,96,251,16,11,88,30,214,113,245,43,130,210,81,139,217,90,90,155,138,64,204,141,49,119,13,32,63,41,203,128,64,93,131,169,151,107,149,139,188,197,95,134,139,84,156,166,166,210,130,155,177,233,38,237,185,231,164,13,184,17,224,22,152,147,106,36,131,7,24,31,136,15,11,228,156,66,200,91,155,78,195,235,137,223,222,235,254,77,30,128,199,33,100,18,197,217,150,18,176,240,172,39,43,116,170,82,241,12,252,169,11,187,165,247,82,117,227,220,83,5,136,70,171,66,188,160,19,245,198,146,56,218,169,115,68,12,63,44,114,255,142,69,251,15,12,6,75,39,54,57,130,239,202,89,87,13,86,158,42,44,198,143,7,55,111,193,170,18,253,253,79,162,40,110,53,34,124,135,126,31,131,162,80,112,236,73,254,122,69,251,108,152,236,114,238,249,7,212,203,13,236,249,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("c074c284-2329-406d-b902-b8e6677ad447"));
		}

		#endregion

	}

	#endregion

}

