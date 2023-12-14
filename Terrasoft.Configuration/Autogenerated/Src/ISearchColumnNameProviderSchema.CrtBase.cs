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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,193,142,194,32,16,134,207,54,233,59,76,244,178,123,41,119,173,189,120,48,30,214,24,245,5,176,157,86,18,129,102,0,19,99,124,119,43,180,46,174,102,185,241,207,124,252,255,48,160,184,68,211,242,18,97,143,68,220,232,218,102,11,173,106,209,56,226,86,104,149,38,112,77,147,52,25,77,8,155,238,14,43,101,145,234,142,152,194,106,135,156,202,227,66,159,156,84,235,238,165,13,233,179,168,144,60,0,140,49,200,141,147,146,211,165,24,132,128,64,233,25,48,86,147,80,13,60,98,64,219,211,217,19,102,49,221,186,195,73,148,32,6,255,255,236,71,125,232,103,234,31,180,71,93,25,152,194,198,63,19,170,111,17,131,178,69,235,72,153,79,33,179,95,140,189,113,121,203,137,75,223,55,31,155,40,220,184,120,25,59,203,153,239,140,72,10,150,197,46,246,202,217,32,251,70,99,125,105,137,246,239,224,95,177,0,177,243,247,172,159,116,130,170,10,127,17,150,115,11,75,125,81,59,237,113,238,136,227,7,98,21,2,0,0 };
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

