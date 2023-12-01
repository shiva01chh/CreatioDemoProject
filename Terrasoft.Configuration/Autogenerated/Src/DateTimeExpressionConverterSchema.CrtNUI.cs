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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,82,93,75,195,48,20,125,222,96,255,225,90,95,90,144,246,93,183,193,208,9,62,76,7,238,77,124,200,218,187,90,105,146,114,147,136,69,246,223,205,71,219,125,56,12,165,144,115,207,57,247,220,36,130,113,84,13,203,17,54,72,196,148,220,233,244,94,138,93,85,26,98,186,146,98,50,254,153,140,71,70,85,162,132,215,86,105,228,119,195,254,88,194,185,20,174,98,191,107,194,210,42,225,190,102,74,221,194,3,211,184,169,56,46,191,27,66,165,108,197,54,248,66,210,72,147,177,165,103,89,6,83,101,56,103,212,206,187,189,211,128,182,34,192,65,5,121,47,131,220,57,167,189,54,59,18,191,93,232,178,208,154,170,173,209,24,71,206,55,74,222,45,177,49,219,186,202,131,211,127,17,225,22,158,46,193,214,226,199,199,31,198,93,161,254,144,133,29,120,237,173,67,241,124,56,15,116,46,10,138,97,204,47,86,27,76,7,69,118,46,153,54,140,24,7,97,175,107,22,121,114,52,127,56,83,79,51,79,186,172,97,84,26,142,66,171,104,14,139,162,168,220,221,178,26,6,248,175,154,80,27,18,106,222,207,92,28,197,85,246,68,69,105,53,61,201,169,186,35,13,53,88,186,80,86,16,203,237,39,230,58,100,188,233,171,67,95,152,65,20,37,224,30,217,104,212,21,93,159,71,73,156,105,87,45,138,116,181,74,91,187,162,59,207,170,118,16,95,29,130,63,169,103,83,215,47,180,228,141,110,227,164,247,26,157,184,12,244,96,177,247,255,254,218,125,195,131,119,15,167,27,106,215,140,20,198,113,8,150,116,51,72,163,189,228,208,43,28,131,7,211,141,124,245,236,248,16,32,57,238,218,113,187,35,244,169,125,121,223,61,39,20,69,120,81,126,31,208,83,208,98,118,253,2,181,238,213,229,187,3,0,0 };
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

