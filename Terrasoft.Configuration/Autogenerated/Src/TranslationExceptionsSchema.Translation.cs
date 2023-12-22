namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationExceptionsSchema

	/// <exclude/>
	public class TranslationExceptionsSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationExceptionsSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationExceptionsSchema(TranslationExceptionsSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("dd34e1f4-8c12-45a5-b98a-235cdfe34c22");
			Name = "TranslationExceptions";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6d2d1275-178c-4cc9-a265-eb797a3ca54a");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,80,177,78,196,48,12,157,91,169,255,96,137,229,88,218,253,64,44,39,54,6,36,42,152,221,224,182,145,82,167,138,19,142,227,196,191,147,38,61,40,11,100,113,252,108,191,247,108,198,137,100,70,69,208,146,115,40,182,247,245,193,114,175,135,224,208,107,203,117,235,144,197,164,127,85,158,171,178,8,162,121,128,167,147,120,154,110,170,50,34,87,142,134,88,134,131,65,145,61,188,56,237,233,193,42,52,250,3,59,67,207,104,2,221,191,43,154,51,73,156,104,154,6,110,37,76,19,186,211,221,154,183,35,1,93,186,192,143,232,65,75,140,206,30,25,142,35,49,8,190,17,216,153,178,179,165,202,214,131,4,165,72,164,15,166,190,48,55,27,234,57,116,70,43,80,139,183,127,172,193,30,54,54,139,115,178,250,179,157,101,241,46,40,111,93,92,242,49,209,230,142,85,226,111,242,93,28,94,14,23,239,45,56,208,117,20,235,80,104,247,157,47,183,45,62,87,77,226,215,44,155,242,140,254,6,19,182,121,95,108,5,226,178,202,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("dd34e1f4-8c12-45a5-b98a-235cdfe34c22"));
		}

		#endregion

	}

	#endregion

}

