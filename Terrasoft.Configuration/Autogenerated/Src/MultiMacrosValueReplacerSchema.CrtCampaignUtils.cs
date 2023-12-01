﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: MultiMacrosValueReplacerSchema

	/// <exclude/>
	public class MultiMacrosValueReplacerSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public MultiMacrosValueReplacerSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public MultiMacrosValueReplacerSchema(MultiMacrosValueReplacerSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("65b5c874-9418-4482-9d29-032806aa0044");
			Name = "MultiMacrosValueReplacer";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6c038aa0-46cd-4697-bc93-5c682e364aef");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,117,83,93,143,218,48,16,124,206,73,247,31,182,84,58,5,233,228,188,95,15,170,43,106,85,164,210,158,128,246,158,221,100,33,150,252,65,109,7,138,78,252,247,110,108,19,2,71,121,136,200,120,61,51,187,59,209,92,161,219,240,18,97,137,214,114,103,86,158,77,140,94,137,117,99,185,23,70,179,9,87,27,46,214,218,221,222,188,222,222,100,141,19,122,13,139,189,243,168,216,55,161,255,124,184,4,151,248,215,159,192,62,173,82,70,211,9,157,189,183,184,38,114,152,72,238,220,3,204,26,233,197,140,151,214,184,95,92,54,56,199,141,36,79,54,212,22,69,1,143,174,81,138,219,253,56,189,127,150,168,80,123,88,25,75,103,136,80,90,92,141,6,19,35,27,165,3,133,155,122,164,14,140,29,20,99,216,213,162,172,193,70,86,7,170,149,83,65,14,182,161,152,29,117,138,158,208,166,249,45,69,9,101,235,241,191,22,225,1,174,169,38,131,196,242,26,154,232,58,158,161,175,77,69,61,63,7,246,120,120,217,98,0,230,157,221,232,116,39,124,157,236,130,208,80,6,213,224,252,173,245,136,108,184,229,10,52,173,120,52,40,141,246,180,152,193,248,177,8,112,168,74,29,154,45,45,73,84,8,91,35,42,120,182,134,84,93,126,173,173,73,100,129,196,54,132,54,18,89,38,86,144,191,75,24,235,13,201,177,39,189,207,135,199,178,204,162,111,108,27,1,250,127,8,207,45,183,169,147,120,1,70,71,110,214,215,103,47,53,90,204,75,24,141,161,100,95,185,235,137,192,221,29,97,83,215,230,46,222,25,70,5,10,7,114,218,123,126,33,114,154,94,36,239,236,181,117,22,29,109,154,108,104,220,245,55,59,15,120,222,187,151,12,254,156,86,73,47,142,193,121,75,185,39,63,223,27,41,127,216,151,90,120,92,180,95,216,217,221,240,252,200,150,102,17,202,105,70,157,139,96,35,178,124,106,132,172,40,99,209,205,162,143,189,101,235,147,37,67,217,181,157,164,163,140,125,161,152,210,124,242,144,175,118,178,71,3,89,118,38,207,82,18,99,33,123,146,130,187,251,152,74,22,21,3,113,39,154,29,186,191,113,154,209,31,117,113,78,123,242,155,202,99,36,58,211,113,228,148,161,170,186,62,247,251,180,173,97,47,81,135,244,185,161,174,226,23,23,222,35,122,14,18,70,191,127,89,198,245,110,1,5,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("65b5c874-9418-4482-9d29-032806aa0044"));
		}

		#endregion

	}

	#endregion

}

