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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,145,205,106,195,48,12,199,207,13,228,29,76,119,217,46,241,189,205,114,25,163,228,48,24,172,47,224,58,74,102,176,149,34,217,135,82,246,238,115,156,164,205,58,202,230,139,173,143,159,244,151,140,202,1,31,149,6,177,7,34,197,125,235,139,151,30,91,211,5,82,222,244,88,236,73,33,219,244,206,179,115,158,173,2,27,236,196,199,137,61,184,152,107,45,232,33,200,197,14,16,200,232,109,158,197,172,7,130,46,122,69,141,30,168,141,13,54,162,142,204,162,90,68,131,67,190,118,235,41,145,82,74,81,114,112,78,209,169,154,236,137,28,65,161,71,50,222,87,180,152,73,185,64,143,225,96,141,22,102,214,240,47,9,171,115,146,113,153,224,13,252,103,223,240,70,188,167,106,99,240,86,100,114,236,192,243,31,82,161,184,208,242,22,47,9,124,32,228,170,100,0,161,9,218,231,245,47,177,179,86,88,203,170,148,51,49,148,168,95,49,56,32,117,176,80,222,199,170,65,229,253,21,64,243,248,180,157,230,7,108,198,21,36,251,107,252,214,31,206,232,91,158,111,145,39,75,17,77,2,0,0 };
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

