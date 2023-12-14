namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SearchScoreSettingSchema

	/// <exclude/>
	public class SearchScoreSettingSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SearchScoreSettingSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SearchScoreSettingSchema(SearchScoreSettingSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("4f808b42-28b6-4954-82ef-e995b5076254");
			Name = "SearchScoreSetting";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6f142301-7a5f-41f6-815b-40f61aa5d442");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,75,107,195,48,12,62,39,208,255,32,122,218,96,36,63,160,93,47,123,193,14,101,44,131,29,198,14,158,167,164,134,196,14,146,66,9,99,255,125,178,147,150,150,177,195,12,126,72,254,30,178,236,77,135,220,27,139,240,130,68,134,67,45,197,77,240,181,107,6,50,226,130,135,175,69,190,200,179,129,157,111,160,26,89,176,83,64,219,162,141,183,92,60,160,71,114,118,117,196,108,113,47,122,17,133,30,57,248,85,162,151,101,9,107,30,186,206,208,184,153,227,103,236,9,25,189,48,96,107,88,156,5,70,67,118,7,108,3,161,6,34,42,200,197,129,95,158,8,244,195,71,171,4,171,68,134,42,209,170,200,170,38,146,34,180,238,236,151,111,74,220,121,113,50,194,30,93,179,147,226,8,59,149,207,222,98,237,79,20,122,36,25,47,14,135,173,118,11,174,97,57,81,151,151,239,17,58,151,226,188,192,107,202,199,94,100,127,186,223,59,108,63,249,236,117,255,246,175,147,198,185,255,173,75,63,162,2,107,22,82,233,43,152,246,205,108,25,203,250,214,185,200,117,141,227,7,192,164,3,183,252,1,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("4f808b42-28b6-4954-82ef-e995b5076254"));
		}

		#endregion

	}

	#endregion

}

