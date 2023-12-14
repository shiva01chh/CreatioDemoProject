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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,193,10,194,48,12,134,207,27,236,29,2,187,111,119,21,47,234,193,243,246,2,113,102,163,96,51,73,83,65,196,119,183,157,155,12,134,130,133,66,210,126,249,254,82,70,75,238,138,13,65,77,34,232,250,86,139,93,207,173,233,188,160,154,158,179,244,145,165,137,119,134,59,168,238,78,201,174,67,159,11,117,225,18,42,21,223,40,172,96,143,74,181,177,116,100,37,185,225,37,75,3,85,150,37,108,156,183,22,229,190,29,251,8,58,104,122,86,52,76,82,76,88,57,227,174,254,116,49,13,184,183,124,169,78,226,147,22,246,225,160,82,20,5,13,120,241,97,230,234,201,61,73,199,129,65,152,116,164,235,161,112,99,241,252,154,115,224,243,63,41,17,255,145,17,119,78,124,126,255,106,150,134,62,174,23,160,198,236,47,157,1,0,0 };
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

