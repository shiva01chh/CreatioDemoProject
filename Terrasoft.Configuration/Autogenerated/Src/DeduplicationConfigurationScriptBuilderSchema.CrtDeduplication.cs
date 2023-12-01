﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: DeduplicationConfigurationScriptBuilderSchema

	/// <exclude/>
	public class DeduplicationConfigurationScriptBuilderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public DeduplicationConfigurationScriptBuilderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public DeduplicationConfigurationScriptBuilderSchema(DeduplicationConfigurationScriptBuilderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("17973d05-ac58-40a2-a21c-2fec746c8c64");
			Name = "DeduplicationConfigurationScriptBuilder";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("4c53ad23-c903-414d-89cd-b08703861304");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,88,91,83,219,56,20,126,78,103,250,31,180,217,157,214,153,205,152,125,6,18,134,18,232,210,161,133,33,116,246,177,35,236,19,162,25,71,206,74,50,11,155,230,191,247,232,98,91,242,37,73,219,135,130,37,157,239,124,231,46,193,233,10,228,154,38,64,30,64,8,42,243,133,138,47,114,190,96,79,133,160,138,229,60,158,65,90,172,51,150,152,175,183,111,54,111,223,12,10,201,248,19,153,191,74,5,43,60,157,101,144,232,77,25,127,4,14,130,37,39,205,51,55,140,255,219,90,124,128,23,85,47,250,234,87,43,212,251,73,230,188,123,91,0,174,227,206,239,2,158,80,45,185,200,168,148,199,36,32,26,216,48,79,4,91,171,15,5,203,82,16,70,244,232,232,136,156,202,98,181,162,226,117,234,190,3,121,146,248,0,68,26,4,242,104,33,226,18,225,200,131,88,23,143,40,76,18,77,230,80,46,228,152,92,95,20,82,229,171,93,124,7,27,195,185,178,247,138,65,150,162,193,119,130,61,83,5,118,115,109,63,136,0,154,230,60,123,37,215,51,199,0,228,125,145,193,61,172,115,201,84,46,94,201,183,180,103,231,196,233,1,158,90,85,161,222,59,145,175,65,40,6,70,119,174,48,234,144,150,218,221,39,121,102,66,21,52,35,127,83,185,156,131,58,149,74,96,252,166,161,71,180,90,121,249,146,100,24,92,109,238,18,86,84,146,201,148,112,248,175,37,185,25,222,160,77,195,237,30,118,232,65,148,40,18,52,68,243,51,209,112,228,108,100,14,140,73,212,239,184,62,191,141,144,186,86,52,232,245,44,153,244,10,239,49,235,51,168,101,222,27,109,235,35,98,168,87,180,177,34,139,21,71,23,42,220,147,209,245,37,47,86,32,232,99,6,167,161,105,179,135,219,41,17,58,22,35,178,49,6,60,83,129,25,36,139,76,33,99,11,30,95,174,214,74,179,116,219,149,29,26,225,138,101,10,132,116,33,67,25,63,128,161,50,123,116,26,141,44,212,2,203,152,38,75,18,25,149,184,79,24,15,185,12,202,157,15,121,170,29,168,127,141,239,221,183,5,25,176,5,137,234,35,168,190,200,50,242,253,123,37,22,59,130,229,94,133,61,16,160,10,193,157,177,14,109,107,127,4,212,22,6,160,36,231,99,214,88,59,92,18,159,167,105,100,49,70,129,22,251,191,99,161,123,93,60,199,214,73,51,246,63,68,59,240,44,200,54,204,130,218,209,46,232,24,88,242,17,84,107,93,226,198,190,124,224,57,55,17,215,166,154,58,29,59,43,93,174,85,228,108,217,126,193,1,50,38,143,121,158,17,221,118,174,229,57,206,130,103,192,120,45,104,38,161,116,210,30,165,169,95,155,90,243,60,47,68,2,159,169,66,37,169,161,97,189,167,3,238,235,169,130,112,0,130,78,207,166,113,241,63,75,16,96,114,72,247,31,147,99,181,13,19,130,29,5,92,224,182,4,208,160,159,211,183,191,235,233,105,171,40,227,50,234,112,236,200,185,254,236,23,137,59,241,227,195,196,191,74,56,87,115,218,54,220,194,248,9,171,203,188,51,235,156,119,106,19,252,206,231,101,140,61,230,101,75,155,225,57,127,221,99,158,67,241,120,31,2,211,54,211,225,52,6,132,110,162,58,134,59,155,235,1,105,96,163,176,237,42,220,27,38,253,54,89,251,113,218,93,190,251,106,55,104,28,242,128,178,12,26,122,29,30,233,71,205,186,113,14,250,150,23,122,210,75,212,120,134,166,48,142,39,70,245,168,168,38,137,78,151,126,91,59,71,66,7,43,221,132,187,200,6,3,163,149,0,109,83,58,82,223,207,215,206,132,37,174,148,222,189,11,231,16,249,205,13,29,220,136,58,160,236,18,80,145,44,189,13,156,80,110,184,94,203,47,40,125,43,12,231,168,243,244,104,52,242,166,93,59,193,47,242,130,163,219,201,148,252,85,143,164,208,133,117,247,71,111,244,14,134,118,231,239,110,246,65,255,61,169,230,169,142,181,25,119,93,122,119,12,63,111,4,155,245,86,129,148,23,65,36,110,105,24,114,209,142,226,105,49,24,151,55,37,89,1,220,9,88,176,23,18,222,11,58,182,91,75,103,103,61,55,35,123,82,86,179,166,76,122,199,223,175,12,217,93,106,37,221,159,174,182,160,116,100,80,49,178,167,80,236,122,169,177,147,197,21,19,82,221,138,25,44,40,70,104,87,197,212,74,202,64,215,42,180,63,230,214,251,19,242,199,240,253,166,233,209,237,166,22,223,190,63,30,58,132,150,244,159,147,6,233,248,33,183,91,165,27,6,126,8,76,46,54,65,130,145,230,18,208,23,242,187,244,254,43,185,247,200,48,239,65,198,177,181,48,149,230,248,14,68,211,38,195,189,175,187,216,252,180,75,195,163,169,247,92,241,175,246,118,63,194,201,37,16,138,219,231,54,41,130,207,206,150,94,37,99,239,203,36,14,218,129,173,172,16,120,220,80,132,201,41,245,5,230,2,19,14,188,156,110,229,79,95,175,137,26,244,60,12,106,154,202,236,87,145,198,254,181,197,100,160,113,98,249,218,182,53,57,247,215,162,97,253,151,133,164,255,239,30,165,194,201,102,216,170,226,202,199,141,254,212,242,71,203,206,249,78,249,30,95,140,201,208,182,94,115,234,91,201,167,153,249,247,148,63,65,212,214,83,30,247,157,16,159,175,215,152,235,145,107,107,159,114,198,163,225,120,56,14,12,28,237,146,196,215,121,73,164,44,170,224,88,163,80,77,129,117,148,152,45,188,112,17,215,240,223,15,135,251,24,184,168,18,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("17973d05-ac58-40a2-a21c-2fec746c8c64"));
		}

		#endregion

	}

	#endregion

}

