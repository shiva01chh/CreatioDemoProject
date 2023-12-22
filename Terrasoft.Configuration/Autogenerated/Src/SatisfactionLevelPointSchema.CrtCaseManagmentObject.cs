namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SatisfactionLevelPointSchema

	/// <exclude/>
	public class SatisfactionLevelPointSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SatisfactionLevelPointSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SatisfactionLevelPointSchema(SatisfactionLevelPointSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("5f9c9fd0-00ee-4522-83fe-fc6de0e0459a");
			Name = "SatisfactionLevelPoint";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("c3c90037-274c-4793-841e-197eb228d3cd");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,189,138,195,48,12,158,19,200,59,8,186,199,123,239,184,37,235,13,133,246,5,84,87,14,134,88,14,150,82,40,165,239,94,187,62,122,185,66,135,211,96,208,167,239,71,194,140,129,100,70,75,112,160,148,80,162,211,126,136,236,252,184,36,84,31,185,107,175,93,11,185,54,137,198,220,195,48,161,8,108,97,159,199,226,208,22,210,55,157,105,218,69,207,218,181,149,109,140,129,79,89,66,192,116,249,250,133,170,216,70,86,244,76,9,92,76,32,43,35,152,139,137,0,242,41,179,66,160,220,244,43,71,243,215,114,94,142,147,183,96,31,174,239,22,106,242,1,77,243,178,80,5,30,12,136,14,72,212,7,84,202,169,40,212,63,5,102,173,248,73,43,146,42,188,194,72,250,1,82,158,91,185,252,77,204,80,47,1,141,255,10,18,77,158,199,167,250,37,173,169,137,27,226,83,253,153,174,205,200,186,238,112,53,152,59,220,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("5f9c9fd0-00ee-4522-83fe-fc6de0e0459a"));
		}

		#endregion

	}

	#endregion

}

