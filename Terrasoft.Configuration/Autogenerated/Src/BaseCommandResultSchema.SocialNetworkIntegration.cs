namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCommandResultSchema

	/// <exclude/>
	public class BaseCommandResultSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCommandResultSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCommandResultSchema(BaseCommandResultSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("d2b8d1ca-42bf-4559-aeb0-b421b90c0d74");
			Name = "BaseCommandResult";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,205,110,194,48,12,62,183,18,239,16,193,5,46,125,0,16,151,177,43,19,106,123,155,166,201,20,83,69,106,146,202,113,202,24,218,187,207,77,203,40,90,79,206,231,239,207,181,96,208,183,80,161,42,145,8,188,59,115,182,115,246,172,235,64,192,218,217,172,112,149,134,102,150,222,102,105,18,188,182,181,42,174,158,209,100,121,176,172,13,102,5,146,16,244,119,164,111,102,169,240,22,132,181,60,212,174,1,239,215,234,5,60,238,156,49,96,79,57,250,208,112,36,189,191,2,131,100,49,65,197,31,2,180,225,216,232,74,85,189,232,191,70,173,213,83,49,137,237,116,133,178,108,157,245,40,250,91,180,253,11,63,144,107,145,88,163,52,56,68,235,97,31,115,247,104,142,72,203,55,57,95,109,213,156,241,139,231,171,190,196,189,133,103,234,111,45,101,161,250,211,147,164,70,222,196,193,143,195,207,224,215,146,238,128,81,157,174,22,140,40,63,9,46,155,137,211,29,207,225,242,112,26,167,132,144,3,217,135,166,55,29,34,238,140,126,37,21,59,104,2,14,148,36,150,218,70,81,86,186,34,54,93,174,38,250,177,217,2,237,105,248,25,241,61,160,207,160,96,211,239,23,116,254,39,199,15,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("d2b8d1ca-42bf-4559-aeb0-b421b90c0d74"));
		}

		#endregion

	}

	#endregion

}

