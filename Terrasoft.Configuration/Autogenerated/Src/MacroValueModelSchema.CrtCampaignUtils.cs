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
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,81,75,107,195,48,12,62,47,144,255,32,218,123,114,223,186,194,232,185,80,216,216,93,113,229,224,225,71,144,236,65,41,251,239,115,236,182,116,99,43,53,194,160,199,247,144,237,209,145,76,168,8,222,136,25,37,232,216,109,130,215,102,76,140,209,4,223,109,208,77,104,70,47,109,115,108,155,182,121,88,50,141,185,1,27,139,34,143,176,69,197,225,29,109,162,109,216,147,205,3,57,250,190,135,149,36,231,144,15,235,83,158,105,35,26,47,96,188,14,128,67,72,17,220,12,134,207,25,13,58,48,144,143,38,30,64,5,155,156,239,206,68,253,21,211,148,6,107,20,168,89,252,15,237,106,241,226,113,199,97,34,142,134,178,209,93,65,214,254,111,127,165,240,98,13,10,4,93,93,117,151,185,107,249,179,190,68,54,126,60,65,142,48,82,124,2,153,175,175,27,2,197,174,212,117,111,211,135,225,131,84,132,178,218,221,244,175,213,19,211,196,36,249,37,203,255,65,142,149,16,129,98,210,207,139,194,184,232,215,247,44,87,249,254,245,176,36,191,175,207,92,242,90,253,89,204,181,249,124,3,27,2,34,202,101,2,0,0 };
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

