namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DateTimeExpressionConverterSchema

	/// <exclude/>
	public class DateTimeExpressionConverterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DateTimeExpressionConverterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DateTimeExpressionConverterSchema(DateTimeExpressionConverterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("3950f08c-8bf5-45b1-a16f-7b3f28203807");
			Name = "DateTimeExpressionConverter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e35bf724-6dee-44c8-b23b-34796602023a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,93,75,195,48,20,125,222,96,255,225,90,95,90,144,246,93,231,64,182,9,62,76,5,247,38,62,100,237,93,173,52,73,185,73,196,34,254,119,243,209,118,221,28,134,82,200,185,231,156,123,110,18,193,56,170,134,229,8,91,36,98,74,238,117,186,148,98,95,149,134,152,174,164,152,77,191,103,211,137,81,149,40,225,165,85,26,249,205,176,31,75,56,151,194,85,236,119,73,88,90,37,44,107,166,212,53,172,152,198,109,197,113,253,213,16,42,101,43,182,193,39,146,70,154,77,45,61,203,50,152,43,195,57,163,118,209,237,157,6,180,21,1,14,42,200,123,25,228,206,57,237,181,217,72,252,122,166,203,157,214,84,237,140,198,56,114,190,81,242,102,137,141,217,213,85,30,156,254,139,8,215,240,112,14,182,22,223,62,254,48,238,6,245,187,44,236,192,207,222,58,20,79,135,243,64,231,162,160,24,198,252,100,181,193,116,80,100,167,146,121,195,136,113,16,246,186,110,35,79,142,22,171,19,245,60,243,164,243,26,70,165,225,40,180,138,22,112,87,20,149,187,91,86,195,0,255,85,19,106,67,66,45,250,153,139,81,92,101,79,84,148,86,211,147,156,170,59,210,80,131,181,11,101,5,177,220,125,96,174,67,198,171,190,58,244,133,91,136,162,4,220,35,155,76,186,162,235,115,47,137,51,237,170,69,145,110,54,105,107,87,116,227,89,213,30,226,139,67,240,7,245,104,234,250,137,214,188,209,109,156,244,94,147,35,151,129,30,44,126,252,191,191,118,223,240,224,221,195,233,150,218,103,70,10,227,56,4,75,186,25,164,209,94,114,232,21,142,193,131,233,86,190,120,118,124,8,144,140,187,118,220,238,8,125,106,95,254,233,158,19,138,34,188,40,191,15,232,49,104,177,241,250,5,5,150,119,254,196,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("3950f08c-8bf5-45b1-a16f-7b3f28203807"));
		}

		#endregion

	}

	#endregion

}

