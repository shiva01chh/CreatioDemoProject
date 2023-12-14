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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,101,80,205,110,194,48,12,62,183,18,239,16,193,5,46,125,0,16,151,177,43,19,106,185,77,211,100,138,169,34,53,73,229,56,101,12,237,221,231,164,116,128,214,147,243,249,251,115,45,24,244,29,212,168,246,72,4,222,157,184,216,56,123,210,77,32,96,237,108,81,185,90,67,59,201,175,147,60,11,94,219,70,85,23,207,104,138,50,88,214,6,139,10,73,8,250,59,209,87,147,92,120,51,194,70,30,106,211,130,247,75,245,2,30,55,206,24,176,199,18,125,104,57,145,222,95,129,65,178,152,160,230,15,1,186,112,104,117,173,234,40,250,175,81,75,245,84,76,98,123,93,163,44,59,103,61,138,254,154,108,255,194,119,228,58,36,214,40,13,118,201,122,216,167,220,45,154,3,210,252,77,206,87,107,53,101,252,226,233,34,150,24,91,120,166,120,235,94,22,42,158,158,101,13,242,42,13,254,54,252,12,126,29,233,30,24,213,241,98,193,136,242,147,224,188,122,112,26,241,18,206,119,167,219,148,17,114,32,123,215,68,211,33,98,100,196,149,84,236,161,13,56,80,178,84,106,157,68,197,222,85,169,233,124,241,160,191,53,155,161,61,14,63,35,189,7,244,25,20,44,126,191,235,102,81,4,7,2,0,0 };
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

