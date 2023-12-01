﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: RemindingCounterSchema

	/// <exclude/>
	public class RemindingCounterSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public RemindingCounterSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public RemindingCounterSchema(RemindingCounterSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("edf3978d-17fa-4d6d-b112-b7b940007ce0");
			Name = "RemindingCounter";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("6ba26f98-9709-4408-98d0-761f0c4bf2aa");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,157,85,75,111,219,48,12,62,103,192,254,3,225,93,108,32,112,238,107,27,160,75,31,243,128,117,69,31,219,113,80,109,38,17,106,75,153,30,233,140,97,255,125,148,100,59,182,51,23,216,114,113,68,137,31,95,31,73,193,42,212,59,150,35,60,160,82,76,203,181,73,87,82,172,249,198,42,102,184,20,111,223,252,122,251,102,102,53,23,27,184,175,181,193,234,100,116,78,47,152,97,71,194,149,44,75,204,29,130,78,175,81,160,226,249,225,77,223,86,85,73,241,247,27,133,83,242,244,226,3,93,209,229,59,133,27,50,1,171,146,105,253,30,238,176,226,162,160,247,43,105,133,65,229,223,44,22,11,56,213,182,170,152,170,151,205,249,86,201,61,47,80,3,131,10,205,86,22,96,36,108,208,128,217,34,8,91,61,161,2,185,6,33,13,95,243,220,39,66,195,83,13,27,37,237,46,109,65,23,61,212,157,125,42,121,14,185,115,228,200,15,120,15,217,77,15,171,115,111,230,146,219,69,113,197,177,44,40,140,91,197,247,204,160,247,126,182,11,7,80,200,10,41,202,26,30,53,42,42,145,8,217,133,239,118,112,14,121,153,189,67,81,4,212,230,220,38,138,2,49,202,230,70,42,103,200,59,221,216,9,1,140,93,143,71,230,134,214,18,240,1,204,134,210,116,181,197,252,249,92,109,108,133,194,220,216,178,140,5,241,76,174,227,145,118,114,226,181,71,33,192,25,28,197,52,155,253,126,61,176,207,190,140,83,201,187,71,71,70,184,70,51,140,47,200,227,107,203,11,200,165,48,44,55,89,209,6,181,103,10,116,80,60,131,56,60,77,64,224,75,3,23,143,252,78,188,214,204,81,223,86,34,190,178,34,79,189,149,56,72,210,115,234,12,197,245,115,156,36,9,29,226,200,223,70,35,189,168,207,148,135,122,135,209,28,162,27,202,95,20,148,194,223,70,231,74,201,42,142,186,160,58,121,70,78,169,79,146,255,13,46,73,191,76,88,201,10,186,204,244,229,15,203,202,62,170,115,96,244,220,61,61,182,245,245,133,218,255,62,223,98,197,50,241,77,170,103,63,91,26,139,19,151,4,254,248,138,97,210,185,20,134,155,186,209,60,216,253,182,69,133,163,215,153,190,163,62,233,129,53,169,247,188,143,215,172,212,152,180,250,231,162,56,210,190,65,44,30,228,61,145,236,127,49,86,45,141,142,1,110,153,162,218,185,166,58,112,109,0,52,157,33,146,119,231,215,161,71,164,76,59,181,180,103,237,218,205,177,15,245,107,92,11,173,169,208,88,37,154,54,232,247,97,219,89,123,73,173,115,71,59,132,146,131,31,153,40,74,242,33,115,43,193,21,130,70,159,242,159,57,100,23,220,59,68,243,242,148,70,16,101,107,14,92,152,37,61,208,182,52,253,166,19,35,167,168,253,2,10,109,18,19,2,254,202,74,139,13,206,50,30,184,236,16,114,215,88,147,106,206,108,215,124,109,156,206,137,244,188,40,226,177,245,121,64,75,254,109,10,245,38,235,120,1,121,193,157,79,172,30,196,26,12,161,242,171,166,161,72,218,33,44,198,16,167,59,87,116,112,163,245,44,234,24,21,45,27,6,2,45,56,225,192,41,1,167,11,255,246,160,26,234,170,151,135,162,204,225,197,245,19,60,99,13,92,135,77,231,118,96,72,37,21,22,246,46,121,238,206,139,8,179,5,233,173,143,201,42,83,9,142,54,224,196,220,237,4,195,61,114,89,237,76,221,46,146,94,3,29,170,30,138,72,101,119,51,122,194,145,184,247,190,27,238,83,123,225,96,37,40,5,133,244,242,39,230,214,96,32,120,28,56,6,103,75,248,117,212,8,45,249,27,142,159,192,239,97,95,5,249,20,179,26,89,95,68,18,250,253,1,51,56,164,13,182,9,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("edf3978d-17fa-4d6d-b112-b7b940007ce0"));
		}

		#endregion

	}

	#endregion

}

