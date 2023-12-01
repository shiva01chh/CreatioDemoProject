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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,125,145,177,110,194,48,16,134,103,34,229,29,78,176,208,37,222,105,200,194,80,49,128,16,244,5,220,228,18,44,97,59,58,219,72,8,245,221,235,218,9,53,5,225,205,255,221,231,255,63,31,40,46,209,244,188,70,248,68,34,110,116,107,139,149,86,173,232,28,113,43,180,202,51,184,230,89,158,77,102,132,157,191,195,90,89,164,214,19,11,88,31,144,83,125,92,233,147,147,106,235,95,218,145,62,139,6,41,0,192,24,131,210,56,41,57,93,170,81,136,8,212,129,1,99,53,9,213,193,111,12,232,7,186,184,193,44,165,123,247,117,18,53,136,209,255,149,253,100,8,125,75,189,65,123,212,141,129,5,236,194,51,177,250,16,49,42,123,180,142,148,121,22,178,248,195,216,3,87,246,156,184,12,125,203,169,73,194,77,171,187,177,139,146,133,206,132,164,104,89,29,82,175,146,141,114,104,52,54,148,62,208,254,31,124,158,10,144,58,191,189,15,147,206,80,53,241,47,226,114,190,227,82,239,84,175,249,243,3,112,39,148,213,20,2,0,0 };
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

