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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,144,193,10,131,48,12,134,207,10,190,67,96,119,189,111,99,151,109,135,157,245,5,50,141,82,176,81,210,116,32,99,239,190,234,116,8,99,131,21,10,73,251,229,251,75,25,45,185,30,75,130,130,68,208,117,181,166,199,142,107,211,120,65,53,29,39,241,61,137,35,239,12,55,144,15,78,201,238,66,191,17,106,194,37,228,42,190,84,216,194,9,149,10,99,233,194,74,114,195,54,137,3,149,101,25,236,157,183,22,101,56,204,253,8,58,40,59,86,52,76,146,46,88,182,226,122,127,109,77,9,238,37,255,84,71,227,147,62,236,211,65,174,40,10,26,240,244,205,172,213,139,123,145,206,3,147,48,106,72,119,83,225,230,226,241,53,231,204,213,63,41,35,254,35,99,220,27,226,234,245,171,73,28,250,245,122,2,31,237,62,228,165,1,0,0 };
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

