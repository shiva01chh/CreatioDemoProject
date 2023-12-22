namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: BaseCommandParameterSchema

	/// <exclude/>
	public class BaseCommandParameterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public BaseCommandParameterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public BaseCommandParameterSchema(BaseCommandParameterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("a330adc7-9feb-43e7-b328-86d676594b41");
			Name = "BaseCommandParameter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("a1c45040-f900-4d72-b99e-b97e9cbc42dd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,207,75,195,48,20,62,119,208,255,33,116,151,14,70,209,171,99,23,39,158,156,20,59,188,136,135,183,246,173,6,154,100,190,188,12,180,244,127,55,77,59,113,195,105,46,125,253,94,190,95,68,131,66,187,135,18,197,6,137,192,154,29,103,43,163,119,178,118,4,44,141,206,10,83,74,104,226,73,27,79,226,73,228,172,212,181,40,62,44,163,202,30,164,126,95,156,131,79,78,179,84,152,21,72,158,39,63,131,202,34,144,167,132,181,255,17,171,6,172,189,17,183,96,113,101,148,2,93,229,64,62,8,35,133,123,47,119,192,224,83,48,65,201,175,30,216,187,109,35,75,81,246,188,11,180,104,200,247,237,145,147,217,35,177,68,111,148,7,250,176,15,218,107,84,91,164,244,209,147,197,82,36,218,127,147,89,111,116,116,178,76,125,165,112,161,237,241,168,70,94,132,193,142,67,119,89,239,0,141,251,93,240,185,223,252,163,56,69,93,13,37,78,27,173,145,223,76,117,86,103,148,55,7,255,122,178,194,163,207,198,20,97,72,103,163,25,33,59,210,227,58,187,55,164,128,211,164,189,234,150,237,117,151,204,67,211,249,16,111,246,71,152,1,61,5,61,246,243,124,1,25,223,19,174,82,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("a330adc7-9feb-43e7-b328-86d676594b41"));
		}

		#endregion

	}

	#endregion

}

