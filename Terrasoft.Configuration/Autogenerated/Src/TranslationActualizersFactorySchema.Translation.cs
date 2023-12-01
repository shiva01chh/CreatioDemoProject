﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationActualizersFactorySchema

	/// <exclude/>
	public class TranslationActualizersFactorySchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationActualizersFactorySchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationActualizersFactorySchema(TranslationActualizersFactorySchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("7a74f28c-d197-4985-9821-907cb3fc7adb");
			Name = "TranslationActualizersFactory";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,181,86,221,79,219,48,16,127,78,37,254,7,175,123,113,36,20,109,175,148,22,65,25,19,210,54,33,21,158,166,9,153,244,218,90,74,237,202,31,48,134,248,223,119,137,83,154,15,59,161,32,158,234,156,239,126,119,247,187,59,95,5,91,131,222,176,20,200,53,40,197,180,92,152,100,42,197,130,47,173,98,134,75,145,92,43,38,116,86,156,15,6,79,7,131,200,106,46,150,53,117,5,163,128,60,57,63,11,94,93,176,212,72,197,65,163,6,234,124,86,176,68,31,100,154,49,173,143,72,197,237,105,106,44,203,248,63,80,218,217,60,22,6,191,207,97,193,108,102,206,184,152,35,60,53,143,27,144,11,122,217,105,25,199,127,208,116,99,239,50,158,146,52,119,213,237,137,28,145,110,64,68,123,42,194,217,37,32,133,54,76,24,76,226,74,241,123,102,192,221,111,220,7,73,243,123,162,141,42,56,217,97,207,210,21,172,217,47,44,8,25,147,225,236,81,87,238,134,163,210,7,136,185,115,227,241,169,108,30,81,238,182,72,175,244,234,82,237,204,129,222,104,80,8,33,32,205,21,136,173,125,198,36,175,122,20,53,148,198,13,181,188,206,209,115,119,152,87,74,110,64,25,172,121,128,155,59,41,51,114,203,171,169,235,169,180,194,92,10,110,120,17,245,124,84,53,224,194,144,91,211,212,110,169,180,240,202,156,150,176,61,69,124,65,232,167,30,215,91,42,162,104,6,25,166,77,90,158,75,249,184,84,139,4,60,16,39,107,144,28,111,53,34,156,134,204,174,5,189,176,34,77,10,16,234,36,201,21,83,216,13,6,20,253,26,199,47,6,201,133,146,107,234,109,156,120,84,42,181,41,193,122,5,130,77,190,253,133,212,26,152,165,44,99,234,24,233,154,208,29,80,55,33,5,170,133,82,251,217,253,40,48,86,137,80,89,156,214,123,27,165,209,140,141,207,151,226,58,143,186,60,60,215,49,170,131,253,67,46,151,160,106,49,59,209,168,199,162,45,105,117,150,135,143,82,245,228,132,80,143,120,76,242,182,105,33,55,59,40,126,61,159,63,193,172,228,60,68,102,53,45,100,254,158,207,49,136,239,96,60,98,186,29,129,50,169,246,96,77,200,23,151,246,9,153,42,64,120,15,202,177,71,134,77,231,236,142,94,103,119,198,76,186,170,24,247,85,248,37,177,14,116,132,33,15,43,80,184,13,241,225,47,214,195,161,31,164,70,66,177,178,202,183,52,65,222,114,160,188,130,149,87,249,84,45,237,26,112,180,135,245,87,115,120,216,232,221,248,208,177,16,180,111,181,11,66,180,90,37,246,211,129,75,101,138,27,211,42,184,20,11,89,45,181,255,166,89,237,86,162,126,179,9,237,201,161,143,131,222,98,238,118,88,163,79,119,23,212,91,55,211,150,149,132,135,200,209,94,241,187,198,96,23,228,177,87,58,161,190,48,67,145,4,167,198,239,166,152,155,183,250,218,163,46,157,225,76,62,186,58,157,83,92,137,242,237,115,172,64,75,171,82,216,250,196,46,22,54,203,246,153,223,138,169,71,218,139,228,207,125,24,44,222,7,188,44,253,251,166,253,87,116,223,57,222,142,218,107,59,6,215,103,104,119,185,133,185,95,47,57,184,208,251,56,170,246,79,48,133,183,142,88,131,94,39,173,11,11,217,96,240,31,91,2,66,148,200,13,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("7a74f28c-d197-4985-9821-907cb3fc7adb"));
		}

		#endregion

	}

	#endregion

}

