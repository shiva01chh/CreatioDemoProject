namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MacroValueModelSchema

	/// <exclude/>
	public class MacroValueModelSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MacroValueModelSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MacroValueModelSchema(MacroValueModelSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("e05ca81a-184e-4e98-bb5a-a27cf686c759");
			Name = "MacroValueModel";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,81,75,107,195,48,12,62,47,144,255,32,218,123,114,223,186,194,200,185,80,216,216,93,113,229,224,225,216,65,178,7,165,236,191,207,177,219,146,141,173,212,8,131,30,223,67,182,195,145,100,66,69,240,70,204,40,94,135,166,243,78,155,33,50,6,227,93,211,225,56,161,25,156,212,213,169,174,234,234,97,205,52,164,6,116,22,69,30,97,135,138,253,59,218,72,59,127,32,155,6,82,180,109,11,27,137,227,136,124,220,158,243,68,27,208,56,1,227,180,7,236,125,12,48,206,96,248,156,209,160,61,3,185,96,194,17,148,183,113,116,205,133,168,93,48,77,177,183,70,129,154,197,255,208,46,22,175,30,247,236,39,226,96,40,25,221,103,100,233,255,246,151,11,47,214,160,128,215,197,85,115,157,91,202,95,244,37,176,113,195,25,114,130,129,194,19,200,124,125,221,16,200,118,165,172,123,155,222,247,31,164,2,228,213,238,166,127,45,158,152,38,38,73,47,153,255,15,82,108,132,8,20,147,126,94,101,198,85,187,189,103,185,194,247,175,135,53,185,67,121,230,156,151,234,207,98,170,45,207,55,29,171,38,156,109,2,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("e05ca81a-184e-4e98-bb5a-a27cf686c759"));
		}

		#endregion

	}

	#endregion

}

