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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,219,110,131,48,12,125,110,165,254,67,164,189,192,11,31,208,118,72,107,119,209,164,77,171,118,81,159,83,112,89,180,214,137,28,195,54,85,251,247,5,210,11,65,180,60,4,108,31,251,248,156,128,114,11,214,200,12,196,59,16,73,171,215,156,204,53,174,85,81,146,100,165,49,121,5,163,137,21,22,201,82,83,126,140,70,195,221,104,56,40,173,251,12,90,183,91,141,147,222,202,249,161,245,241,5,212,223,70,112,46,159,220,203,140,53,41,176,125,136,37,172,78,235,184,250,21,65,225,168,197,124,35,173,29,139,64,204,141,49,119,21,32,63,41,203,128,64,77,131,41,87,27,149,137,172,198,95,134,139,177,232,166,102,210,130,155,177,107,38,29,185,23,164,13,184,17,224,22,88,144,170,36,131,7,24,31,136,15,11,228,156,66,200,106,155,186,225,117,234,183,247,186,127,147,7,224,105,8,73,163,120,178,167,4,204,61,107,103,133,70,213,88,60,3,127,234,220,238,233,189,84,93,57,247,84,14,162,210,42,23,47,232,68,189,177,36,142,14,234,28,17,195,15,139,204,191,99,81,255,3,131,193,202,137,77,90,240,67,121,210,84,131,149,103,10,243,233,227,201,205,91,176,170,64,127,255,105,20,197,181,70,132,239,208,239,54,40,10,5,199,158,228,175,87,180,207,134,201,38,215,122,254,1,153,73,94,222,1,3,0,0 };
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

