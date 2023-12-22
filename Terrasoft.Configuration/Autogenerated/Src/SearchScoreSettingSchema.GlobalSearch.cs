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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,149,81,75,75,196,48,16,62,183,208,255,48,236,73,65,218,31,176,235,94,124,129,135,69,172,224,65,60,196,56,237,6,210,164,100,166,44,69,252,239,78,210,238,210,69,60,24,200,99,38,223,99,50,113,170,67,234,149,70,120,193,16,20,249,134,203,27,239,26,211,14,65,177,241,14,190,138,188,200,179,129,140,107,161,30,137,177,19,128,181,168,227,45,149,15,232,48,24,189,62,97,118,120,96,185,136,66,143,228,221,58,209,171,170,130,13,13,93,167,194,184,157,227,103,236,3,18,58,38,64,171,136,141,6,66,21,244,30,72,251,128,18,48,139,32,149,71,126,181,16,232,135,15,43,4,45,68,130,58,209,234,200,170,39,146,32,164,238,236,151,111,74,220,57,54,60,194,1,77,187,231,242,4,91,202,103,111,177,246,167,224,123,12,60,94,28,15,59,233,22,92,195,106,162,174,46,223,35,116,46,197,56,134,215,148,143,189,200,254,116,191,55,104,63,233,236,117,255,246,111,146,198,185,255,173,73,63,34,2,27,226,32,210,87,48,237,219,217,50,150,245,45,179,200,101,93,142,31,238,213,152,46,4,2,0,0 };
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

