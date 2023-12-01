namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeIntervalSchema

	/// <exclude/>
	public class DateTimeIntervalSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeIntervalSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeIntervalSchema(DateTimeIntervalSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("be7d9f97-3f60-46fc-bf01-100533e7371c");
			Name = "DateTimeInterval";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ccf14817-0a4a-4532-9be8-ee78c30bd143");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,207,10,194,48,12,135,207,27,236,29,2,222,183,187,138,23,245,224,121,123,129,184,101,163,176,102,35,77,5,17,223,221,238,159,12,68,193,66,33,105,191,124,191,82,70,75,174,199,146,160,32,17,116,93,173,233,177,227,218,52,94,80,77,199,73,252,72,226,200,59,195,13,228,119,167,100,119,161,223,8,53,225,18,114,21,95,42,108,225,132,74,133,177,116,97,37,185,97,155,196,129,202,178,12,246,206,91,139,114,63,204,253,0,58,40,59,86,52,76,146,46,88,182,226,122,127,109,77,9,110,146,127,170,163,225,73,31,246,241,32,87,20,5,13,120,250,102,214,234,197,189,72,231,129,81,24,53,164,187,177,112,115,241,252,154,115,230,234,159,148,1,255,145,49,236,13,113,53,253,106,18,135,62,172,23,16,87,208,140,156,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("be7d9f97-3f60-46fc-bf01-100533e7371c"));
		}

		#endregion

	}

	#endregion

}

