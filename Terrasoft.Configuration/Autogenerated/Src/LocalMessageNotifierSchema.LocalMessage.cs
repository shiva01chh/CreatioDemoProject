namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: LocalMessageNotifierSchema

	/// <exclude/>
	public class LocalMessageNotifierSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public LocalMessageNotifierSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public LocalMessageNotifierSchema(LocalMessageNotifierSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("f4f644d0-eb01-48be-be16-2d50b24a40a4");
			Name = "LocalMessageNotifier";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4a46c73e-2533-4fb4-8b08-c16580add3d1");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,141,146,111,107,194,48,16,198,95,183,208,239,16,220,27,5,233,7,208,109,48,117,56,193,77,153,186,247,89,122,173,129,54,145,252,97,20,241,187,239,154,68,173,155,136,125,19,114,249,221,115,119,79,207,106,46,10,178,170,181,129,106,152,196,182,117,77,199,178,44,129,25,46,133,78,167,32,64,113,118,66,214,160,20,213,50,55,72,41,72,95,133,225,134,131,198,247,36,22,180,2,189,163,12,46,40,145,243,194,42,218,200,37,241,190,225,162,7,5,5,94,201,184,164,90,15,200,92,50,90,190,131,214,180,128,15,105,120,206,65,57,110,103,191,75,206,8,107,176,171,20,25,144,17,213,240,47,55,242,117,206,133,112,20,163,44,51,82,13,200,210,169,122,32,84,184,166,221,117,179,213,4,220,209,35,251,134,143,2,52,19,185,36,79,68,192,15,105,71,60,115,132,16,240,201,232,162,89,215,59,200,208,89,91,137,47,90,90,120,196,134,208,208,231,110,39,208,157,94,223,103,143,21,80,3,217,168,158,101,183,21,166,150,103,152,223,226,255,106,44,196,109,133,9,66,107,94,193,89,101,33,78,26,111,84,191,24,67,217,182,66,5,212,65,3,33,60,29,61,250,4,38,85,214,238,115,169,120,69,85,221,42,18,82,86,108,11,21,221,180,89,31,74,49,22,152,57,199,253,195,125,211,216,23,13,246,78,184,219,68,212,116,243,246,137,155,250,232,116,180,191,195,32,255,35,79,13,224,128,119,39,53,52,57,248,90,254,56,12,155,227,16,246,11,68,230,87,204,221,125,244,50,232,98,73,140,223,47,60,194,212,155,115,3,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("f4f644d0-eb01-48be-be16-2d50b24a40a4"));
		}

		#endregion

	}

	#endregion

}

