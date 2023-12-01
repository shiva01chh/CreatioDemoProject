﻿namespace Terrasoft.Configuration
{

	using System;
	using System.Collections.Generic;
	using System.Collections.ObjectModel;
	using System.Globalization;
	using Terrasoft.Common;
	using Terrasoft.Core;
	using Terrasoft.Core.Configuration;

	#region Class: TranslationBatchProviderSchema

	/// <exclude/>
	public class TranslationBatchProviderSchema : Terrasoft.Core.SourceCodeSchema
	{

		#region Constructors: Public

		public TranslationBatchProviderSchema(SourceCodeSchemaManager sourceCodeSchemaManager)
			: base(sourceCodeSchemaManager) {
		}

		public TranslationBatchProviderSchema(TranslationBatchProviderSchema source)
			: base( source) {
		}

		#endregion

		#region Methods: Protected

		protected override void InitializeProperties() {
			base.InitializeProperties();
			UId = new Guid("cd64cd09-2a6a-4dc0-b694-3526d65cb6be");
			Name = "TranslationBatchProvider";
			ParentSchemaUId = new Guid("50e3acc0-26fc-4237-a095-849a1d534bd3");
			CreatedInPackageId = new Guid("ab054f7f-9309-4520-a5a0-bfba22ceff76");
			ZipBody = new byte[] { 31,139,8,0,0,0,0,0,0,3,173,87,91,111,219,54,20,126,86,128,254,7,214,195,0,26,53,100,247,181,137,92,172,185,20,197,210,53,107,210,238,97,24,10,70,58,118,136,73,148,71,82,238,188,32,255,125,135,164,108,83,22,105,59,195,94,108,137,60,60,215,239,156,143,18,172,2,181,96,57,144,59,144,146,169,122,166,211,243,90,204,248,188,145,76,243,90,164,119,146,9,85,218,231,23,39,143,47,78,146,70,113,49,39,183,43,165,161,66,217,178,132,220,108,170,244,61,8,144,60,63,221,149,185,230,226,175,237,162,111,167,170,106,17,222,145,16,91,79,47,222,225,22,110,254,32,97,142,118,201,121,201,148,122,67,60,63,223,49,157,63,220,200,122,201,11,144,86,118,209,220,151,60,39,185,17,141,74,146,142,146,237,249,228,209,234,216,26,196,96,53,19,26,141,222,72,190,100,26,220,254,194,189,144,220,236,19,46,52,249,77,114,13,158,206,235,122,254,65,104,144,75,86,146,140,188,158,76,38,167,253,131,74,75,19,245,238,89,235,42,168,91,205,164,254,8,74,177,57,220,65,181,40,205,193,140,12,60,73,133,138,26,180,158,145,223,31,39,79,127,12,142,183,113,41,138,128,234,235,58,103,37,255,135,221,151,64,208,243,6,20,97,69,1,197,127,48,96,131,8,91,233,4,80,194,172,227,191,77,63,136,194,85,160,91,142,43,14,101,17,171,133,169,194,183,133,172,115,52,8,133,111,227,220,228,232,128,106,91,105,217,228,186,150,198,128,5,81,171,223,1,42,6,37,250,69,129,196,211,194,245,6,105,58,175,35,242,161,11,138,57,130,79,239,174,12,141,157,228,13,185,103,10,232,174,130,190,52,49,189,153,60,237,15,8,253,91,128,212,28,98,249,186,224,214,0,147,171,51,87,194,174,175,54,200,41,249,166,123,184,60,125,190,150,62,184,93,12,201,28,116,251,148,72,208,141,20,33,131,228,237,91,66,67,235,25,17,240,253,56,23,232,112,104,253,54,105,59,152,187,143,160,31,234,40,208,122,202,201,85,45,115,120,15,122,119,131,182,189,241,39,172,218,162,37,253,195,247,230,215,249,198,103,132,190,236,231,10,7,243,10,181,127,53,13,73,81,215,136,212,141,118,231,134,107,189,137,125,109,51,210,243,195,56,224,76,36,1,245,63,21,133,83,235,84,122,121,90,23,101,235,227,83,55,23,203,154,23,225,214,167,145,72,55,137,16,136,115,51,59,237,95,70,2,233,115,34,212,247,234,242,111,200,27,13,191,54,32,87,212,157,109,119,62,137,216,4,162,195,144,231,173,253,184,217,227,252,223,69,101,187,156,185,100,155,98,180,234,186,99,194,117,124,146,164,72,18,53,245,44,221,98,69,42,246,11,114,117,27,87,216,64,122,11,218,63,246,51,172,144,159,155,74,152,147,35,226,158,211,27,38,241,21,89,200,229,48,69,169,117,27,184,5,4,238,37,195,90,121,70,72,54,93,67,106,143,105,111,203,104,13,88,244,37,44,114,55,13,216,254,183,208,10,27,137,98,45,82,230,150,45,233,186,58,189,161,139,137,158,213,212,197,229,186,210,4,95,49,77,159,193,190,163,192,32,75,45,187,12,131,24,139,120,108,49,217,58,186,135,177,94,189,218,78,133,61,98,228,199,253,151,143,140,76,54,67,34,146,150,253,9,233,147,248,104,31,209,134,6,237,49,37,244,179,98,66,142,165,250,127,136,183,109,190,35,112,16,138,253,0,6,158,201,48,222,77,99,60,30,147,51,213,84,21,82,217,116,189,96,221,82,126,155,164,27,217,241,174,240,217,194,244,31,17,216,131,217,0,71,250,96,250,25,84,221,32,59,25,14,74,207,198,118,63,44,238,89,216,142,146,193,212,139,22,47,124,102,221,202,63,83,151,157,0,65,101,246,154,217,209,214,94,184,234,37,126,12,224,13,43,204,49,30,181,142,214,87,208,96,4,35,191,231,251,34,110,52,237,39,103,100,167,40,195,111,153,213,96,214,77,85,28,243,154,33,57,225,96,164,65,159,182,172,237,134,160,207,184,78,133,161,228,112,56,177,16,98,44,216,35,192,35,81,230,66,71,108,135,209,214,22,41,206,255,160,54,221,124,104,102,159,30,190,25,125,127,224,248,73,66,233,186,30,129,30,180,105,80,233,21,151,74,127,146,23,48,99,77,137,202,135,228,37,94,138,154,178,220,228,60,124,93,241,111,25,161,75,210,103,168,16,145,30,145,30,108,118,183,218,93,180,107,39,39,255,2,104,38,73,96,140,15,0,0 };
		}

		#endregion

		#region Methods: Public

		public override void GetParentRealUIds(Collection<Guid> realUIds) {
			base.GetParentRealUIds(realUIds);
			realUIds.Add(new Guid("cd64cd09-2a6a-4dc0-b694-3526d65cb6be"));
		}

		#endregion

	}

	#endregion

}

