namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: ISearchColumnNameProviderSchema

	/// <exclude/>
	public class ISearchColumnNameProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public ISearchColumnNameProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public ISearchColumnNameProviderSchema(ISearchColumnNameProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("90958362-e618-422a-ad51-19a35fdf8930");
			Name = "ISearchColumnNameProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("76eace8e-4a48-486b-bf04-de18fe06b0a2");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,193,142,194,32,16,134,207,54,233,59,76,244,178,123,41,119,237,246,226,97,227,65,99,212,23,192,118,90,73,4,154,1,76,140,241,221,173,208,42,234,102,185,241,207,124,252,255,48,160,184,68,211,242,18,97,135,68,220,232,218,102,115,173,106,209,56,226,86,104,149,38,112,73,147,52,25,77,8,155,238,14,11,101,145,234,142,152,194,98,139,156,202,195,92,31,157,84,171,238,165,53,233,147,168,144,60,0,140,49,200,141,147,146,211,185,24,132,128,64,233,25,48,86,147,80,13,220,99,64,219,211,217,3,102,49,221,186,253,81,148,32,6,255,255,236,71,125,232,71,234,37,218,131,174,12,76,97,237,159,9,213,143,136,65,217,160,117,164,204,95,33,179,39,198,62,184,188,229,196,165,239,251,25,155,40,220,184,120,25,59,203,153,239,140,72,10,150,197,54,246,202,217,32,251,70,99,125,233,23,237,251,224,95,177,0,177,243,247,172,159,116,130,170,10,127,17,150,115,13,75,125,81,59,45,62,55,126,245,200,143,29,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("90958362-e618-422a-ad51-19a35fdf8930"));
		}

		#endregion

	}

	#endregion

}

