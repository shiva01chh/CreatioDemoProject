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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,219,106,195,48,12,125,110,160,255,96,216,75,242,146,15,104,187,192,218,93,24,108,172,236,66,159,221,68,205,204,90,217,200,74,182,81,246,239,115,226,222,28,210,190,196,145,116,164,115,142,108,148,27,176,70,230,32,222,129,72,90,189,226,116,166,113,165,202,138,36,43,141,233,43,24,77,172,176,76,23,154,138,67,52,140,182,195,104,80,89,247,27,180,110,54,26,199,189,149,243,67,155,207,23,80,127,27,193,185,124,122,47,115,214,164,192,246,33,22,176,60,202,113,245,43,130,210,81,139,217,90,90,59,18,129,153,27,99,238,106,64,126,82,150,1,129,218,6,83,45,215,42,23,121,131,191,12,23,35,209,77,77,165,5,55,99,219,78,58,112,207,73,27,112,35,192,9,152,147,170,37,131,7,24,31,136,15,11,228,54,133,144,55,107,234,134,215,153,87,239,125,255,166,15,192,147,16,146,197,201,120,71,9,88,120,214,142,132,214,213,72,60,3,127,234,194,238,232,189,85,93,187,237,169,2,68,173,85,33,94,208,153,122,99,73,28,239,221,57,34,134,31,22,185,63,19,209,188,129,193,96,233,204,166,39,240,125,121,220,86,3,201,83,133,197,228,241,184,205,91,176,170,68,127,255,89,28,39,141,71,132,239,112,223,167,160,56,52,156,120,146,191,94,211,62,27,38,219,92,20,253,3,237,130,83,97,248,2,0,0 };
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

