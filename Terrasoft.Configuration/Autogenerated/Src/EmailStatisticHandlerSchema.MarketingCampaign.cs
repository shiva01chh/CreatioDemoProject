namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: EmailStatisticHandlerSchema

	/// <exclude/>
	public class EmailStatisticHandlerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public EmailStatisticHandlerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public EmailStatisticHandlerSchema(EmailStatisticHandlerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5d44b0b4-3404-4787-ab8e-d4ae4b31c20c");
			Name = "EmailStatisticHandler";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("56ea33ea-e32a-430c-959f-44e40c0eb1dc");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,109,140,177,10,128,48,12,68,103,11,253,135,130,187,31,224,42,130,187,254,64,172,81,2,53,149,164,78,226,191,219,234,234,13,199,113,247,56,134,29,245,0,143,110,66,17,208,184,166,166,139,188,210,118,10,36,138,236,46,107,170,90,112,43,185,11,160,218,186,126,7,10,99,202,187,38,242,3,240,18,80,172,201,224,113,206,129,188,243,133,251,199,202,223,139,222,175,215,200,203,119,110,77,110,178,30,211,192,135,182,146,0,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5d44b0b4-3404-4787-ab8e-d4ae4b31c20c"));
		}

		#endregion

	}

	#endregion

}

