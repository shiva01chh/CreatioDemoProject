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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,133,81,207,75,195,48,20,62,175,208,255,33,116,151,21,70,209,171,99,23,43,158,156,12,59,188,136,135,183,246,173,6,154,164,190,188,12,180,236,127,55,77,59,97,99,211,92,250,250,189,124,191,136,6,133,182,133,18,197,6,137,192,154,29,103,185,209,59,89,59,2,150,70,103,133,41,37,52,113,212,197,81,28,77,156,149,186,22,197,151,101,84,217,147,212,159,139,115,240,197,105,150,10,179,2,201,243,228,119,80,89,4,242,148,176,246,63,34,111,192,218,59,113,15,22,115,163,20,232,106,13,228,131,48,82,184,247,246,0,12,62,5,19,148,252,238,129,214,109,27,89,138,178,231,93,161,77,134,124,191,30,107,50,45,18,75,244,70,235,64,31,246,65,123,133,106,139,52,123,246,100,177,20,137,246,223,36,237,141,142,78,150,169,175,20,46,116,61,62,169,145,23,97,176,227,112,184,174,183,135,198,93,22,124,237,55,255,40,78,81,87,67,137,211,70,43,228,15,83,157,213,25,229,205,222,191,158,172,240,232,179,49,69,24,102,233,104,70,200,142,244,184,206,30,13,41,224,89,210,221,28,150,221,237,33,153,135,166,243,33,94,250,71,152,1,61,5,61,214,159,31,252,43,165,213,74,2,0,0 };
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

