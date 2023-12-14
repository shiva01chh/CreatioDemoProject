namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: CalendarRemindCalculatorITILServiceSchema

	/// <exclude/>
	public class CalendarRemindCalculatorITILServiceSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public CalendarRemindCalculatorITILServiceSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public CalendarRemindCalculatorITILServiceSchema(CalendarRemindCalculatorITILServiceSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("67ff7e01-713e-4dfe-9885-71eb157ffd86");
			Name = "CalendarRemindCalculatorITILService";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e9cdff4a-a92d-4d26-906f-df90167f5485");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,207,106,194,64,16,198,207,17,124,135,65,47,17,196,7,208,218,75,16,9,180,32,213,246,82,122,88,55,99,186,176,217,132,253,163,136,230,221,59,155,196,54,166,8,241,16,248,102,156,111,126,243,177,206,8,149,194,246,108,44,102,139,225,192,85,114,135,90,51,147,31,236,44,202,53,82,121,56,80,44,67,83,48,142,119,77,117,16,169,211,204,138,92,13,7,23,255,191,96,172,49,37,9,145,100,198,204,33,98,18,85,194,244,27,102,66,37,164,184,147,204,230,58,222,197,47,91,212,71,193,177,26,43,220,94,10,14,220,79,245,25,130,199,214,228,70,40,193,31,73,174,140,213,142,83,139,128,54,90,28,153,173,151,6,69,45,250,44,12,223,13,106,178,82,200,253,185,224,238,228,196,187,5,115,216,51,131,97,167,5,21,77,89,111,28,211,158,154,171,209,13,228,43,218,239,60,241,124,85,16,13,94,29,138,177,148,48,239,149,74,164,145,238,137,233,96,166,56,246,198,159,194,218,137,4,56,209,199,73,3,28,28,153,174,42,43,101,133,61,195,18,82,180,209,175,14,187,14,245,240,20,20,158,62,191,224,2,163,102,115,76,47,43,78,70,83,24,81,244,185,166,209,90,53,237,13,227,150,10,80,78,22,213,86,113,8,219,75,151,160,156,148,112,189,182,80,102,107,180,187,115,129,73,148,75,151,169,15,38,29,62,249,3,158,195,142,235,196,27,248,206,108,149,21,100,215,219,166,133,218,241,184,165,19,104,180,78,171,10,175,38,47,171,239,173,140,167,94,175,234,223,91,1,31,49,133,221,10,161,92,60,120,64,77,173,93,162,138,255,253,0,187,45,215,27,215,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("67ff7e01-713e-4dfe-9885-71eb157ffd86"));
		}

		#endregion

	}

	#endregion

}

