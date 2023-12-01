namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISysTranslationColumnsConfiguratorSchema

	/// <exclude/>
	public class ISysTranslationColumnsConfiguratorSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISysTranslationColumnsConfiguratorSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISysTranslationColumnsConfiguratorSchema(ISysTranslationColumnsConfiguratorSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("72ebf492-d797-436e-ab08-aef6a2bee1fc");
			Name = "ISysTranslationColumnsConfigurator";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("0b3cc894-bd0d-4e1b-bb7d-87203708d013");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,205,106,195,48,12,199,207,13,228,29,76,119,217,46,241,189,205,114,25,163,228,48,40,172,47,224,58,74,102,176,149,34,217,135,82,250,238,115,156,164,237,58,202,230,139,173,143,159,244,151,140,202,1,31,148,6,177,3,34,197,125,235,139,183,30,91,211,5,82,222,244,88,236,72,33,219,244,206,179,83,158,45,2,27,236,196,231,145,61,184,152,107,45,232,33,200,197,6,16,200,232,117,158,197,172,39,130,46,122,69,141,30,168,141,13,86,162,142,204,77,181,136,6,135,124,237,214,83,34,165,148,162,228,224,156,162,99,53,217,19,57,130,66,143,100,188,175,104,49,147,242,6,61,132,189,53,90,152,89,195,191,36,44,78,73,198,101,130,15,240,95,125,195,43,177,77,213,198,224,189,200,228,216,128,231,63,164,66,113,161,229,61,94,18,248,64,200,85,201,0,66,19,180,175,203,95,98,103,173,176,148,85,41,103,98,40,81,191,99,112,64,106,111,161,124,140,85,131,202,199,43,128,230,249,101,61,205,15,216,140,43,72,246,121,252,214,31,206,232,139,231,27,223,102,166,46,68,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("72ebf492-d797-436e-ab08-aef6a2bee1fc"));
		}

		#endregion

	}

	#endregion

}

