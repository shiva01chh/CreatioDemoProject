﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: SetDefaultFormulaSummaryValuesEELSchema

	/// <exclude/>
	public class SetDefaultFormulaSummaryValuesEELSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public SetDefaultFormulaSummaryValuesEELSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public SetDefaultFormulaSummaryValuesEELSchema(SetDefaultFormulaSummaryValuesEELSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("ae80c552-38b0-494a-819e-2838205b6dd4");
			Name = "SetDefaultFormulaSummaryValuesEEL";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("e0b9d996-6f7e-4520-a678-da960c79be39");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,86,93,111,218,48,20,125,6,137,255,112,151,189,36,18,10,210,30,91,138,212,82,186,117,234,218,74,160,190,76,123,112,147,11,120,74,28,106,59,84,108,229,191,239,218,206,39,77,85,58,132,20,197,190,247,158,115,63,124,28,0,193,82,84,27,22,33,44,80,74,166,178,165,14,167,153,88,242,85,46,153,230,153,8,175,50,137,17,83,250,225,203,160,255,119,208,239,229,138,139,21,220,226,179,206,132,53,255,174,50,113,90,109,204,119,74,99,74,49,146,4,35,19,64,133,95,81,160,228,209,43,155,27,46,158,234,197,38,126,154,18,112,59,110,115,91,98,56,19,154,107,142,234,93,131,112,182,69,161,173,29,253,63,75,92,17,39,152,38,76,169,19,160,220,210,60,97,115,212,154,66,40,235,179,179,14,55,156,40,18,237,65,159,188,70,163,17,140,85,158,166,76,238,38,197,251,189,204,182,60,70,5,203,92,216,60,89,66,190,176,204,36,176,92,103,41,21,47,130,37,79,18,195,173,240,53,187,6,15,158,215,40,170,151,40,75,242,84,0,87,16,73,100,26,227,18,113,212,128,252,217,193,205,159,71,107,76,217,45,181,16,206,192,43,27,53,181,241,188,224,23,185,109,242,199,132,120,68,38,93,160,52,47,113,201,242,68,151,121,187,248,15,44,201,81,205,102,55,112,2,23,76,97,103,25,122,166,247,166,132,85,13,127,160,94,103,49,85,241,94,242,45,241,46,247,55,238,21,140,239,184,64,186,166,126,79,96,106,243,43,80,139,29,223,161,1,218,71,0,22,166,183,101,178,168,203,148,109,76,117,41,65,103,65,211,164,23,187,13,198,46,77,203,125,172,180,164,50,79,124,111,193,117,130,94,112,122,16,228,58,62,210,255,58,110,58,171,22,83,10,33,240,249,117,90,126,73,186,103,182,27,59,245,70,175,206,226,170,24,23,58,100,74,51,154,204,144,234,49,44,204,44,155,247,140,12,123,99,83,3,153,149,176,244,113,86,251,225,241,148,60,223,59,36,208,88,122,3,238,110,131,146,137,248,227,104,173,182,30,226,150,237,122,7,220,245,238,63,50,13,94,103,26,124,44,83,251,216,187,25,145,168,115,41,14,198,196,110,237,171,195,130,34,118,231,197,42,73,199,225,177,39,212,109,30,234,140,93,248,70,216,9,233,140,27,95,152,179,173,81,20,52,167,51,172,156,70,135,94,227,13,147,44,181,242,126,230,41,34,129,210,155,216,35,13,238,45,28,143,172,73,183,7,122,147,197,26,137,12,162,81,165,229,153,183,56,121,83,96,45,177,11,36,61,67,139,112,46,87,202,131,209,4,184,157,94,186,91,162,76,104,198,133,33,174,41,172,37,15,49,211,172,197,162,16,171,108,75,64,36,173,176,205,120,12,119,194,101,236,103,143,191,233,66,41,216,15,161,19,21,176,236,250,35,233,88,88,249,150,78,216,56,220,69,61,207,160,80,160,192,25,213,6,154,154,127,180,112,44,172,113,41,30,124,9,126,233,78,170,145,39,9,188,188,192,39,183,20,206,158,114,150,40,191,214,107,42,147,10,139,241,113,209,93,184,112,145,205,45,128,31,4,213,56,187,161,115,56,251,90,170,232,134,165,27,232,15,198,229,101,118,36,241,210,188,165,123,117,8,115,9,135,151,88,133,31,183,175,204,137,255,26,184,81,131,58,144,171,194,97,18,208,200,162,105,31,54,111,166,86,9,59,45,194,115,177,243,235,10,117,74,119,231,221,83,92,58,142,112,239,13,244,174,243,221,235,21,181,165,164,27,101,109,148,115,104,75,71,189,165,105,214,100,86,84,233,206,78,113,149,104,16,52,26,185,119,223,40,45,205,48,139,230,187,165,37,35,118,109,208,167,223,63,49,183,148,109,193,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("ae80c552-38b0-494a-819e-2838205b6dd4"));
		}

		#endregion

	}

	#endregion

}
